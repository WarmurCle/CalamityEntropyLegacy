using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class ServiceBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
        }
    }
}
