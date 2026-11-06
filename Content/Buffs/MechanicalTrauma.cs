using CalamityEntropyLegacy.Core;

namespace CalamityEntropyLegacy.Content.Buffs
{
    public class MechanicalTrauma : DotBuff
    {
        public override int DamagePlayerPerSec => CrossModSystem.IEoRBalancing ? 4 : 4;
        public override int DamageEnemiesPerSec => CrossModSystem.IEoRBalancing ? 11 : 21;
    }
}