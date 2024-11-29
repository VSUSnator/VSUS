using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_VD
{
    internal class Player
    {
        public string Name;
        public Unit PlayerUnit;
        public Unit EnemyUnit;
        public Input Input;
        public ConsoleWriter Writer;
        public int FireballDamage = 200;

        public Player(string name, Unit playerUnit, Unit enemyUnit, Input input, ConsoleWriter writer)
        {
            Name = name;
            PlayerUnit = playerUnit;
            EnemyUnit = enemyUnit;
            Input = input;
            Writer = writer;

            playerUnit.AbilityDescriptions.Add($"Ударить оружием (урон {playerUnit.Damage})");
            playerUnit.AbilityDescriptions.Add($"Щит: следующая атака противника не наносит урона ");
            playerUnit.AbilityDescriptions.Add($"Огненный шар: наносит урон в размере {FireballDamage}");
        }

        public void Turn()
        {
            Writer.WriteUnitHeatlh("Ваше здоровье: ", PlayerUnit);
            Writer.WriteUnitHeatlh("Здоровье противника: ", EnemyUnit);

            Writer.WriteAllAbilities($"{Name}! Выберите действие: ", PlayerUnit);

            switch (Input.GetPlayerCommandNumber())
            {
                case 1:
                    EnemyUnit.TakeDamage(PlayerUnit.Damage, PlayerUnit, true);
                    break;
                case 2:
                    PlayerUnit.ShieldCount = 1;
                    break;
                case 3:
                    EnemyUnit.TakeDamage(FireballDamage, PlayerUnit, true);
                    break;
            }
        }
    }
}
