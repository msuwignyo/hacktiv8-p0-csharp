// Week 05 - Exercise 06
// Damage Calculation
// https://github.com/hacktiv8/phase-0-activities/blob/master/modules/challenge-damage-calculation.md

using System;
using System.Collections.Generic;
using System.Text;

namespace hacktiv8_p0_csharp.Week05
{
    public class Exercise06
    {
        private static int Attack(int damage)
        {
            return damage - 2;
        }

        public static int DamageCalculation(int numberOfAttacks, int damagePerAttack)
        {
            return numberOfAttacks * Attack(damagePerAttack);
        }
    }
}
