using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class ShatteredOrb : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
        }
    }
}