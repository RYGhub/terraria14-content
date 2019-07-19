using Terraria;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Prefixes
{
    public class NemesisPrefix : ModPrefix
    {
        public override void SetDefaults() => DisplayName.SetDefault("Nemesis'");

        public override bool CanRoll(Item item) => true;

        public override float RollChance(Item item) => 0.1f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public NemesisPrefix() { }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            critBonus += 39;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult += 2f;
        }
    }
}