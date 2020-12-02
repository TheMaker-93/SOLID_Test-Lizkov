namespace Combat
{
    public abstract class Hero : IDoDamage
    {
        // Take damage == DoDamage
        public abstract void TakeDamage(int           damage);

        //public abstract void DoMeleeAttack(IDoDamage opponent);
        //public abstract void DoRangeAttack(IDoDamage opponent);
        public abstract void DoDamageToTarget(IDoDamage _target);
    }
}
