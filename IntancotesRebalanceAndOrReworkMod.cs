using MelonLoader;
using BTD_Mod_Helper;
using IntancotesRebalanceAndOrReworkMod;

[assembly: MelonInfo(typeof(IntancotesRebalanceAndOrReworkMod.IntancotesRebalanceAndOrReworkMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace IntancotesRebalanceAndOrReworkMod;

public class IntancotesRebalanceAndOrReworkMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<IntancotesRebalanceAndOrReworkMod>("IntancotesRebalanceAndOrReworkMod loaded!");
    }
}