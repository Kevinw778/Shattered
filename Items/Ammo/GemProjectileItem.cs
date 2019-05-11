using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Shattered.Items.Ammo
{
    public class GemProjectileItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gem Projectile Item (Ammo)");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 10;
            item.height = 10;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.2f;
            item.value = Item.sellPrice(0, 0, 0, 5);
            item.rare = 3;

            // Creates the Projectile
            item.shoot = mod.ProjectileType("GemProjectile");

            // Speed of projectile
            item.shootSpeed = 8.5f;

            // Makes the item act as ammo
            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.DirtBlock);

            recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this);

            recipe.AddRecipe();
        }
    }
}
