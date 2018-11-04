using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Majicus.Items.Accessories
{
	public class Ultimate_Embulum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultimate Emblem");
			Tooltip.SetDefault("Lots of power! 2 more defence, 2% more Healing, 0.2% more Damage");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
            item.value = 400;
			item.rare = 6;
            item.accessory = true;

        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Damage_Embulum");
            recipe.AddIngredient(mod, "Defence_Embulum");
            recipe.AddIngredient(mod, "Healing_Emculum");
            recipe.AddTile(mod, "MagicTable");
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 2;
            player.lifeRegen += 2;
            player.meleeDamage += 0.2f;
            player.magicDamage += 0.2f;
            player.minionDamage += 0.2f;
        }
    }
}
