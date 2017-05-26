using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace towertop.Items
{
	public class Super_Slap_Hand : ModItem 
    {
		public override void SetDefaults()
		{
			item.name = "Super Slap Hand";
			item.damage = 42;
			item.melee = true;
			item.width = 36;
			item.height = 38;
			item.toolTip = "Why would you ever want this?";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 24;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
