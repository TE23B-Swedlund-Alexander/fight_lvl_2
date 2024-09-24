Random rnd = new Random();
int childhp = 50;
int hp = 50;

int kickcooldown = 0;
int kick2cooldown = 0;
int blockcooldown = 0;
int block2cooldown = 0;
int dmg = 0;
int dmg2 = 0;
int round = 0;
Console.WriteLine("punch does normal damage   kick does dubble damage but you take dubble damage this turn cooldown 2 turns  block blocks all damage this turn cooldown 2 turns");
Console.WriteLine("start fight");
Console.ReadLine();
while (childhp > 0 && hp > 0)
{
    round++;
    Console.WriteLine($"round{round}");
    Console.WriteLine();
    dmg = rnd.Next(1, 10);
    dmg2 = rnd.Next(1, 10);
    if (kickcooldown > 0)
    {
        kickcooldown--;
    }

    if (blockcooldown > 0)
    {
        blockcooldown--;
    }


    Console.WriteLine("choose attack");
    Console.WriteLine("type 1 for punch. 2 for kick. 3 for block");
    string action = Console.ReadLine();
    if (block2cooldown < 2 && kick2cooldown < 2)
    {
        if (action == "1")
        {
            childhp -= dmg;
        }
        if (action == "2")
        {
            childhp -= dmg * 2;
            kickcooldown = 2;
            Console.WriteLine("you kick the child");
        }
        if (action == "3")
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child");
        }
        else
        {
            Console.WriteLine("you skip your turn");
        }
    }
    if (block2cooldown < 2 && kick2cooldown == 2)
    {
        if (action == "1")
        {
            childhp -= dmg * 2;
        }
        if (action == "2")
        {
            childhp -= dmg * 4;
            kickcooldown = 2;
            Console.WriteLine("you kick the child");
        }
        if (action == "3")
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child");
        }
        else
        {
            Console.WriteLine("you skip your turn");
        }
    }
    if (block2cooldown == 2 && kick2cooldown < 2)
    {
        if (action == "1")
        {
           
            Console.WriteLine("you punch the child and the child blocks");
        }
        if (action == "2")
        {
            childhp -= dmg * 4;
            kickcooldown = 2;
            Console.WriteLine("you kick the child and the child blocks");
        }
        if (action == "3")
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child and the child blocks");
        }
        else
        {
            Console.WriteLine("you skip your turn and the child blocks");
        }
    }
    if (block2cooldown > 0)
    {
        block2cooldown--;
    }
    if (kick2cooldown > 0)
    {
        kick2cooldown--;
    }

    Console.WriteLine();
    Console.WriteLine("child punch you");
    hp -= dmg2;
    Console.WriteLine($"child hp = {childhp}");
    Console.WriteLine($"your hp = {hp}");
    Console.ReadLine();
}
if (childhp > hp)
{
    Console.WriteLine("you lose");
}
if (childhp == hp)
{
    Console.WriteLine("tie");
}
if (childhp < hp)
{
    Console.WriteLine("you win");
}
Console.ReadLine();