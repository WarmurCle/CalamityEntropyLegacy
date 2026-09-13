using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Particles
{
    public class DarkBladeParticle : EParticle
    {
        public override Texture2D Texture => ModContent.Request<Texture2D>("CalamityEntropyLegacy/Content/Particles/DarkBladeParticle").Value;
        public override void OnSpawn()
        {
            this.Lifetime = 24;
        }
        public override void AI()
        {
            base.AI();
            this.Opacity = this.Lifetime / 30f * 0.8f;
        }
    }
}
