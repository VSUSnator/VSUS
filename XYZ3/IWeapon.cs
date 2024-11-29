namespace XYZ3
{ 
    public interface IWeapon
    {
        public void MakeDamage(Unit defender);
        public Unit Owner { get; set; }
        public UnitType BaseOwnerType { get; protected set; }
    }
}