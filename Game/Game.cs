using System;
using System.Threading;
using System.Threading.Tasks;

//CLONING POKEMON REQUIRED
public class Game
{
    public static void Main()
    {
        
        

                                        //Types Initialization
        type normal = new type(); 
        type fire = new type(); 
        type water = new type(); 
        type grass = new type(); 
        type electric = new type(); 
        type ice = new type(); 
        type fighting = new type(); 
        type poison = new type();
        type ground = new type();
        type flying = new type();
        type psychic = new type();
        type bug = new type();
        type rock = new type();
        type ghost = new type();
        type dark = new type();
        type dragon = new type();
        type steel = new type();
        type fairy = new type();

        

                                        //Type Advantages Initialization
        //Normal
        normal.addWeakAgainst(rock);
        normal.addWeakAgainst(steel);

        normal.addImmuneAgainst(ghost);

        //Fire
        fire.addStrongAgainst(grass);
        fire.addStrongAgainst(ice);
        fire.addStrongAgainst(bug);
        fire.addStrongAgainst(steel);

        fire.addWeakAgainst(fire);
        fire.addWeakAgainst(water);
        fire.addWeakAgainst(rock);
        fire.addWeakAgainst(dragon);

        fire.addWeakAgainst(water);

        //Water
        water.addStrongAgainst(fire);
        water.addStrongAgainst(ground);
        water.addStrongAgainst(rock);

        water.addWeakAgainst(water);
        water.addWeakAgainst(grass);
        water.addWeakAgainst(dragon);

        //Grass
        grass.addStrongAgainst(water);
        grass.addStrongAgainst(ground);
        grass.addStrongAgainst(rock);

        grass.addWeakAgainst(fire);
        grass.addWeakAgainst(grass);
        grass.addWeakAgainst(poison);
        grass.addWeakAgainst(flying);
        grass.addWeakAgainst(bug);
        grass.addWeakAgainst(dragon);
        grass.addWeakAgainst(steel);


        //Electric
        electric.addStrongAgainst(water);
        electric.addStrongAgainst(flying);

        electric.addWeakAgainst(electric);
        electric.addWeakAgainst(grass);
        electric.addWeakAgainst(dragon);

        electric.addImmuneAgainst(ground);

        //Ice
        ice.addStrongAgainst(grass);
        ice.addStrongAgainst(ground);
        ice.addStrongAgainst(flying);
        ice.addStrongAgainst(dragon);

        ice.addWeakAgainst(fire);
        ice.addWeakAgainst(water);
        ice.addWeakAgainst(ice);
        ice.addWeakAgainst(steel);


        //Fighting
        fighting.addStrongAgainst(normal);
        fighting.addStrongAgainst(ice);
        fighting.addStrongAgainst(rock);
        fighting.addStrongAgainst(dark);
        fighting.addStrongAgainst(steel);

        fighting.addWeakAgainst(poison);
        fighting.addWeakAgainst(flying);
        fighting.addWeakAgainst(psychic);
        fighting.addWeakAgainst(bug);
        fighting.addWeakAgainst(fairy);

        fighting.addImmuneAgainst(ghost);

        //Poison
        poison.addStrongAgainst(grass);
        poison.addStrongAgainst(fairy);

        poison.addWeakAgainst(poison);
        poison.addWeakAgainst(ground);
        poison.addWeakAgainst(rock);
        poison.addWeakAgainst(ghost);

        poison.addImmuneAgainst(steel);

        //Ground
        ground.addStrongAgainst(fire);
        ground.addStrongAgainst(electric);
        ground.addStrongAgainst(poison);
        ground.addStrongAgainst(rock);
        ground.addStrongAgainst(steel);

        ground.addWeakAgainst(grass);
        ground.addWeakAgainst(bug);

        ground.addImmuneAgainst(flying);

        //Flying
        flying.addStrongAgainst(grass);
        flying.addStrongAgainst(fighting);
        flying.addStrongAgainst(bug);

        flying.addWeakAgainst(electric);
        flying.addWeakAgainst(rock);
        flying.addWeakAgainst(steel);

        //Psychic
        psychic.addStrongAgainst(fighting);
        psychic.addStrongAgainst(poison);

        psychic.addWeakAgainst(psychic);
        psychic.addWeakAgainst(steel);

        psychic.addImmuneAgainst(dark);

        //Bug
        bug.addStrongAgainst(grass);
        bug.addStrongAgainst(psychic);
        bug.addStrongAgainst(dark);

        bug.addWeakAgainst(fire);
        bug.addWeakAgainst(fighting);
        bug.addWeakAgainst(poison);
        bug.addWeakAgainst(flying);
        bug.addWeakAgainst(ghost);
        bug.addWeakAgainst(steel);
        bug.addWeakAgainst(fairy);

        //Rock
        rock.addStrongAgainst(fire);
        rock.addStrongAgainst(ice);
        rock.addStrongAgainst(bug);
        rock.addStrongAgainst(flying);

        rock.addWeakAgainst(fighting);
        rock.addWeakAgainst(ground);
        rock.addWeakAgainst(steel);

        //Ghost
        ghost.addStrongAgainst(psychic);
        ghost.addStrongAgainst(ghost);

        ghost.addWeakAgainst(dark);

        ghost.addImmuneAgainst(normal);

        //Dark
        dark.addStrongAgainst(psychic);
        dark.addStrongAgainst(ghost);

        dark.addWeakAgainst(fighting);
        dark.addWeakAgainst(dark);
        dark.addWeakAgainst(fairy);

        //Dragon
        dragon.addStrongAgainst(dragon);

        dragon.addWeakAgainst(steel);

        dragon.addImmuneAgainst(fairy);

        //Steel
        steel.addStrongAgainst(ice);
        steel.addStrongAgainst(rock);
        steel.addStrongAgainst(fairy);

        steel.addWeakAgainst(fire);
        steel.addWeakAgainst(water);
        steel.addWeakAgainst(electric);
        steel.addWeakAgainst(steel);

        //Fairy
        fairy.addStrongAgainst(fighting);
        fairy.addStrongAgainst(dragon);
        fairy.addStrongAgainst(dark);

        fairy.addWeakAgainst(fire);
        fairy.addWeakAgainst(poison);
        fairy.addWeakAgainst(steel);

        //Move Initialization                                

        Move ember = new Move("ember", fire, 400, 100, "Physical", 30);
        Move thunderWave = new Move("Thunder Wave", electric, 90, "Status", 20, null, "Paralysis");

        //Pokemon Initialization

        List<Pokemon> pokemons = new List<Pokemon>();

        pokemons.Add(new Pokemon("charmander", "male", 50, fire, null, 100, 00, 100, 100, 100, 100, 100, thunderWave, ember, ember, ember));
        pokemons.Add(new Pokemon("charmeleon", "male", 50, fire, null, 100, 00, 100, 100, 100, 100, 100, thunderWave, ember, ember, ember));
        pokemons.Add(new Pokemon("charizard", "male", 50, fire, null, 100, 00, 100, 100, 100, 100, 100, thunderWave, ember, ember, ember));
        pokemons.Add(new Pokemon("squirtle", "male", 50, fire, null, 100, 100, 100, 100, 100, 100, 100, thunderWave, ember, ember, ember));
        pokemons.Add(new Pokemon("wartartle", "male", 50, fire, null, 100, 100, 100, 100, 100, 100, 100, thunderWave, ember, ember, ember));

        //GAME

        Team player;
        Team enemy;

        Random rand = new Random();

        int randInt1 = rand.Next(0, 5);
        int randInt2 = rand.Next(0, 5);
        int randInt3 = rand.Next(0, 5);
        int randInt4 = rand.Next(0, 5);
        int randInt5 = rand.Next(0, 5);
        int randInt6 = rand.Next(0, 5);

        int randInt7 = rand.Next(0, 5);
        int randInt8 = rand.Next(0, 5);
        int randInt9 = rand.Next(0, 5);
        int randInt10 = rand.Next(0, 5);
        int randInt11 = rand.Next(0, 5);
        int randInt12 = rand.Next(0, 5);

        player = new Team(pokemons[randInt1].Clone(), pokemons[randInt2].Clone(), pokemons[randInt3].Clone(), pokemons[randInt4].Clone(), pokemons[randInt5].Clone(), pokemons[randInt6].Clone());
        enemy = new Team(pokemons[randInt7].Clone(), pokemons[randInt8].Clone(), pokemons[randInt9].Clone(), pokemons[randInt10].Clone(), pokemons[randInt11].Clone(), pokemons[randInt12].Clone());
        
        foreach (Pokemon pok in enemy.Pokemons)
        {
            pok.Name = "The opposing " + pok.Name;
        }
        
        
        int i = 1;      //Enemy pokmeon index - used to change pokemon

        bool isPlayerTurn = player.isTurnAgainst(enemy);


        while (true)
          {
            Console.WriteLine();
            Console.WriteLine("Your Active Pokemon: " + player.ActivePokemon.Name + " HP: " + player.ActivePokemon.HealthPoints);
            Console.WriteLine();

            Console.Write("Your Team: ");
            Console.WriteLine();
            player.displayTeam();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Enemy Active Pokemon: " + enemy.ActivePokemon.Name + " HP: " + enemy.ActivePokemon.HealthPoints);
            Console.WriteLine();

            Console.Write("Enemy Team: ");
            Console.WriteLine();
            enemy.displayTeam();
            Console.WriteLine();

            if (isPlayerTurn)
            {
                
                Console.WriteLine("Type A to Attack");
                Console.WriteLine("Type S to Switch");


                String choice1 = Convert.ToString(Console.ReadLine());

                switch (choice1)
                {
                    case "A":                                                                   //Attacking
                        player.ActivePokemon.DisplayAttacks();
                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        if (player.ActivePokemon.checkParalysis()) { break; }
                        if(player.ActivePokemon.checkSleep()) { break; }    
                        if(player.ActivePokemon.checkFrozen()) { break; }


                        player.ActivePokemon.AttackPokemon(choice2, enemy.ActivePokemon);

                        if (!enemy.ActivePokemon.isAlive() && enemy.TeamAlive()) //Switch enemy active Pokemon if dead
                        {
                            enemy.ActivePokemon = enemy.Pokemons[i];
                            i++;
                            isPlayerTurn = player.isTurnAgainst(enemy);

                        }

                        break;

                    case "S":                                                                    //Switching
                        bool valid = false;
                        player.displayTeam();
                        Console.WriteLine();
                        Console.WriteLine("Which Pokemon Do you want to switch to?");

                        while (!valid)
                        {
                            int choice3 = Convert.ToInt32(Console.ReadLine());


                            if (player.Pokemons[choice3 - 1].isAlive() && player.ActivePokemon != player.Pokemons[choice3 - 1])
                            {
                                player.SwitchPokemon(choice3);
                                valid = true;
                                isPlayerTurn = player.isTurnAgainst(enemy);
                            }
                            else

                            {
                                if (player.ActivePokemon == player.Pokemons[choice3 - 1])
                                { Console.WriteLine("cannot switch to active Pokemon"); }
                                else { Console.WriteLine("Pokemon is Dead"); }
                            }

                        }
                        Console.WriteLine();

                        break;
                }
                isPlayerTurn = false;
            }


            //Enenmy Attacking

            if (!isPlayerTurn)
            {
                if (!(enemy.ActivePokemon.checkSleep()) && !(enemy.ActivePokemon.checkFrozen())) 
                { 

                    Random atk = new Random();
                    int ranAtk = atk.Next(1, 5);
                    enemy.ActivePokemon.AttackPokemon(ranAtk, player.ActivePokemon);
                    Console.WriteLine();

                    if (!player.ActivePokemon.isAlive())            //Switching Pokemon on Death
                    {
                        bool valid = false;
                        player.displayTeam();
                        Console.WriteLine();


                        while (!valid)
                        {
                            GlobalMethods.PrintSlow("Which Pokemon Do you want to switch to?");
                            int choice3 = Convert.ToInt32(Console.ReadLine());


                            if (player.Pokemons[choice3 - 1].isAlive() && player.ActivePokemon != player.Pokemons[choice3 - 1])
                            {
                                player.SwitchPokemon(choice3);
                                isPlayerTurn = player.isTurnAgainst(enemy);
                                valid = true;
                            }
                            else
                            {
                                if (!player.ActivePokemon.isAlive())
                                { GlobalMethods.PrintSlow("Pokemon is Dead"); }
                                else
                                { GlobalMethods.PrintSlow("cannot switch to active Pokemon"); }
                            }

                        }
                    }
                }
                isPlayerTurn = true;
            }



            if (!player.TeamAlive())
            {
                GlobalMethods.PrintSlow("You Lose!");
                break;
            }
            if(!enemy.TeamAlive())
            {
                GlobalMethods.PrintSlow("You Win!");
                break;
            }

            player.ActivePokemon.checkBurn();
            player.ActivePokemon.checkPoison();
            enemy.ActivePokemon.checkBurn();
            enemy.ActivePokemon.checkPoison();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
        }
    }




}

public static class GlobalMethods
{
    public static void PrintSlow(String text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(30);
        }
        Console.WriteLine();
    }
}




