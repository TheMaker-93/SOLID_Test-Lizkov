namespace Combat
{
    public class Warrior : Hero, IMeleeCombatCapable
    {
        public override void DoDamageToTarget(IDoDamage _target)
        {
            this.DoMeleeAttack(_target);
        }

        public void DoMeleeAttack(IDoDamage _target)
        {
            _target.TakeDamage(10);
        }

        public override void TakeDamage(int damage)
        {
            // Leave empty
        }

    }
}
