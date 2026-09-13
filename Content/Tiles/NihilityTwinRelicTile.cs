using CalamityEntropyLegacy.Content.Items;
using CalamityMod.Tiles.BaseTiles;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Tiles
{
    public class NihilityTwinRelicTile : BaseBossRelic
    {
        public override string RelicTextureName => "CalamityEntropyLegacy/Content/Tiles/NihilityTwinRelicTile";

        public override int AssociatedItem => ModContent.ItemType<NihilityTwinRelic>();
    }
}
