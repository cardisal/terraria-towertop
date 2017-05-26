using Terraria;
using Terraria.ModLoader;

namespace towertop.Buffs
{
    public class Robic_Companon_Buff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Robic Companon";
            Main.buffTip[Type] = "Helps you, ok?";
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>(mod).Pet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("PetName")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("PetName"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}