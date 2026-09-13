using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopGolden : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopGoldenProjectile>();
        }
        public override float getRollChance()
        {
            return 0.32f;
        }
    }
}
