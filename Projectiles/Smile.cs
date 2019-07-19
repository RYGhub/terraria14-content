using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RoyalTerraria14Content.Projectiles
{
    public class Smile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smile Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.timeLeft = 120;
            projectile.hostile = true;
            projectile.ignoreWater = true;
            projectile.noDropItem = true;
            projectile.penetrate = -1;
        }

        public override bool CanHitPlayer(Player target)
        {
            return projectile.owner != Main.myPlayer;
        }

        public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit)
        {
            damage = 0;
            target.AddBuff(BuffID.Lovestruck, 60);
            target.AddBuff(mod.BuffType<Buffs.Smiling>(), 60);
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            damage = 0;
            knockback = 0;
            target.AddBuff(BuffID.Lovestruck, 60);
            target.AddBuff(mod.BuffType<Buffs.Smiling>(), 60);
        }
    }
}
