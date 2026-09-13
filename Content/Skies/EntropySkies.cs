using Terraria.Graphics.Effects;

namespace CalamityEntropyLegacy.Content.Skies
{
    public static class EntropySkies
    {
        public static void setUpSkies()
        {
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:Cruiser"] = new Filter(new CrScreenShaderData("FilterMiniTower").UseColor(Color.Transparent).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:Cruiser"] = new CrSky();
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:DimensionLens"] = new Filter(new TransScreenShaderData("FilterMiniTower").UseColor(Color.Transparent).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:DimensionLens"] = new LlSky();
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:NihTwin"] = new Filter(new TransScreenShaderData("FilterMiniTower").UseColor(Color.Transparent).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:NihTwin"] = new NihTwinSky();
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:VoidVortex"] = new Filter(new TransScreenShaderData("FilterMiniTower").UseColor(new Color(60, 30, 100)).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:VoidVortex"] = new VoidVortexSky();
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:Snowgrave"] = new Filter(new TransScreenShaderData("FilterMiniTower").UseColor(new Color(200, 200, 255)).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:Snowgrave"] = new SnowgraveSky();
            Terraria.Graphics.Effects.Filters.Scene["CalamityEntropyLegacy:SunriseSky"] = new Filter(new TransScreenShaderData("FilterMiniTower").UseColor(Color.White).UseOpacity(0f), EffectPriority.VeryHigh);
            SkyManager.Instance["CalamityEntropyLegacy:SunriseSky"] = new SunriseSky();
        }
    }
}
