using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// DogMaxHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk12"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk12
	{
		public UInt16 DogMaxHp; // [207|xCF] :: (2 bytes)

		public override string ToString() => DogMaxHp.ToString();
	}
}