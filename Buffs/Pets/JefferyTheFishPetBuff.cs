using JefferyTheFish.Projectiles.Pets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JefferyTheFish.Buffs.Pets
{
    public class JefferyTheFishPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Jeffery The Fish");
            Description.SetDefault("He seems to stare into the soul");

            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<JefferyTheFishPlayer>().JefferyTheFishPet = true;

            if (player.ownedProjectileCounts[ModContent.ProjectileType<JefferyTheFishPet>()] <= 0 && player.whoAmI == Main.myPlayer)
                Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<JefferyTheFishPet>(), 0, 0f, player.whoAmI);
        }
    }
}