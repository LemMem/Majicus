using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Majicus.Items.Materials
{
	public class magic_core : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Core");
			Tooltip.SetDefault("The base of all magic.");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
            item.value = 100;
			item.rare = 2;
            item.maxStack = 999;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.GoldBar, 10);
            recipe1.AddIngredient(ItemID.Wood,10);
            recipe1.AddIngredient(ItemID.Gel,10);
            recipe1.AddIngredient(ItemID.DemoniteBar,10);
			recipe1.AddTile(TileID.Candles);
			recipe1.SetResult(this);
			recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.GoldBar, 10);
            recipe2.AddIngredient(ItemID.Wood, 10);
            recipe2.AddIngredient(ItemID.Gel, 10);
            recipe2.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe2.AddTile(TileID.Candles);
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.PlatinumBar, 10);
            recipe3.AddIngredient(ItemID.Wood, 10);
            recipe3.AddIngredient(ItemID.Gel, 10);
            recipe3.AddIngredient(ItemID.DemoniteBar, 10);
            recipe3.AddTile(TileID.Candles);
            recipe3.SetResult(this);
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(mod);
            recipe4.AddIngredient(ItemID.PlatinumBar, 10);
            recipe4.AddIngredient(ItemID.Wood, 10);
            recipe4.AddIngredient(ItemID.Gel, 10);
            recipe4.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe4.AddTile(TileID.Candles);
            recipe4.SetResult(this, 5);
            recipe4.AddRecipe();
        }
    }
}
