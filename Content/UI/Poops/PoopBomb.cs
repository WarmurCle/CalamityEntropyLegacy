using CalamityEntropyLegacy.Content.Projectiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.UI.Poops
{
    public class PoopBomb : Poop
    {
        public override int ProjectileType()
        {
            return ModContent.ProjectileType<PoopBombProjectile>();
        }
    }
}
