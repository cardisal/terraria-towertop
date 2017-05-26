using towertop.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace towertop.Items.Weapons
{
    public class The_Staff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "The Staff";
            item.damage = 300;
            item.magic = true;
            item.mana = 0;
            item.width = 40;
            item.height = 40;
            item.toolTip = "Don't use this.";
            item.useTime = 14;
            item.useAnimation = 25;
            item.useStyle = 5;
            Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Staff_Bullet");
            item.shootSpeed = 13;
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numProjectiles2 = 8;
            float spread = MathHelper.ToRadians(10);
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
            double deltaAngle = spread / (float)numProjectiles2;
            double offsetAngle;

            for (int j = 0; j < numProjectiles2; j++)
            {
                offsetAngle = startAngle + deltaAngle * j;
                Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), type, damage, knockBack, player.whoAmI);
            }

            return false;
        }
    }
}