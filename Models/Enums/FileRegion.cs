using Common.Shared.Min.Attributes;
using Res = SramFormat.SoE.Properties.Resources;

namespace SramFormat.SoE.Models.Enums
{
	/// The game's regions
	public enum FileRegion
	{
		[DisplayNameLocalized(nameof(Res.UnitedStates), typeof(Res))]
		UnitedStates,

		[DisplayNameLocalized(nameof(Res.England), typeof(Res))]
		England,

		[DisplayNameLocalized(nameof(Res.France), typeof(Res))]
		France,

		[DisplayNameLocalized(nameof(Res.Germany), typeof(Res))]
		Germany,

		[DisplayNameLocalized(nameof(Res.Spain), typeof(Res))]
		Spain
	}
}