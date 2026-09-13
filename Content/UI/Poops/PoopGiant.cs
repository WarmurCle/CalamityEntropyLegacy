using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopGiant : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopGiantProjectile>();
        }

        public override float getRollChance()
        {
            return 0.1f;
        }
    }
}
