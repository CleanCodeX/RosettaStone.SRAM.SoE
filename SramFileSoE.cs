using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using App.Commons.Helpers;
using SramCommons.Exceptions;
using SramCommons.Extensions;
using SramCommons.Models;
using SramFormat.SoE.Constants;
using SramFormat.SoE.Helpers;
using SramFormat.SoE.Models.Enums;
using SramFormat.SoE.Models.Structs;

namespace SramFormat.SoE
{
	public class SramFileSoE : SramFile<Sram, SramGame>
	{
		private readonly bool[] _validGames = new bool[4];

		public FileRegion Region { get; }

		public SramFileSoE(Stream stream, FileRegion region) : base(stream, Offsets.FirstGame, 3)
		{
			Requires.Equal(Marshal.SizeOf<Sram>(), Sizes.Sram, nameof(SramSize));
			Requires.Equal(Marshal.SizeOf<SramGame>(), Sizes.Game.All, nameof(GameSize));

			Debug.Assert(Sizes.Game.All == Sizes.Game.AllKnown + Sizes.Game.AllUnknown);

			Region = region;
		}

		public override bool IsValid(int gameIndex) => base.IsValid(gameIndex) && _validGames[gameIndex];

		public override void Load(Stream stream)
		{
			base.Load(stream);

			var anyGameIsValid = false;
			for (var gameIndex = 0; gameIndex <= 3; ++gameIndex)
			{
				var fileGameChecksum = GetChecksum(gameIndex);

				var calculatedChecksum = ChecksumHelper.CalcChecksum(SramBuffer, gameIndex, Region);
				if (fileGameChecksum != calculatedChecksum) continue;

				anyGameIsValid = true;
				_validGames[gameIndex] = true;
			}

			if (!anyGameIsValid)
				throw new InvalidSramFileException(SramError.NoValidGames);
		}

		public override SramGame GetGame(int gameIndex)
		{
#if DEBUG
			if (Debugger.IsAttached)
			{
				ref var game = ref Sram.Game[gameIndex];

#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
				// ReSharper disable UnusedVariable

				var boyLevel = game.BoyLevel;
				var boyExperience = game.BoyExperience;
				var boyCurrentHp = game.BoyCurrentHp;
				var boyMaxHp = game.BoyMaxHp;
				var boyName = game.BoyName.StringValue;

				var dogLevel = game.DogLevel;
				var dogExperience = game.DogExperience;
				var dogCurrentHp = game.DogCurrentHp;
				var dogMaxHp = game.DogMaxHp;
				var dogName = game.DogName.StringValue;

				var alchemies = game.Alchemies.ToString();
				var alchemyMajorLevels = game.AlchemyMajorLevels.ToString();
				var alchemyMinorLevels = game.AlchemyMinorLevels.ToString();
				var charms = game.Charms.ToString();
				var weapons = game.Weapons.ToString();
				var weaponLevels = game.WeaponLevels.ToString();
				var dogAttackLevel = game.DogAttackLevel.ToString();
				var money = game.Moneys.ToString();
				var items = game.Items.ToString();
				var armors = game.Armors.ToString();
				var ammunitions = game.BazookaAmmunitions.ToString();
				var tradeGoods = game.TradeGoods.ToString();

				var unknown1 = game.Unknown1.FormatAsString();
				var unknown2 = game.Unknown2.FormatAsString();
				var unknown3 = game.Unknown3.FormatAsString();
				var unknown4 = game.Unknown4_BoyBuff.FormatAsString();
				var unknown5 = game.Unknown5.FormatAsString();
				var unknown6 = game.Unknown6.FormatAsString();
				var unknown7 = game.Unknown7_DogBuff.FormatAsString();
				var unknown8 = game.Unknown8.FormatAsString();
				var unknown9 = game.Unknown9.FormatAsString();
				var unknown10 = game.Unknown10.FormatAsString();
				var unknown11 = game.Unknown11.FormatAsString();
				var unknown12A = game.Unknown12A.FormatAsString();
				var unknown12B = game.Unknown12B.ToString();
				var unknown12C = game.Unknown12C.FormatAsString();
				var unknown13 = game.Unknown13.FormatAsString();
				var unknown14 = game.Unknown14_AntiquaFlags.ToString();
				var unknown15 = game.Unknown15.FormatAsString();
				var unknown16A = game.Unknown16A.FormatAsString();
				var unknown16B = game.Unknown16B_GoticaFlags.ToString();
				var unknown16C = game.Unknown16C.FormatAsString();
				var unknown17 = game.Unknown17.FormatAsString();
				var unknown18 = game.Unknown18.FormatAsString();

				// ReSharper restore UnusedVariable
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
			}
#endif
			return base.GetGame(gameIndex);
		}

		public override void Save(Stream stream)
		{
			for (var gameIndex = 0; gameIndex <= 3; ++gameIndex)
				if (IsValid(gameIndex))
					SetChecksum(gameIndex, ChecksumHelper.CalcChecksum(SramBuffer, gameIndex, Region));

			base.Save(stream);
		}

		public ushort GetChecksum(int gameIndex)
		{
			var offset = FirstGameOffset + gameIndex * GameSize + Offsets.Game.Checksum;
			return BitConverter.ToUInt16(SramBuffer, offset);
		}

		public void SetChecksum(int gameIndex, ushort checksum)
		{
			var offset = FirstGameOffset + gameIndex * GameSize + Offsets.Game.Checksum;
			var bytes = BitConverter.GetBytes(checksum);
			Array.Reverse(bytes);
			checksum = BitConverter.ToUInt16(bytes);

			Sram.Game[gameIndex].Checksum = checksum;

			bytes.CopyTo(SramBuffer, offset);
		}
	}
}