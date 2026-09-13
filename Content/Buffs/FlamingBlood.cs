using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class FlamingBlood : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
        }
    }
}
