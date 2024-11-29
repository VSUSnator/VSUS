namespace XYZ3
{
    public class Mage : Unit
    {
        public Mage(int health, IWeapon weapon) : base(health, weapon)
        {
        }

        public override string GetTypeName()
        {
            return "Mage";
        }
    }
}