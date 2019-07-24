using Terraria;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Prefixes
{
    public class PaltriPrefix : ModPrefix
    {
        public override void SetDefaults() => DisplayName.SetDefault("Paltri's");

        public override bool CanRoll(Item item) => true;

        public override float RollChance(Item item) => 0.1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.08f;
            knockbackMult += 0.08f;
            useTimeMult -= 0.08f;
            scaleMult += 0.08f;
            shootSpeedMult += 0.08f;
            manaMult -= 0.08f;
            critBonus += 8;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult += 2f;
        }
    }
}