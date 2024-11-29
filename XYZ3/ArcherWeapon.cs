namespace XYZ3
{
    public class ArcherWeapon : IWeapon
    {
        private int _damage;
        private float _firstModifier = 1.5f;
        private float _secondModifier = 2f;
        private float _thirdModifier = 3f;
        private float _firstChancePercent = 60f;
        private float _secondChancePercent = 30f;
        private float _thirdChancePercent = 15f;
        private Random _random;

        public Unit Owner { get; set; }
        public UnitType BaseOwnerType { get; set; } = UnitType.Archer;

        public ArcherWeapon(int damage)
        {
            _damage = damage;
            _random = new Random();
        }

        public void MakeDamage(Unit defender)
        {
            int damage = UnitTypeDamageCalculator.CalcDamageByOwner(_damage, BaseOwnerType, Owner); ;
            int randomNumber = _random.Next(1, 101);
            if (randomNumber < _thirdChancePercent)
                damage = (int)(damage * _thirdModifier);
            else if (randomNumber < _secondChancePercent)
                damage = (int)(damage * _secondModifier);
            else if (randomNumber < _firstChancePercent)
                damage = (int)(_firstModifier * damage);

            defender.Health -= damage;
        }
    }
}
