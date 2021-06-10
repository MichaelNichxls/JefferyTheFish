using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JefferyTheFish.Projectiles.Pets
{
    public class JefferyTheFishPet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jeffery The Fish");

            Main.projFrames[projectile.type] = 1; // Update number of frames
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Main.player[projectile.owner].zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            // Simplify
            Player player = Main.player[projectile.owner];
            JefferyTheFishPlayer modPlayer = player.GetModPlayer<JefferyTheFishPlayer>();

            if (player.dead)
                modPlayer.JefferyTheFishPet = false;
            
            if (modPlayer.JefferyTheFishPet)
                projectile.timeLeft = 2;
        }
    }
}