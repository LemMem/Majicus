using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Majicus.Items.Weapons
{
    class EmblumSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emblem Sword");
            Tooltip.SetDefault("A Sword that does a good.");
        }
        public override void SetDefaults()
        {
            item.damage = 23;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "magic_core", 4);
            recipe.AddIngredient(mod, "Ultimate_Embulum");
            recipe.AddTile(mod, "MagicTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
