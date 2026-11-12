using CalamityEntropyLegacy.Content.Particles;
using CalamityEntropyLegacy.Core;
using CalamityMod.DataStructures;
using CalamityMod.Systems.Collections;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class MechanicalTrauma : ModBuff
    {
        public static DebuffData debuffData = new DebuffData
        {
            EnemyLostRegen = CrossModSystem.IEoRBalancing ? 20 : 20,
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

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (Main.rand.NextBool(9))
            {
                Vector2 particlePosition = npc.position + new Vector2(
                    Main.rand.NextFloat(npc.width),
                    Main.rand.NextFloat(npc.height)
                );

                EParticle.spawnNew(new ShineParticle(), particlePosition, Vector2.Zero, Color.Firebrick, 0.24f, 1, true, BlendState.Additive, 0, 12);
                EParticle.spawnNew(new ShineParticle(), particlePosition, Vector2.Zero, Color.White, 0.06f, 1, true, BlendState.Additive, 0, 12);
            }
        }
    }
}