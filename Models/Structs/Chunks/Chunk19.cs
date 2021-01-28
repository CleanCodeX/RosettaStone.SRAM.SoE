using System.Diagnostics;
using System.Runtime.InteropServices;
using IO.Extensions;
using IO.Helpers;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Ingredients_Items_Armors_Ammo_FlyingMachine
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk19"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[ContainsComplexStructures]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk19
	{
		public Ingredients Ingredients; // [649|x289] :: (22 bytes)
		public Items Items; // [671|x29F] :: (8 bytes)
		public Armors Armors; // [679|x2A7] :: (40 bytes)
		public BazookaAmmunitions BazookaAmmunitions; // [719|x2CF] :: (4 bytes)

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17A)]
		public byte[] Unknown17A; // [723|x2D3] :: (12 bytes) 

		// 00 = none, 01 = Windwalker, 02 = Escape Pod
		public byte FlyingMachineType; // [734|x2DE] :: (1 byte) 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17B)]
		public byte[] Unknown17B; // [735|x2DF] :: (5 bytes) 

		public override string ToString() => this.FormatAsString();
	}
}