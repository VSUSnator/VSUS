namespace XYZ3
{
    public class WarriorWeapon : IWeapon
    {
        private int _damage;

        public Unit Owner { get; set; }
        public UnitType BaseOwnerType { get; set; } = UnitType.Warrior;
        public WarriorWeapon(int damage)
        {
            _damage = damage;
        }

        public void MakeDamage(Unit defender)
        {
            int damage = UnitTypeDamageCalculator.CalcDamageByOwner(_damage, BaseOwnerType, Owner);
            defender.Health -= damage;
        }
    }
}
