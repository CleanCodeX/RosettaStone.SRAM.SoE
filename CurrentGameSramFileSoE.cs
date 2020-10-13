using System.IO;
using SramFormat.SoE.Models.Enums;
using SramFormat.SoE.Models.Structs;

namespace SramFormat.SoE
{
	/// <summary>
	/// Implementation of SramFileSoE with <see cref="CurrentGame"/> functionality
	/// </summary>
	public class CurrentGameSramFileSoE : SramFileSoE
	{
		public CurrentGameSramFileSoE(Stream stream, FileRegion region) : base(stream, region)
		{ }

		private SramGame _currentGame;
		/// <summary>
		/// The current game data
		/// </summary>
		public ref SramGame CurrentGame => ref _currentGame;

		private int _currentGameIndex = -1;

		/// <summary>
		/// The current game index
		/// Setting the index set sets automatically <see cref="CurrentGame"/>
		/// </summary>
		public virtual int CurrentGameIndex
		{
			get => _currentGameIndex;
			set
			{
				_currentGameIndex = value;
				_currentGame = GetGame(value);
			}
		}

		/// <summary>
		/// Overwrites game data for <see cref="CurrentGameIndex"/> with modified data from <see cref="CurrentGame"/>
		/// </summary>
		public virtual void AcceptCurrentGameChanges() => SetGame(CurrentGameIndex, CurrentGame);

		/// <summary>
		/// Overwrites game data for <see cref="CurrentGameIndex"/> with original data from <see cref="CurrentGameSramFileSoE.Sram"/> buffer
		/// </summary>
		public virtual void DiscardCurrentGameChanges() => base.SetGame(CurrentGameIndex, Sram.Game[CurrentGameIndex]);
	}
}