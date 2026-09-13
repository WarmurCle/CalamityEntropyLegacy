using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class WindPressure : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = false;
            BuffID.Sets.LongerExpertDebuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
        }
    }
}
