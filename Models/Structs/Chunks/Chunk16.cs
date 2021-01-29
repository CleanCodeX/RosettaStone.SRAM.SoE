using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// EquWeapon_Moneys_EquAlchemies_WeaponLvls_DogAtkLvl
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk16"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk16
	{
		public UInt16 CurrentEquippedWeapon; // [240|xF0] :: (2 bytes)

		// Unknown 9
		public UInt16 Unknown9; // [242|xF2] :: (2 bytes)

		public UInt16 DogCollarStatsPointer; // [244|xF4] :: (2 bytes)
		public UInt16 BoyVestsStatsPointer; // [246|xF6] :: (2 bytes)
		public UInt16 BoyHatsStatsPointer; // [248|xF8] :: (2 bytes)
		public UInt16 BoyBraceletStatsPointer; // [250|xFA] :: (2 bytes)

		// Money
		public Moneys Moneys; // [252|xFC] :: (12 bytes)

		// WRAM
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.EquippedAlchemies)]
		public byte[] EquippedAlchemies; // [264|x108] :: (9 bytes)

		public byte CurrentMapId;// [273|x111] :: (1 byte)

		// Unknown 10
		public byte Unknown10; // [274|x112] :: (1 byte)

		// Weapon Levels
		public WeaponLevels WeaponLevels; // [275|x113] :: (28 bytes)

		// Unknown 11
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown11)]
		public byte[] Unknown11; // [303|x12F] :: (14 bytes)

		public WeaponLevel DogAttackLevel; // [317|x13D] :: (2 bytes)

		// Unknown 12 A
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown12A)]
		public byte[] Unknown12A; // [319|x13F] :: (16 bytes)

		// Unknown 12 B
		public UInt16 Unknown12B;// 335|x14F] :: (2 bytes) Note: contains probably frame-counter, changes at every in-game save

		// Unknown 12 C
		public uint Unknown12C; // [337|x151] :: (4 bytes)

		public override string ToString() => this.FormatAsString();
	}
}