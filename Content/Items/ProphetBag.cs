using CalamityEntropyLegacy.Content.Items.Accessories;
using CalamityEntropyLegacy.Content.Items.Accessories.SoulCards;
using CalamityEntropyLegacy.Content.Items.Books;
using CalamityEntropyLegacy.Content.Items.Books.BookMarks;
using CalamityEntropyLegacy.Content.Items.Weapons;
using CalamityEntropyLegacy.Content.Items.Weapons.Whips;
using CalamityEntropyLegacy.Content.NPCs.Prophet;
using CalamityMod;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Content.Items
{
    public class ProphetBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 3;
            ItemID.Sets.BossBag[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.expert = true;
            Item.rare = ItemRarityID.Yellow;
        }

        public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
        {
            itemGroup = ContentSamples.CreativeHelper.ItemGroup.BossBags;
        }

        public override bool CanRightClick() => true;

        public override Color? GetAlpha(Color lightColor) => Color.Lerp(lightColor, Color.White, 0.4f);

        public override void PostUpdate()
        {
            CalamityMod.CalamityUtils.ForceItemIntoWorld(Item);
            Item.TreasureBagLightAndDust();
        }

        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            return CalamityUtils.DrawTreasureBagInWorld(Item, spriteBatch, ref rotation, ref scale, whoAmI);
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.CoinsBasedOnNPCValue(ModContent.NPCType<TheProphet>()));

            itemLoot.Add(ModContent.ItemType<RuneSong>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<UrnOfSouls>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<SpiritBanner>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<RuneMachineGun>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<ProphecyFlyingKnife>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<ForeseeOrb>(), new Fraction(4, 5));
            itemLoot.Add(ModContent.ItemType<RuneWing>(), new Fraction(4, 5));
            itemLoot.Add(ModContent.ItemType<ForeseeWhip>(), new Fraction(2, 5));
            itemLoot.Add(ModContent.ItemType<ProphecyMasterpiece>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<BookMarkForesee>(), new Fraction(3, 5));
            itemLoot.Add(ModContent.ItemType<CursedThread>(), 1);
        }
    }
}
