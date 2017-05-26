using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace towertop.Items
{
    public class Strange_Brick : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CompanionCube);
            item.name = "Strange Brick";
            item.toolTip = "Summons the Robic Companon.";
            item.shoot = mod.ProjectileType("Robic_Companon");
            item.buffType = mod.BuffType("Robic_Companon_Buff");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}