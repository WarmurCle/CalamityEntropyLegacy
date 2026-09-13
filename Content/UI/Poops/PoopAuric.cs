using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopAuric : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopAuricProjectile>();
        }

        public override float getRollChance()
        {
            return 0.08f;
        }
    }
}
