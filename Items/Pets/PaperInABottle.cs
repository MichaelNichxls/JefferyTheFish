using JefferyTheFish.Buffs.Pets;
using JefferyTheFish.Projectiles.Pets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JefferyTheFish.Items.Pets
{
    public class PaperInABottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper in a Bottle");
            Tooltip.SetDefault(
                "Summons Jeffery The Fish to follow you\n" +
                "'There's an aged drawing of what appears to be a happy fish inside'"
            );
        }
        
        public override void SetDefaults()
        {
            item.Size = new Vector2(/* Some number */);
            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(silver: 5);

            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item8; // Change

            item.noMelee = true;
            item.shoot = ModContent.ProjectileType<JefferyTheFishPet>();
            item.buffType = ModContent.BuffType<JefferyTheFishPetBuff>();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
                player.AddBuff(item.buffType, 3600, true);
        }

        public override bool CanUseItem(Player player) => player.miscEquips[0].IsAir; // ?
    }
}