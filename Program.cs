// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Attack
{
    public string Name { get; }
    public int DamageAmount { get; }

    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
    }
}

public class Enemy
{
    public string Name { get; }
    public int Health { get; private set; }
    public List<Attack> AttackList { get; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public void RandomAttack()
    {
        if (AttackList.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(AttackList.Count);
            Attack randomAttack = AttackList[randomIndex];

            Console.WriteLine($"{Name} performs a {randomAttack.Name} attack, dealing {randomAttack.DamageAmount} damage!");
        }
        else
        {
            Console.WriteLine($"{Name} has no attacks in the AttackList!");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of an Enemy
        Enemy enemy1 = new Enemy("Bandit");

        // Create 3 instances of Attacks
        Attack fireballAttack = new Attack("Fireball", 20);
        Attack punchAttack = new Attack("Punch", 15);
        Attack throwAttack = new Attack("Throw", 25);

        // Add the three Attacks to the Enemy's AttackList
        enemy1.AddAttack(fireballAttack);
        enemy1.AddAttack(punchAttack);
        enemy1.AddAttack(throwAttack);

        // Call the Enemy's RandomAttack method to test
        enemy1.RandomAttack();
    }
}
