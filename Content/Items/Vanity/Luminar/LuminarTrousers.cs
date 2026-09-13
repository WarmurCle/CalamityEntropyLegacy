using CalamityEntropyLegacy.Content.Items.Donator;
using CalamityEntropyLegacy.Content.Rarities;
using CalamityMod.Items;
using Terraria;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items.Vanity.Luminar
{
    [AutoloadEquip(EquipType.Legs)]
    public class LuminarTrousers : ModItem, IDonatorItem
    {
        public string DonatorName => "玲瓏";
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.value = CalamityGlobalItem.RarityPinkBuyPrice;
            Item.rare = ModContent.RarityType<Lunarblight>();
            Item.vanity = true;
        }
    }
}
