
using RPG.Entities.Heroes;
using RPG.Entities.Monsters;

Human Dante = new Human("Dante");
List <Monster> monsters = new List<Monster>();

for (int i = 0; i < 1000; i++)
{
    Random r = new Random();
    int rng = r.Next(6);
    switch (rng)
    {
        case 0:
            break;
        case 1:
        case 2:
            Wolf wolf = new Wolf();
            wolf.DieEvent += Dante.Loot;
            monsters.Add(wolf);
            break;
        case 3:
        case 4:
            Troll troll = new Troll();
            troll.DieEvent += Dante.Loot;
            monsters.Add(troll);
            break;
        case 5:
            Dragon dragon = new Dragon();
            dragon.DieEvent += Dante.Loot;
            monsters.Add(dragon);
            break;
    }
}

while (Dante.isAlive && monsters.Count > 1)
{
    for (int i = 0; i < monsters.Count && Dante.isAlive;i++)
    {
        while(Dante.isAlive && monsters[i].isAlive)
        {
            Dante.Attack(monsters[i]);
            if (monsters[i].isAlive)
            {
                monsters[i].Attack(Dante);
            }
        }
        if (!monsters[i].isAlive)
        {
            monsters.RemoveAt(i);
        }
    }
}

if(Dante.isAlive)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You loose");
}
