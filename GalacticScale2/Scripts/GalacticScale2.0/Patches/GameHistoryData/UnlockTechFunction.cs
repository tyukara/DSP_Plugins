﻿using HarmonyLib;

namespace GalacticScale
{
    public static class PatchOnGameHistoryData
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(GameHistoryData), "get_logisticShipWarpSpeedModified")]
        public static void get_logisticShipWarpSpeedModified(ref float __result, ref GameHistoryData __instance)
        {
            __result = __instance.logisticShipWarpSpeed * __instance.logisticShipSpeedScale * GS2.Config.LogisticsShipMulti;
        }
    }
}