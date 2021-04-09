﻿using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using FullSerializer;
using GalacticScale.Scripts.PatchStarSystemGeneration.Generator;
using HarmonyLib;
using PatchSize = GalacticScale.Scripts.PatchPlanetSize.PatchForPlanetSize;

namespace GalacticScale.Scripts.PatchStarSystemGeneration {
    [BepInPlugin("dsp.galactic-scale.star-system-generation", "Galactic Scale Plug-In - Star System Generation", "2.0.0")]

    public class PatchForStarSystemGeneration : BaseUnityPlugin {
        public new static ManualLogSource Logger;
        // Internal Variables
        public static bool DebugReworkPlanetGen = false;
        public static bool DebugReworkPlanetGenDeep = false;
        public static bool DebugStarGen = false;
        public static bool DebugStarGenDeep = false;
        public static bool DebugStarNamingGen = false;
        public static bool DebugPlanetDistribution = false;

        public static GeneratorGlobalSettings gen = new GeneratorGlobalSettings();


        public class Test {
            public string test;
        }

        internal void Awake() {
            var harmony = new Harmony("dsp.galactic-scale.star-system-generation");

            //Adding the Logger
            Logger = new ManualLogSource("PatchForStarSystemGeneration");


                Harmony.CreateAndPatchAll(typeof(PatchOnUIPlanetDetail));
                Harmony.CreateAndPatchAll(typeof(PatchOnStarGen));
                Harmony.CreateAndPatchAll(typeof(PatchOnPlanetGen));
                Harmony.CreateAndPatchAll(typeof(PatchOnUISpaceGuide));
                Harmony.CreateAndPatchAll(typeof(PatchOnStationComponent));
                Harmony.CreateAndPatchAll(typeof(PatchOnUIStarDetail));

        public static void Debug(object data, LogLevel logLevel, bool isActive) {
            if (isActive) Logger.Log(logLevel, data);

        }

    }
}
