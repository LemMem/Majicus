using Terraria.ID;
using Terraria.ModLoader;

namespace Majicus.Items.Tiles
{
    class MagicTableItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Table");
        }
        public override void SetDefaults()
        {
            item.width = 31;
            item.height = 31;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MagicTable");

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "magic_core", 15);
            recipe.AddIngredient(ItemID.WorkBench);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
