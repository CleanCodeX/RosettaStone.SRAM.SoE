using System.Diagnostics;
using System.Runtime.InteropServices;
using SoE.Models.Enums;
using IO.Extensions;
using IO.Helpers;
using SRAM.SoE.Models.Enums;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// LastLanding_CurrentWeapon
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk20"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[HasComplexMembers]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Chunk20
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17C)]
		public byte[] Unknown17C; // [741|x2DD] :: (2 bytes) 

		/// 00 - 1A, even numbers, inclusive. See <see cref="Weapons" /> for weapon order.
		public byte CurrentEquippedWapon; // [743|x2E7] :: (1 byte) 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17D)]
		public byte[] Unknown17D; // [744|x2E8] :: (3 bytes)

		public DogAppearance DogAppearance; // [747|x2EB] :: (1 byte) 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17E)]
		public byte[] Unknown17E; // [744|x2E8] :: (3 bytes)

		public LandingLocation LastLandingLocation; // [747|x2EB] :: (1 byte) 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17F)]
		public byte[] Unknown17F; // [748|x2EC] :: (33 bytes) 

		public override string ToString() => this.FormatAsString();
	}
}