using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Majicus.Items.Tiles
{
    public class MagicTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A table which makes magic.");
            DisplayName.SetDefault("Magic Table");
        }
        public override void SetDefaults()
        {
            
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MagicTableBlock");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "magic_core", 10);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

