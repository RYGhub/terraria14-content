using Terraria;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Prefixes
{
    public class SenseiPrefix : ModPrefix
    {
        public override void SetDefaults() => DisplayName.SetDefault("Sensei's");

        public override bool CanRoll(Item item) => true;

        public override float RollChance(Item item) => 0.1f;

        public override PrefixCategory Category => PrefixCategory.Melee;

        public SenseiPrefix() { }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.17f;
            knockbackMult += 0.17f;
            scaleMult += 1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult += 2f;
        }
    }
}