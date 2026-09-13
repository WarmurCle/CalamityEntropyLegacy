using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content
{
    public class NMSPLayer : ModPlayer
    {
        public int SwingIndex;
        public int DontUseItemTime;
        public override void PostUpdate()
        {
            if (DontUseItemTime > 0)
            {
                DontUseItemTime--;
            }
        }
    }
}
