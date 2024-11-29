namespace XYZ3
{
    public static class UnitTypeDamageCalculator
    {
        public static float OwnerDecreasePercent = 35f;

        private static Dictionary<Type, UnitType> _types = new Dictionary<Type, UnitType>
        {
            {typeof(Mage), UnitType.Mage },
            {typeof(Warrior), UnitType.Warrior },
            {typeof(Archer), UnitType.Archer }
        };
           
        public static int CalcDamageByOwner(int damage, UnitType unitType, Unit unit)
        {
            if (unitType == ConvertUnitToType(unit))
                return damage;

            return (int)((OwnerDecreasePercent / 100) * damage);
        }

        public static UnitType ConvertUnitToType(Unit unit)
        {
            return _types[unit.GetType()];
        }
    }
}
