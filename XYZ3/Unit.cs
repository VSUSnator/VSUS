namespace XYZ3
{
    public abstract class Unit
    {
        protected int _health;
        protected IWeapon _weapon;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        protected Unit(int health, IWeapon weapon)
        {
            _health = health;
            _weapon = weapon;
            _weapon.Owner = this;
        }

        public virtual void Attack(Unit defender)
        {
            int health = defender.Health;

             _weapon.MakeDamage(defender);

            Console.WriteLine($"{GetTypeName()} нанес урон: {health - defender.Health}");
        }

        public abstract string GetTypeName();
    }
}