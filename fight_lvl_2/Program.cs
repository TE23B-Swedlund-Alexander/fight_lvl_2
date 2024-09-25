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
int childaction = 0;
Console.WriteLine("punch does normal damage   kick does dubble damage but you take dubble damage this turn and you have to wait one turn until you can kick again  block blocks all damage this turn and you have to wait one turn until you can block again");
Console.WriteLine("start fight");
Console.ReadLine();
while (childhp > 0 && hp > 0)
{
    round++;
    Console.WriteLine($"round{round}");
    Console.WriteLine();
    dmg = rnd.Next(1, 10);
    dmg2 = rnd.Next(1, 10);
    childaction = rnd.Next(1, 3);



    Console.WriteLine("choose attack");
    Console.WriteLine("type 1 for punch. 2 for kick. 3 for block ");
    string action = Console.ReadLine();
    if (block2cooldown > 0)
    {
        block2cooldown--;
    }
    if (kick2cooldown > 0)
    {
        kick2cooldown--;
    }
    if (childaction == 2)
    {
        if (kick2cooldown > 0)
        {
            childaction = 1;
        }
        else
        {
            if (blockcooldown == 2)
            {
                Console.WriteLine("you block the childs kick");
            }
            if (kickcooldown == 2 && blockcooldown < 2)
            {
                Console.WriteLine("the child kicks you");
                hp -= dmg2 * 4;
            }
            if (blockcooldown < 2 && kickcooldown < 2)
            {
                Console.WriteLine("the child kicks you");
                hp -= dmg2 * 2;
            }
            kick2cooldown = 2;
        }

    }

    if (childaction == 3)
    {
        if (block2cooldown > 0)
        {
            childaction = 1;
        }
        else
        {
            Console.WriteLine("the child blocks you");
            block2cooldown = 2;
        }

    }



    if (childaction == 1)
    {
        if (blockcooldown < 2 && kickcooldown < 2)
        {
            Console.WriteLine("the child punches you");
            hp -= dmg;
        }
        if (blockcooldown == 2)
        {
            Console.WriteLine("the child punches you and you block");
        }
        if (blockcooldown < 2 && kickcooldown == 2)
        {
            Console.WriteLine("the child punches you ");
            hp -= dmg * 2;
        }
    }
     if (kickcooldown > 0)
    {
        kickcooldown--;
    }

    if (blockcooldown > 0)
    {
        blockcooldown--;
    }
    if (block2cooldown < 2 && kick2cooldown < 2)
    {
        if (action == "1")
        {
            childhp -= dmg;
            Console.WriteLine("you punch the child");
        }
        if (action == "2" && kickcooldown == 0)
        {
            childhp -= dmg * 2;
            kickcooldown = 2;
            Console.WriteLine("you kick the child");
        }
        if (action == "3" && blockcooldown == 0)
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child");
        }
    }
   
    if (block2cooldown < 2 && kick2cooldown == 2)
    {
        if (action == "1")
        {
            childhp -= dmg * 2;
            Console.WriteLine("you punch the child");
        }
        if (action == "2" && kickcooldown == 0)
        {
            childhp -= dmg * 4;
            kickcooldown = 2;
            Console.WriteLine("you kick the child");
        }
        if (action == "3" && blockcooldown == 0)
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child");
        }


    }
    if (block2cooldown == 2 && kick2cooldown < 2)
    {
        if (action == "1")
        {

            Console.WriteLine("you punch the child and the child blocks");
        }
        if (action == "2" && kickcooldown == 0)
        {

            kickcooldown = 2;
            Console.WriteLine("you kick the child and the child blocks");
        }
        if (action == "3" && blockcooldown == 0)
        {
            blockcooldown = 2;
            Console.WriteLine("you block the child and the child blocks");
        }

    }

    Console.WriteLine($"your hp {hp}. childs hp {childhp}");

}
if (childhp > 0)
{
    Console.WriteLine("you lose");
}
if (childhp < 0 && hp < 0)
{
    Console.WriteLine("tie");
}
if (hp > 0)
{
    Console.WriteLine("you win");
}
Console.ReadLine();