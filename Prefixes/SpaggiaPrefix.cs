using Terraria;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Prefixes
{
    public class SpaggiaPrefix : ModPrefix
    {
        public override void SetDefaults() => DisplayName.SetDefault("Spaggia's");

        public override bool CanRoll(Item item) => true;

        public override float RollChance(Item item) => 0.1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public SpaggiaPrefix() { }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            useTimeMult /= 1.5f;
            shootSpeedMult *= 1.5f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult += 2f;
        }
    }
}