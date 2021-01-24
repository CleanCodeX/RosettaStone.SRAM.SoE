// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable PossibleLossOfFraction

namespace SRAM.SoE.Models
{
	/// <summary>
	/// Known sizes of SoE's S-RAM buffer
	/// </summary>
	public class SramSizes
	{
		public const int AudioMode = 1;
		public const int LastSaveSlotId = 1;
		
		/// Size of the S-RAM file
		public const int All = AudioMode + LastSaveSlotId + SaveSlot.All * 4 + Unknown19;

		public static readonly bool IsValid = All == 8_192;

		/// <summary>Sizes of save slot buffers</summary>
		public class SaveSlot
		{
			public const int Checksum = 2;
			public const int LastSavePointName = 36;

			#region Chunks 1-21
			public const int Chunk01 = 72; // (x24) 
			public const int Chunk02 = 2; // (x2) 
			public const int Chunk03 = 24; // (x18) 
			public const int Chunk04 = 6; // (x6) 
			public const int Chunk05 = 2; // (x2) 
			public const int Chunk06 = 13; // (xD) 
			public const int Chunk07 = 4; // (x4) 
			public const int Chunk08 = 14; // (xE) 
			public const int Chunk09 = 2; // (x2) 
			public const int Chunk10 = 24; // (x18) 
			public const int Chunk11 = 6; // (x6) 
			public const int Chunk12 = 2; // (x2) 
			public const int Chunk13 = 13; // (xD)
			public const int Chunk14 = 4; // (x4) 
			public const int Chunk15 = 14; // (xE)
			public const int Chunk16 = 101; // (x65)
			public const int Chunk17 = 162; // (xA2) 
			public const int Chunk18 = 146; // (x92)
			public const int Chunk19 = 92; // (x5C) 
			public const int Chunk20 = 44; // (x2C) 
			public const int Chunk21 = 32; // (x20)
			#endregion

			public const int Unknown4 = 6;
			public const int Unknown6 = 14;
			public const int Unknown7 = 6;
			public const int Unknown8 = 10;
			public const int Unknown9 = 2;
			public const int Unknown10 = 3;
			public const int Unknown11 = 14;

			public const int EquippedAlchemies = 9;

			#region Unknown12
			public const int Unknown12A = 16;
			public const int Unknown12B = 2;
			public const int Unknown12C = 4;
			#endregion

			public const int Unknown13 = 22;
			public const int Unknown14 = 4;
			public const int Unknown15 = 24;

			#region Unknown16
			public const int Unknown16A = 4;
			public const int Unknown16B_GothicaFlags = 4;
			public const int Unknown16C = 6;
			#endregion

			#region Unknown17
			public const int Unknown17A = 12;
			public const int Unknown17B = 5;
			public const int Unknown17C = 2;
			public const int Unknown17D = 3;
			public const int Unknown17E = 3;
			public const int Unknown17F = 33;
			public const int Unknown17G = 4;
			#endregion

			public const int Unknown18 = 2;

			public const int AllUnknown = Unknown4 + Unknown6 + Unknown7 + Unknown8 + Unknown9 + 
			                              Unknown10 + Unknown11 + 
			                              Unknown12A + Unknown12B + Unknown12C + 
			                              Unknown13 + Unknown14 + Unknown15 + 
			                              Unknown16A + Unknown16B_GothicaFlags + Unknown16C + 
			                              Unknown17A + Unknown17B + Unknown17C + Unknown17D + 
			                              Unknown17E + Unknown17F + Unknown17G + 
			                              Unknown18;

			public const int AllChunks = Chunk01 + Chunk02 + Chunk03 + Chunk04 + Chunk05 + 
			                             Chunk06 + Chunk07 + Chunk08 + Chunk09 + Chunk10 + 
			                             Chunk11 + Chunk12 + Chunk13 + Chunk14 + Chunk15 + 
			                             Chunk16 + Chunk17 + Chunk18 + Chunk19 + Chunk20 + 
			                             Chunk21;

			public const int All = AllChunks + LastSavePointName + Checksum;
			public const int AllKnowns = All - AllUnknown;

			public static readonly double UnknownPercentage = AllUnknown * 100D / All;
			public static readonly double KnownPercentage = AllKnowns * 100D / All;

			public static readonly bool IsValid = All == 817;
		}

		/// Size of the S-RAM Unknown buffer
		public const int Unknown19 = 4_922;
	}
}