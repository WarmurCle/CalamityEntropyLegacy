using CalamityEntropyLegacy.Core;
using CalamityMod.DataStructures;
using CalamityMod.Systems.Collections;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class LifeOppress : ModBuff
    {
        public static DebuffData debuffData = new DebuffData
        {
            EnemyLostRegen = CrossModSystem.IEoRBalancing ? 2500 : 4500,
            DrawAboveNPC = true
        };

        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;

            CalamityBuffSets.DebuffDataset[Type] = debuffData;
        }
    }
}