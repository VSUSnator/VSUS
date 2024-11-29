using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XYZ_VD
{
    internal class ConsoleWriter
    {
        void DamageMessage(string damager, string defender, float damage)
        {
            Console.WriteLine($"Игрок {damager} наносит игроку {defender} урон в размере {damage} единиц");
        }

        void HealMessage(string healer, float value)
        {
            Console.WriteLine($"Игрок {healer} восстановил себе здоровье в размере {value} единиц.");
        }

        void WriteDamageWithType(AttackType attackType, string damagerName, string defenderName, List<float> damages)
        {
            foreach (var damage in damages)
            {
                switch (attackType)
                {
                    case AttackType.Damage:
                        Console.ForegroundColor = ConsoleColor.Red;
                        DamageMessage(damagerName, defenderName, damage);
                        Console.ResetColor();
                        break;
                    case AttackType.Self:
                        Console.ForegroundColor = ConsoleColor.Red;
                        DamageMessage(defenderName, defenderName, damage);
                        Console.ResetColor();
                        break;
                    case AttackType.Heal:
                        Console.ForegroundColor = ConsoleColor.Green;
                        HealMessage(damagerName, damage);
                        Console.ResetColor();
                        break;
                    default:
                        break;
                }
            }
            damages.Clear();
        }

        public void WriteDamagesFromTo(Dictionary<AttackType, List<float>> damages, string damagerName, string defenderName)
        {
            foreach (var damage in damages)
            {
                WriteDamageWithType(damage.Key, damagerName, defenderName, damage.Value);
            }
        }

        public void WriteUnitHeatlh(string owner, Unit unit)
        {
            Console.WriteLine($"{owner} {unit.CurrentHealth}");
        }

        public void WriteAllAbilities(string message, Unit unit)
        {
            Console.WriteLine($"{message}");
            for (int i = 0; i < unit.GetAbilityCount(); i++)
            {
                Console.WriteLine($"{i + 1}. {unit.GetAbilityDescription(i)}");
            }
            Console.WriteLine();
        }


    }
}