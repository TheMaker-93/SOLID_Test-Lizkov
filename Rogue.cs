using UnityEngine;

namespace Combat
{
    public class Rogue : Hero , IMeleeCombatCapable, IRangedCombatCapable
    {
        public override void DoDamageToTarget(IDoDamage _target)
        {
            if (Random.Range(0, 100) > 50)
            {
                this.DoMeleeAttack(_target);
            }
            else
            {
                this.DoRangedAttack(_target);
            }
        }

        public void DoMeleeAttack(IDoDamage _target)
        {
            _target.TakeDamage(20);
        }
        public void DoRangedAttack(IDoDamage _target)
        {
            _target.TakeDamage(10);
        }

        public override void TakeDamage(int damage)
        {
            // Leave empty
        }


    }


}
