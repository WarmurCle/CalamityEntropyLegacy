using CalamityEntropyLegacy.Core;
using CalamityMod.DataStructures;
using CalamityMod.Systems.Collections;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class MechanicalTrauma : ModBuff
    {
        public static DebuffData debuffData = new DebuffData
        {
            EnemyLostRegen = CrossModSystem.IEoRBalancing ? 10 : 20,
            PlayerLostRegen = CrossModSystem.IEoRBalancing ? 4 : 4,
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