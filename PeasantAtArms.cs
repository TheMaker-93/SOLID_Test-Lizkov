using UnityEngine;

namespace Combat
{
    public class PeasantAtArms : Hero, IRangedCombatCapable
    {
        public override void DoDamageToTarget(IDoDamage _target)
        {
            if (Random.Range(0,100) > 80)
            {
                DoRangedAttack(_target);
            }
        }

        public void DoRangedAttack(IDoDamage _target)
        {
            _target.TakeDamage(4);
        }

        public override void TakeDamage(int damage)
        {
            // Leave empty
        }
    }


}
