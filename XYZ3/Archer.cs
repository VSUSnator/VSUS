namespace XYZ3
{
    public class Archer : Unit
    {
        public Archer(int health, IWeapon weapon) : base(health, weapon)
        {
        }

        public override string GetTypeName()
        {
            return "Archer";
        }
   
    }
}