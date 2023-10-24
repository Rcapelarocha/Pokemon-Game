using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
public class Team 
{
    Pokemon[] pokemons = new Pokemon[6];
    Pokemon activePokemon;

    public Team(Pokemon pokemon1, Pokemon pokemon2, Pokemon pokemon3, Pokemon pokemon4, Pokemon pokemon5, Pokemon pokemon6)
    {
        pokemons[0] = pokemon1;
        pokemons[1] = pokemon2;
        pokemons[2] = pokemon3;
        pokemons[3] = pokemon4;
        pokemons[4] = pokemon5;
        pokemons[5] = pokemon6;
        activePokemon = pokemons[0];
    }

    public Pokemon Pokemon1 {
        get { return pokemons[0]; }
        set { pokemons[0] = value; } 
    }
    public Pokemon Pokemon2
    {
        get { return pokemons[1]; }
        set { pokemons[1] = value; }
    }
    public Pokemon Pokemon3
    {
        get { return pokemons[2]; }
        set { pokemons[2] = value; }
    }
    public Pokemon Pokemon4
    {
        get { return pokemons[3]; }
        set { pokemons[3] = value; }
    }
    public Pokemon Pokemon5
    {
        get { return pokemons[4]; }
        set { pokemons[4] = value; }
    }
    public Pokemon Pokemon6
    {
        get { return pokemons[5]; }
        set { pokemons[5] = value; }
    }
    public Pokemon ActivePokemon
    {
        get { return activePokemon; }
        set { activePokemon = value; }
    }

    public Pokemon[] Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public Boolean TeamAlive()
    {
        if (Pokemon1.isAlive() || Pokemon2.isAlive() || Pokemon3.isAlive() || Pokemon4.isAlive() || Pokemon5.isAlive() || Pokemon6.isAlive())
        {
            return true;
        }
        return false;
    }

    public void displayTeam()
    {
        int i = 1;
        foreach (Pokemon pok in pokemons)
        {

                Console.WriteLine(i + ". " + pok.Name + " HP: " + pok.HealthPoints);
                i++;
            
        }
    }

    public void SwitchPokemon(int index)
    {
        index -= 1;

                activePokemon = pokemons[index];
                GlobalMethods.PrintSlow("Go " + activePokemon.Name);
    }

    public bool isTurnAgainst(Team enemy)
    {
        if (this.ActivePokemon.isFaster(enemy.ActivePokemon))
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}

