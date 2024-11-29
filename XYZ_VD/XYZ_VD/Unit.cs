using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XYZ_VD
{
    internal class Unit
    {
        public int Damage;
        public int MaxHealth;
        public int CurrentHealth;
        public bool isAlive = true;
        public int ShieldCount = 0;
        public bool LastDamageFromWeapon = false;
        public List<string> AbilityDescriptions = new();
        public Dictionary<AttackType, List<float>> DamageHistory = new();

        public Unit(int damage, int maxHealth)
        {
            Damage = damage;
            MaxHealth = maxHealth;

            CurrentHealth = maxHealth;

            DamageHistory.Add(AttackType.Damage, new List<float>());
            DamageHistory.Add(AttackType.Self, new List<float>());
            DamageHistory.Add(AttackType.Heal, new List<float>());
        }

        public void TakeDamage(int damage, Unit origin, bool isWeaponDamage = false)
        {
            bool isHeal = damage < 0;
            AttackType attackType = AttackType.Damage;
            if (isHeal)
                attackType = AttackType.Heal;
            else if (origin == this)
                attackType = AttackType.Self;

            if (InShield() && !isHeal)
            {
                ShieldCount--;
                DamageHistory[attackType].Add(0);
                return;
            }

            CurrentHealth -= damage;

            DamageHistory[attackType].Add(damage);
            //DamageHistory = new Dictionary<AttackType, List<float>>();

            if (CurrentHealth <= 0)
            {
                isAlive = false;
                return;
            }

            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
        }


        public string GetAbilityDescription(int AbilityNumber)
        {
            return AbilityDescriptions[AbilityNumber];
        }


        public int GetAbilityCount()
        {
            return AbilityDescriptions.Count;
        }

        public bool InShield()
        {
            return ShieldCount > 0;
        }

    }
}
