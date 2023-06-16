
using RPG.Entities.Heroes;
using RPG.Entities.Monsters;

Human Dante = new Human("Dante");
List <Monster> monsters = new List<Monster>();

for (int i = 0; i < 1000; i++)
{
    Random r = new Random();
    int rng = r.Next(3);
    switch (rng)
    {
        case 0:
            monsters.Add(new Wolf());
            break;
        case 1:
            monsters.Add(new Troll());
            break;
        case 2:
            monsters.Add(new Dragon());
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
