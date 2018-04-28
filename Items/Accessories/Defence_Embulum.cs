using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Majicus.Items.Accessories
{
	public class Defence_Embulum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Defence Embulum");
			Tooltip.SetDefault(" 2 more Defence");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
            item.value = 400;
			item.rare = 4;
            item.accessory = true;

        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "magic_core", 4);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(mod, "MagicTable");
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 2;
        }
    }
}
