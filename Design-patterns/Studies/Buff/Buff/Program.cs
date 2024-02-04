using System;
using System.Threading;
using BuffPattern.Attributeses;
using BuffPattern.Buffs;
using BuffPattern.Equipments;

namespace BuffPattern
{
    class Program
    {
        private static string _description;
        private static bool _shouldUpdate = true;
        private static readonly object Lock = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            Console.Clear();

            Character character = new Character(1, new BaseAttributes(100, 50, 10, 5, 1));
            _description = $"Level buff Lv{character.Level}";
            character.Buffs.Add(new LevelBuff(character));
            new Thread(UpdateCharacter) {IsBackground = true}.Start(character);

            Thread.Sleep(1000);

            lock (Lock)
            {
                character.Level += 1;
                _description = $"Level buff Lv{character.Level}";
            }
            Thread.Sleep(1000);

            lock (Lock)
            {
                character.Level += 1;
                _description = $"Level buff Lv{character.Level}";
            }            
            Thread.Sleep(1000);
            
            Weapon weapon = new FairyGunIWeapon("Fairy Gun I", 1, 5, 10);
            lock (Lock)
            {
                weapon.AttachTo(character);
                _description = $"Weapon {weapon.Name} level {weapon.Level} buff";
            }            
            Thread.Sleep(1000);

            lock (Lock)
            {
                weapon.Level += 1;
                _description = $"Weapon {weapon.Name} level {weapon.Level} buff";
            }            
            Thread.Sleep(1000);

            lock (Lock)
            {
                weapon.Level += 1;
                _description = $"Weapon {weapon.Name} level {weapon.Level} buff";
            }            
            Thread.Sleep(1000);

            Armor armor = new FlashArmor("Flash armor", 1, 10, 50);
            lock (Lock)
            {
                armor.AttachTo(character);
                _description = $"Armor {armor.Name} level {armor.Level} buff";
            }            
            Thread.Sleep(4000);

            lock (Lock)
            {
                armor.Detach();
                _description = $"Armor {armor.Name} detached";
            }            
            Thread.Sleep(1000);

            lock (Lock)
            {
                weapon.Detach();
                _description = $"Weapon {weapon.Name} detached";
            }            
            Thread.Sleep(1000);

            lock (Lock)
            {
                new DirectPointBuff(new Attributes(-50, 0, -20, 0, 0), 2000).AttachTo(character);
                _description = "Curse buff applied for 2 seconds";
            }            
            Thread.Sleep(5000);

            _shouldUpdate = false;
        }

        private static void UpdateCharacter(object param)
        {
            Character character = (Character) param;

            while (_shouldUpdate)
            {
                lock (Lock)
                {
                    character.Update();

                    Console.Clear();
                    Console.WriteLine($@"Simulates: ""{_description}""
Max health: {character.MaxHealth}
Max mana: {character.MaxMana}
Attack: {character.Attack}
Defense: {character.Defense}
Critical: {character.Critical}");
                }

                Thread.Sleep(100);
            }
        }
    }
}
