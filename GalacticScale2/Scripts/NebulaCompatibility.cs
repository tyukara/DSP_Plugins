﻿using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using NebulaAPI;
using UnityEngine.PostProcessing;

namespace GalacticScale
{
    [BepInPlugin("dsp.galactic-scale.2.nebula", "Galactic Scale 2 Nebula Compatibility Plug-In", "1.0.0.0")]
    [BepInDependency(NebulaModAPI.API_GUID)]
    public class Ignore_This_Warning_If_Not_Using_Nebula_Multiplayer_Mod : BaseUnityPlugin, IMultiplayerModWithSettings
    {
        public new static ManualLogSource Logger;

        private void Awake()
        {
            NebulaModAPI.RegisterPackets(Assembly.GetExecutingAssembly());
            var v = Assembly.GetExecutingAssembly().GetName().Version;
            BCE.Console.Init();
            var _ = new Harmony("dsp.galactic-scale.2.depcheck");
            Logger = new ManualLogSource("GS2DepCheck");
            BepInEx.Logging.Logger.Sources.Add(Logger);
            Logger.Log(LogLevel.Message, "Loaded");
            // Harmony.CreateAndPatchAll(typeof(NebulaCompatPatch));
            
        }

        public string Version => Bootstrap.VERSION;

        bool IMultiplayerMod.CheckVersion(string hostVersion, string clientVersion)
        {
            return hostVersion.Equals(clientVersion);
        }

        public void Export(BinaryWriter w)
        {
            var settings = GSSettings.Serialize();
            w.Write(settings);
        }

        public void Import(BinaryReader r)
        {
            var settings = r.ReadString();
            GSSettings.DeSerialize(settings);
        }
        
    }

    public static class NebulaCompatPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(GameData), "SetForNewGame")]
        public static void NebulaCheck()
        {
            if (NebulaModAPI.IsMultiplayerActive && NebulaModAPI.MultiplayerSession.LocalPlayer.IsClient) GS2.NebulaClient = true;
            else GS2.NebulaClient = false;
        }
    }
}