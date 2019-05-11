using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Shattered.Projectiles
{
    public class GemProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gem Projectile");
        }

        public override void SetDefaults()
        {
            // Height & Width of Projectile Hitbox - try to keep max 7 x 16
            projectile.width = 8;
            projectile.height = 12;

            /**
             * AI Style of the projectile (0 or -1 for custom AI)
             * 1 = Arrow
             * 2 = Shuriken
             * 3 = Boomerang
             * Many more - check dl'd spreadsheet
             */
            projectile.aiStyle = -1;

            // If friendly, the player and NPCs are not harmed
            projectile.friendly = true;

            // How many enemies can be hit
            projectile.penetrate = 3;

            // Projectile damage type
            projectile.ranged = true;

            /**
             * Other damage types
             * melee
             * thrown
             * magic
             * minion
             */

            /**
             * Passed in when the Projectile is created:
             * damage - int
             * knockback - float
             */

            // How long projectile is on screen for
            // projectile.timeLeft = 100;

            // Is this projectile an arrow? - not really sure why this is needed
            // projectile.arrow = true;
        }

        public override void Kill(int timeLeft)
        {
            // When the arrow dies, if a player shot the arrow
            // "allow the proj. to not be consumed w/ a certain % chance"
            if (projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem(projectile.getRect(), mod.ItemType("GemProjectile")) : 0; // item is the item ID which can be used later if necessary
            }
        }

        public override void AI()
        {
            // Velocity multiplied by value < 1 to decrease horizontal travel
            float velXChange = 0.85f;

            projectile.velocity.X *= velXChange;

            float velYChange = 0.35f;

            // Instead of multiplying, we add - this gives a gradual increase over time
            projectile.velocity.Y += velYChange;

            // Rotation is obtained from the velocity
            // (float)Math.tan2(x, y);
            float velRotation = projectile.velocity.ToRotation();

            // Rotation uses Radians instead of degrees
            projectile.rotation = velRotation + MathHelper.ToRadians(90f);

            /**
             * Degrees to Radians is:
             * Rad = Deg * Pi / 180
             * 
             * Degree   | Radian
             * 0        | 0
             * 45       | 0.785
             * 90       | 1.570
             * 180      | 3.14 (Pi)
             * 360      | 6.28 (Pi * 2)
             */
        }
    }
}
