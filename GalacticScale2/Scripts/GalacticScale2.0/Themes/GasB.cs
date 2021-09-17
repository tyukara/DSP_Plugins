﻿using System.Collections.Generic;
using UnityEngine;

namespace GalacticScale
{
    public static partial class Themes
    {
        public static GSTheme GasII = new GSTheme
        {
            Name = "GasGiant3",
            Base = true,
            DisplayName = "Gas Giant III".Translate(),
            PlanetType = EPlanetType.Gas,
            LDBThemeId = 2,
            MinRadius = 5,
            MaxRadius = 510,
            ThemeType = EThemeType.Gas,

            Algo = 0,
            MaterialPath = "Universe/Materials/Planets/Gas 1/",
            Variant = 1,
            Temperature = 2.0f,
            Distribute = EThemeDistribute.Default,
            ModX = new Vector2(0.0f, 0.0f),
            ModY = new Vector2(0.0f, 0.0f),
            VeinSettings = new GSVeinSettings { Algorithm = "Vanilla" },
            AmbientSettings = new GSAmbientSettings(),
            Vegetables0 = new int[] { },
            Vegetables1 = new int[] { },
            Vegetables2 = new int[] { },
            Vegetables3 = new int[] { },
            Vegetables4 = new int[] { },
            Vegetables5 = new int[] { },
            VeinSpot = new int[] { },
            VeinCount = new float[] { },
            VeinOpacity = new float[] { },
            RareVeins = new int[] { },
            RareSettings = new float[] { },
            GasItems = new[]
            {
                1120,
                1121
            },
            GasSpeeds = new[]
            {
                0.96f,
                0.04f
            },
            UseHeightForBuild = false,
            Wind = 0f,
            IonHeight = 0f,
            WaterHeight = 0f,
            WaterItemId = 0,
            Musics = new int[] { },
            SFXPath = "SFX/sfx-amb-massive",
            SFXVolume = 0.35f,
            CullingRadius = 0f,
            atmosphereMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_Color"] = new Color(0.3443396f, 0.734796f, 1f, 1f),
                    ["_Color0"] = new Color(0.7921569f, 0.439838f, 0.3843137f, 1f),
                    ["_Color1"] = new Color(0.8f, 0.5698366f, 0.4941176f, 1f),
                    ["_Color2"] = new Color(0.7921569f, 0.6024006f, 0.5254902f, 1f),
                    ["_Color3"] = new Color(0.7450981f, 0.5429098f, 0.4823529f, 1f),
                    ["_Color4"] = new Color(0.9890897f, 0.7606286f, 0.4265787f, 1f),
                    ["_Color5"] = new Color(0f, 0f, 0f, 1f),
                    ["_Color6"] = new Color(0.05699679f, 0f, 0.1415094f, 1f),
                    ["_Color7"] = new Color(0f, 0f, 0f, 1f),
                    ["_Color8"] = new Color(1f, 1f, 1f, 1f),
                    ["_EmissionColor"] = new Color(0f, 0f, 0f, 1f),
                    ["_LocalPos"] = new Color(0f, 0f, 0f, 0f),
                    ["_PlanetPos"] = new Color(0f, 0f, 0f, 0f),
                    ["_PlanetRadius"] = new Color(800f, 800f, 840f, 0f),
                    ["_Sky0"] = new Color(0f, 0f, 0f, 0.1607843f),
                    ["_Sky1"] = new Color(0f, 0f, 0f, 0.09803922f),
                    ["_Sky2"] = new Color(0f, 0f, 0f, 0.9176471f),
                    ["_Sky3"] = new Color(0f, 0f, 0f, 0.5411765f),
                    ["_Sky4"] = new Color(1f, 0.7398548f, 0.3210239f, 1f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_AtmoDensity"] = 2f,
                    ["_AtmoThickness"] = 70f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_Density"] = 0.005f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_DstBlend"] = 0f,
                    ["_FogDensity"] = 1.1f,
                    ["_FogSaturate"] = 1f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.5f,
                    ["_GlossyReflections"] = 1f,
                    ["_GroundAtmosPower"] = 3f,
                    ["_Intensity"] = 1f,
                    ["_IntensityControl"] = 1f,
                    ["_Metallic"] = 0f,
                    ["_Mode"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_SkyAtmosPower"] = 7f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_SrcBlend"] = 1f,
                    ["_SunColorAdd"] = 0f,
                    ["_SunColorSkyUse"] = 1f,
                    ["_SunColorUse"] = 1f,
                    ["_SunRiseScatterPower"] = 60f,
                    ["_UVSec"] = 0f,
                    ["_ZWrite"] = 1f
                }
            },
            minimapMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_Color"] = new Color(1f, 0.71988f, 0.682353f, 1f),
                    ["_ColorBio0"] = new Color(1f, 0.6617956f, 0.6078432f, 1f),
                    ["_ColorBio1"] = new Color(0.8018868f, 0.345823f, 0.2912512f, 1f),
                    ["_ColorBio2"] = new Color(1f, 0.677347f, 0.6273585f, 1f),
                    ["_EmissionColor"] = new Color(0f, 0f, 0f, 1f),
                    ["_HeightSettings"] = new Color(-0.1f, 0.3f, 0.1f, 0.1f),
                    ["_RimColor"] = new Color(1f, 0.5157562f, 0.3921568f, 1f),
                    ["_ShoreLineColor"] = new Color(0f, 0f, 0f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_BioStrength"] = 0.35f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_DstBlend"] = 0f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.5f,
                    ["_GlossyReflections"] = 1f,
                    ["_Metallic"] = 0f,
                    ["_Mode"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_ShoreHeight"] = 0f,
                    ["_ShoreInvThick"] = 13f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_SrcBlend"] = 1f,
                    ["_UVSec"] = 0f,
                    ["_WireIntens"] = 1f,
                    ["_ZWrite"] = 1f
                }
            },
            terrainMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_AmbientColor0"] = new Color(0f, 0f, 0f, 0f),
                    ["_AmbientColor1"] = new Color(0f, 0f, 0f, 0f),
                    ["_AmbientColor2"] = new Color(0f, 0f, 0f, 0f),
                    ["_Color"] = new Color(1f, 1f, 1f, 1f),
                    ["_DistortSettings1"] = new Color(100f, 27f, 10f, 13f),
                    ["_DistortSettings2"] = new Color(22f, 11f, 10f, 19f),
                    ["_EmissionColor"] = new Color(0f, 0f, 0f, 1f),
                    ["_FlowColor"] = new Color(0.7830188f, 0.7830188f, 0.7830188f, 0.8862745f),
                    ["_RimColor"] = new Color(1f, 1f, 1f, 1f),
                    ["_Rotation"] = new Color(0f, 0f, 0f, 1f),
                    ["_SpecularColor"] = new Color(0.0627451f, 0.2197301f, 0.3411765f, 1f),
                    ["_Spot0"] = new Color(0.6f, -0.3f, -0.5f, 1f),
                    ["_SunDir"] = new Color(0.8f, 0.6f, 0f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_Distance"] = 0f,
                    ["_Distort"] = 0.01f,
                    ["_DstBlend"] = 0f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.15f,
                    ["_GlossyReflections"] = 1f,
                    ["_Metallic"] = 0.58f,
                    ["_Mode"] = 0f,
                    ["_Multiplier"] = 1f,
                    ["_NoiseThres"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_PolarWhirl"] = -0.3f,
                    ["_PolarWhirlPower"] = 10f,
                    ["_Radius"] = 800f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_Speed"] = 6f,
                    ["_SrcBlend"] = 1f,
                    ["_TileX"] = 6f,
                    ["_TileY"] = 3f,
                    ["_UVSec"] = 0f,
                    ["_ZWrite"] = 1f
                }
            },
            thumbMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_AmbientColor"] = new Color(0.3113208f, 0.03009028f, 0.01321644f, 1f),
                    ["_Color"] = new Color(1f, 0.7151759f, 0.6556604f, 1f),
                    ["_ColorBio0"] = new Color(1f, 0.5789151f, 0.4669811f, 1f),
                    ["_ColorBio1"] = new Color(0.8018868f, 0.345823f, 0.2912512f, 1f),
                    ["_ColorBio2"] = new Color(1f, 0.677347f, 0.6273585f, 1f),
                    ["_EmissionColor"] = new Color(0f, 0f, 0f, 1f),
                    ["_FlowColor"] = new Color(0.7924528f, 0.7924528f, 0.7924528f, 0.7882353f),
                    ["_HeightSettings"] = new Color(-0.1f, 0.3f, 0.1f, 0.1f),
                    ["_HoloColor"] = new Color(0.3f, 0.7f, 0.25f, 0.2f),
                    ["_NotVisibleColor"] = new Color(0f, 0.03f, 0.07499998f, 0.2f),
                    ["_RimColor"] = new Color(1f, 0.5140815f, 0.3921568f, 1f),
                    ["_Rotation"] = new Color(0f, 0f, 0f, 1f),
                    ["_ShoreLineColor"] = new Color(0f, 0f, 0f, 0f),
                    ["_SpecularColor"] = new Color(0.5188679f, 0.3004048f, 0.1737718f, 1f),
                    ["_Spot0"] = new Color(0.6f, -0.3f, -0.5f, 1f),
                    ["_SunDir"] = new Color(0f, 0f, 1f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_BioStrength"] = 0.35f,
                    ["_BodyIntensity"] = 0.27f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_Diameter"] = 0.4f,
                    ["_Distort"] = 0.01f,
                    ["_DstBlend"] = 0f,
                    ["_FarHeight"] = 0.5f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.15f,
                    ["_GlossyReflections"] = 1f,
                    ["_HoloIntensity"] = 0.8f,
                    ["_Metallic"] = 0.58f,
                    ["_Mode"] = 0f,
                    ["_Multiplier"] = 4f,
                    ["_NoiseIntensity"] = 0.15f,
                    ["_NoiseThres"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_PolarWhirl"] = -0.3f,
                    ["_PolarWhirlPower"] = 8f,
                    ["_ShoreHeight"] = 0f,
                    ["_ShoreInvThick"] = 13f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_Speed"] = 2f,
                    ["_SrcBlend"] = 1f,
                    ["_Tile"] = 0.2f,
                    ["_TileX"] = 7f,
                    ["_TileY"] = 2.5f,
                    ["_TimeFactor"] = 0f,
                    ["_ToggleVerta"] = 0f,
                    ["_UVSec"] = 0f,
                    ["_WireIntens"] = 2f,
                    ["_ZWrite"] = 1f
                }
            }
        };
    }
}