using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Books
{
    public class InfiniteBook : EntropyBook
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.useTime = Item.useAnimation = 6;
            Item.damage = 80;
            Item.mana = 20;
        }
        public override int HeldProjectileType => ModContent.ProjectileType<InfiniteBookHeld>();
        public override int SlotCount => 24;
    }

    public class InfiniteBookHeld : EntropyBookHeldProjectile
    {
        public override string OpenAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesOpen";
        public override string PageAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesPage";
        public override string UIOpenAnimationPath => "CalamityEntropyLegacy/Content/Items/Books/Textures/AncientScriptures/AncientScripturesUI";
        public override int frameChange => UIOpen ? 4 : 2;
    }
}