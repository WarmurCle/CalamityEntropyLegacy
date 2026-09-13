using CalamityEntropyLegacy.Content.Items;
using CalamityMod.Tiles.BaseTiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Tiles
{
    public class ProphetRelicTile : BaseBossRelic
    {
        public override string RelicTextureName => "CalamityEntropyLegacy/Content/Tiles/ProphetRelicTile";

        public override int AssociatedItem => ModContent.ItemType<ProphetRelic>();
    }
}
