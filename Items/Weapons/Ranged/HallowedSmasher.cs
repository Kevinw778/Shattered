using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace Shattered.Items.Weapons.Ranged
{
    public class HallowedSmasher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Smasher");
            Tooltip.SetDefault("Shattered Gems Shotgun");            
        }

        public override void SetDefaults()
        {
            /**
             * item.width & .height correspond to its dimensions when dropped in the world.
             * Actual hitbox when item is used/swung is dependent on the texture and item.scale
             */
            item.damage = 33;
            item.useTime = 0;

            item.useAnimation = 35;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4f;
            item.value = Terraria.Item.sellPrice(0, 10, 0, 0); // 10 gold
            item.rare = 8; // ItemRarityID can be used here
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Wooo");
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Wisp");
            item.shootSpeed = 6f;
            item.useAmmo = mod.ItemType("Wisp");

            item.width = 52;
            item.height = 18;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.DirtBlock); // for testing only

            //recipe.AddIngredient(HallowedBar, 10);
            //recipe.AddIngredient(SoulofMight, 10);

            // recipe.AddTile(TileID.AdamantiteForge); // leaving this out for testing

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void GetWeaponDamage(Player player, ref int damage)
        {
            damage = (int)(damage * player.bulletDamage + 5E-06);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("GemTileDust"));
        }

        public override bool UseItem(Player player)
        {
            if (Main.rand.Next(3) == 0)
                Dust.NewDust(new Vector2(player.position.X, player.position.Y), player.Hitbox.Width, player.Hitbox.Height, mod.DustType("GemTileDust"));
            return base.UseItem(player);
        }

        /**
         * Determines the offest of this item's sprite when used by the player.
         * Only works for items with useStyle of 5 that aren't staves.
         */
        public override Vector2? HoldoutOffset()
        {
            // by default returns null which uses the vanilla offset
            return null;
        }
    }
}
