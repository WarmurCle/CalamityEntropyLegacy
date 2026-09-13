using CalamityEntropyLegacy.Content.Items;
using CalamityMod.Tiles.BaseTiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Tiles
{
    public class CruiserRelicTile : BaseBossRelic
    {
        public override string RelicTextureName => "CalamityEntropyLegacy/Content/Tiles/CruiserRelicTile";

        public override int AssociatedItem => ModContent.ItemType<CruiserRelic>();
    }
}
