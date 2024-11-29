namespace XYZ3
{
    public class MageWeapon : IWeapon
    {
        private int _damage;

        public Unit Owner { get; set; }
        public UnitType BaseOwnerType { get; set; } = UnitType.Mage;
        public MageWeapon(int damage)
        {
            _damage = damage;
        }

        public void MakeDamage(Unit defender)
        {
            int damage = UnitTypeDamageCalculator.CalcDamageByOwner(_damage, BaseOwnerType, Owner);
            defender.Health -= damage;
            Owner.Health += damage;
        }
    }
}
