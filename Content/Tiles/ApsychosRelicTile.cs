using CalamityEntropyLegacy.Content.Items;
using CalamityMod.Tiles.BaseTiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Tiles
{
    public class ApsychosRelicTile : BaseBossRelic
    {
        public override string RelicTextureName => "CalamityEntropyLegacy/Content/Tiles/ApsychosRelicTile";

        public override int AssociatedItem => ModContent.ItemType<ApsychosRelic>();
    }
}
