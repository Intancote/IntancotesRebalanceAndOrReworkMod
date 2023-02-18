using MelonLoader;
using BTD_Mod_Helper;
using IntancotesRebalanceAndOrReworkMod;

[assembly: MelonInfo(typeof(IntancotesRebalanceAndOrReworkMod.IntancotesRebalanceAndOrReworkMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace IntancotesRebalanceAndOrReworkMod;

{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<IntancotesRebalanceAndOrReworkMod>("IntancotesRebalanceAndOrReworkMod loaded!");
    }

    public class IntancotesRebalanceAndOrReworkMod : BloonsTD6Mod
    {

        /// <summary>
        /// Support the Ultimate Crosspathing Mod
        /// <br />
        /// That mod will handle actually allowing the upgrades to happen in the UI
        /// </summary>
        public override bool IsValidCrosspath(int[] tiers) =>
            ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);
    }
}