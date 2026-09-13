using CalamityEntropyLegacy.Content.NPCs.Cruiser;
using CalamityEntropyLegacy.Content.NPCs.NihilityTwin;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Biomes
{
    public class VoidDummyBoime : ModBiome
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override string BestiaryIcon => "CalamityEntropyLegacy/Assets/VoidDummyBoimeIcon";
        public override string BackgroundPath => "CalamityEntropyLegacy/Assets/VoidBack";
        public override bool IsBiomeActive(Player player)
        {
            return NPC.AnyNPCs(ModContent.NPCType<NihilityActeriophage>()) || NPC.AnyNPCs(ModContent.NPCType<CruiserHead>());
        }
    }
}