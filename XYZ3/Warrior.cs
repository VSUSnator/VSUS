namespace XYZ3
{
    public class Warrior : Unit
    {
        public Warrior(int health, IWeapon weapon) : base(health, weapon)
        {
        }

        public override string GetTypeName()
        {
            return "Warrior";
        }

    }
}