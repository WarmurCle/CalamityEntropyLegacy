using CalamityEntropyLegacy.Content.Items;
using CalamityMod.Tiles.BaseTiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Tiles
{
    public class LuminarisRelicTile : BaseBossRelic
    {
        public override string RelicTextureName => "CalamityEntropyLegacy/Content/Tiles/LuminarisRelicTile";

        public override int AssociatedItem => ModContent.ItemType<LuminarisRelic>();
    }
}
