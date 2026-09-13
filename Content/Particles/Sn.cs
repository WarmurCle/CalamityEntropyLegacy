using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Particles
{
    public class Sn : EParticle
    {
        public override Texture2D Texture => ModContent.Request<Texture2D>("CalamityEntropyLegacy/Content/Particles/Sn").Value;
        public override void OnSpawn()
        {
            this.Lifetime = 16;
        }
        public override void AI()
        {
            base.AI();
            this.Opacity = this.Lifetime / 16f;
        }
    }
}
