using System.Collections.Generic;
using UnityEngine;

namespace Combat
{
    public class CombatManager
    {
        public void Simulate (List<Hero> _team1, List<Hero> _team2)
        { 
            foreach (var hero in _team1)
            {
                var opponent = _team2[Random.Range(0, _team2.Count - 1)];

                Debug.Log(opponent.GetType() + " is being atacked by " + hero.GetType());

                hero.DoDamageToTarget(opponent);
            }
        }

    }
}
