using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_VD
{
    internal class Enemy
    {
        public Unit PlayerUnit;
        public Unit EnemyUnit;
        public Input Input;
        public int AbilitiesCount;
        public int SecondAbilityModifier;
        public int ThierdAbilityValue;

        public Enemy(Unit playerUnit, Unit enemyUnit, Input input)
        {
            PlayerUnit = playerUnit;
            EnemyUnit = enemyUnit;
            Input = input;
            AbilitiesCount = 3;
            SecondAbilityModifier = 3;
            ThierdAbilityValue = 100;
        }

        public void Turn()
        {
            switch (Input.GetAICommandNumber(AbilitiesCount))
            {
                case 1:
                    PlayerUnit.TakeDamage(EnemyUnit.Damage, EnemyUnit, true);
                    break;
                case 2:
                    int modififedDamage = EnemyUnit.Damage * SecondAbilityModifier;
                    EnemyUnit.TakeDamage(EnemyUnit.Damage, EnemyUnit);
                    PlayerUnit.TakeDamage(modififedDamage, EnemyUnit);
                    break;
                case 3:
                    if (EnemyUnit.LastDamageFromWeapon)
                    {
                        EnemyUnit.TakeDamage(ThierdAbilityValue, EnemyUnit);
                    }
                    else
                    {
                        EnemyUnit.TakeDamage(-ThierdAbilityValue, EnemyUnit);
                    }
                    break;
            }
        }
    }
}
