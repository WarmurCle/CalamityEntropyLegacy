using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Donator
{
    public class ManaVein : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = false;
        }
    }
}
