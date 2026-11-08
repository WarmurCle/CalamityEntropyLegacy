using CalamityEntropyLegacy.Core;
using CalamityMod.DataStructures;
using CalamityMod.Systems.Collections;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class BonePiercingToxin : ModBuff
    {
        public static DebuffData debuffData = new DebuffData
        {
            EnemyLostRegen = CrossModSystem.IEoRBalancing ? 25 : 25,
            PlayerLostRegen = CrossModSystem.IEoRBalancing ? 6 : 6,
            SicknessDebuffScaling = 1f,
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