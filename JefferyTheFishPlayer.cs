using JefferyTheFish.Items.Pets;
using Terraria;
using Terraria.ModLoader;

namespace JefferyTheFish
{
    public class JefferyTheFishPlayer : ModPlayer
    {
        public bool JefferyTheFishPet = false;

        public override void ResetEffects() => JefferyTheFishPet = false;

        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if (junk)
                return;

            if (player.ZoneBeach && Main.hardMode && Main.rand.NextBool(player.fishingSkill >= 100 ? 200 : player.fishingSkill >= 50 ? 300 : 400))
                caughtType = ModContent.ItemType<PaperInABottle>();
        }
    }
}