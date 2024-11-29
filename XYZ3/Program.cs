//using System.Diagnostics;
//class Program
//{
//    private static void Main(string[] args)
//    {
//        Stopwatch watch = new Stopwatch();

//        watch.Start();

//        //....

//        watch.Stop();

//        Console.WriteLine(watch.Elapsed.ToString());
//    }
//}

using System.Security.Cryptography.X509Certificates;

namespace XYZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarriorWeapon warriorWeaponW = new WarriorWeapon(10);
            MageWeapon mageWeaponW = new MageWeapon(10);
            Warrior warrior1 = new Warrior(100, warriorWeaponW);
            Warrior warrior2 = new Warrior(100, mageWeaponW);

            warrior1.Attack(warrior2);
            warrior2.Attack(warrior1);

            MageWeapon mageWeaponM = new MageWeapon(10);
            WarriorWeapon warriorWeaponM = new WarriorWeapon(10);
            Mage mage1 = new Mage(100, mageWeaponM);
            Mage mage2 = new Mage(100, warriorWeaponM);

            mage1.Attack(mage2);
            mage2.Attack(mage1);

            ArcherWeapon archerWeaponA = new ArcherWeapon(10);
            WarriorWeapon warriorWeaponA = new WarriorWeapon(10);
            Archer archer1 = new Archer(100, archerWeaponA);
            Archer archer2 = new Archer(100, warriorWeaponA);

            archer1.Attack(archer2);
            archer2.Attack(archer1);

        }
    }
}
