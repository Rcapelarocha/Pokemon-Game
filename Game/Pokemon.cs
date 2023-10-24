using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

public class Pokemon 
{
    //Initializing Variables

	private String name;
	private String gender;
	private int level;
	private type type1;
    private type type2;
    private String nonVolstatus;
    private List<String> volStatus;

	private double healthPoints;
    private double maxHealthPoints;
	private double speed;
	private double attack;
	private double speacialAttack;
	private double defense;
	private double speacialDefense;
	private double evasiveness;

	private Move move1;
	private Move move2;
	private Move move3;
	private Move move4;

    //Constructor

    public Pokemon(string name, string gender, int level, type type1, type type2, double healthPoints, double speed, double attack, double speacialAttack, double defense, double speacialDefense, double evasiveness, Move move1, Move move2, Move move3, Move move4)
    {
        this.name = name;
        this.gender = gender;
        this.level = level;
        this.type1 = type1;
        this.type2 = type2;
        this.healthPoints = healthPoints;
        this.maxHealthPoints = healthPoints;
        this.speed = speed;
        this.attack = attack;
        this.speacialAttack = speacialAttack;
        this.defense = defense;
        this.speacialDefense = speacialDefense;
        this.evasiveness = evasiveness;
        this.move1 = new Move(move1.MoveName, move1.MoveType, move1.Power, move1.Accuracy, move1.MoveClass, move1.PP);
        this.move2 = new Move(move2.MoveName, move2.MoveType, move2.Power, move2.Accuracy, move2.MoveClass, move2.PP);
        this.move3 = new Move(move3.MoveName, move3.MoveType, move3.Power, move3.Accuracy, move3.MoveClass, move3.PP);
        this.move4 = new Move(move4.MoveName, move4.MoveType, move4.Power, move4.Accuracy, move4.MoveClass, move4.PP);

        this.volStatus = new List<String>();
        this.nonVolstatus = null;
    }
    //Setters and Getters
    public String Name                                
    {
        get { return name; }                       

        set
        {                                       
            name = value;
        }
    }
    public String Gender
    {
        get { return gender; }

        set
        {
            gender = value;
        }
    }
    public int Level
    {
        get { return level; }

        set
        {
            level = value;
        }
    }
    public type Type1
    {
        get { return type1; }

        set
        {
            type1 = value;
        }
    }
    public type Type2
    {
        get { return type2; }

        set
        {
            type2 = value;
        }
    }
    public String NonVolStatus
    {
        get { return nonVolstatus; }

        set
        {
            nonVolstatus = value;
        }
    }

    public List<String> VolStatus
    {
        get { return volStatus; }
        set { volStatus = value; }
    }
    public double HealthPoints
    {

        get { 
            if (healthPoints > 0) 
            { 
                return healthPoints; 
            }
            else
            {
                return 0;
            }
        }

        set
        {
            healthPoints = value;
        }
    }

    public double MaxHealthPoints
    {

        get
        {
                return maxHealthPoints;
        }
        set
        {
            maxHealthPoints = value;
        }
    }

    public double Speed
    {
        get { return speed; }

        set
        {
            speed = value;
        }
    }

    public double Attack
    {
        get { return attack; }
        set
        {
            attack = value;
        }
    }

    public double SpeacialAttack
    {
        get { return speacialAttack; }

        set
        {
            speacialAttack = value;
        }
    }

    public double Defense
    {
        get { return defense; }

        set
        {
            defense = value;
        }
    }

    public double SpeacialDefense
    {
        get { return speacialDefense; }

        set
        {
            speacialDefense = value;
        }
    }

    public double Evasiveness
    {
        get { return evasiveness; }
        set
        {
            evasiveness = value;
        }
    }

    public Move Move1
    {
        get { return move1; }
        set { move1 = value; }
    }

    public Move Move2
    {
        get { return move2; }
        set { move2 = value; }
    }

    public Move Move3
    {
        get { return move3; }
        set { move3 = value; }
    }

    public Move Move4
    {
        get { return move4; }
        set { move4 = value; }
    }


    //METHODS
    public void AttackPokemon(int moveIndex, Pokemon enemy)
    {

        Move move = null;

        switch (moveIndex)
        {
            case 1:
                move = this.Move1;
                this.Move1.PP -= 1;
                break;
            case 2:
                move = this.Move2;
                this.Move2.PP -= 1;
                break;
            case 3:
                move = this.Move3;
                this.Move3.PP -= 1;
                break;
            case 4:
                move = this.Move4;
                this.Move4.PP -= 1;
                break;
            default:
                GlobalMethods.PrintSlow("Invalid move index.");
                return;
        }
        double dmg = 0;
        GlobalMethods.PrintSlow(this.Name + " Used " + move.MoveName);
        Random miss = new Random();
        if (miss.Next(1, 101) > move.Accuracy)                                              //Check Miss
        {
            GlobalMethods.PrintSlow(enemy.Name + " Avoided the Attack ");
        }
        else
        {
            

            if (NonVolStatus == "Burn") //Check Burn Multiplier
            {
                burnMul = 0.5;
            }
            else
            {
                burnMul = 1;
            }

            if (move.MoveClass == "Physical")
            {
                dmg = burnMul*(((((2 * level) / 5) + 2) * move.Power * (this.Attack / enemy.Defense)) / 50 + 2);                    //Physical
            }
            else if(move.MoveClass == "Speacial")
            {
                dmg = (((((2 * level) / 5) + 2) * move.Power * (this.SpeacialAttack / enemy.SpeacialDefense)) / 50 + 2);            //Speacial
            }
            else if (move.MoveClass == "Status")
            {
                
                enemy.NonVolStatus = move.NonVolEffect;
                enemy.addVolStatus(move.VolEffect);

                
                switch (move.NonVolEffect)
                {
                    
                    case "Poison":
                        GlobalMethods.PrintSlow(enemy.Name + " was poisoned");
                        break;
                    case "Paralysis":
                        GlobalMethods.PrintSlow(enemy.Name + " was paralyzed");
                        break;
                    case "Sleep":
                        GlobalMethods.PrintSlow(enemy.Name + " has falled asleep");
                        break;
                    case "Frozen":
                        GlobalMethods.PrintSlow(enemy.Name + " was frozen");
                        break;
                    case "Burn":
                        GlobalMethods.PrintSlow(enemy.Name + " was burnt");
                        break;
                    default:
                        break;
                }
            }


            double mul = 1;
            //TYPE 1

            if (move.MoveClass == "Physical" || move.MoveClass == "Speacial")
            {
                if (move.isSuperEffectiveAgainst(enemy, enemy.type1))            //Check SuperEffective
                {
                    dmg = dmg * 2;
                    mul *= 2;
                }
                if (move.isNotVeryEffectiveAgainst(enemy, enemy.type1))         //Check Not Effective
                {
                    dmg = dmg / 2;
                    mul /= 2;
                }
            }
                if (move.isImmuneAgainst(enemy, enemy.type2))                   //Check Immunity      
                {
                    dmg = 0;
                    mul = 0;
                }

            //TYPE 2

            if (move.MoveClass == "Physical" || move.MoveClass == "Speacial")
            {
                if (enemy.Type2 != null)
                {
                    if (move.isSuperEffectiveAgainst(enemy, enemy.type2))           //Check SuperEffective
                    {
                        dmg = dmg * 2;
                        mul *= 2;
                    }
                    if (move.isNotVeryEffectiveAgainst(enemy, enemy.type2))         //Check Not Effective
                    {
                        dmg = dmg / 2;
                        mul /= 2;
                    }
                }
            }
                    if (move.isImmuneAgainst(enemy, enemy.type2))                    //Check Immunity      
                    {
                        dmg = 0;
                        mul = 0;
                    }
                
            
            //Displaying Advantage
            if (mul == 2 || mul == 4)
            {
                GlobalMethods.PrintSlow("It was SuperEffective!");
            }
            if (mul == 0.5 || mul == 0.25)
            {
                GlobalMethods.PrintSlow("It was not very effective");
            }
            if (mul == 0)
            {
                GlobalMethods.PrintSlow("It does not affect " + enemy.Name);
            }




            if (move.MoveClass == "Physical" || move.MoveClass == "Speacial")
            {
                if (this.Type1 == move.MoveType || this.Type2 == move.MoveType)                  //Check Stab
                {
                    dmg *= 1.5;
                }

                Random crit = new Random();
                int critVal = crit.Next(1, 101);

                if (critVal <= 10)                                                              //Check Critical Hit
                {
                    dmg *= 1.5;
                    GlobalMethods.PrintSlow("It was a critical hit!");
                }
            }

            enemy.HealthPoints -= dmg;


            if (!enemy.isAlive())
            {
                GlobalMethods.PrintSlow(enemy.Name + " fainted");
            }
        }  
    }
    public Boolean isAlive()
    {
        if (this.HealthPoints > 0)
        {
            return true;
        }
        else { return false; }
    } 

    public void DisplayAttacks()
    {
        Console.WriteLine("1. " + this.Move1.MoveName + " Power: " + this.Move1.Power + " Accuracy:" + this.Move1.Accuracy + " PP:" + this.Move1.PP);
        Console.WriteLine("2. " + this.Move2.MoveName + " Power: " + this.Move2.Power + " Accuracy:" + this.Move2.Accuracy + " PP:" + this.Move2.PP);
        Console.WriteLine("3. " + this.Move3.MoveName + " Power: " + this.Move3.Power + " Accuracy:" + this.Move3.Accuracy + " PP:" + this.Move3.PP);
        Console.WriteLine("4. " + this.Move4.MoveName + " Power: " + this.Move4.Power + " Accuracy:" + this.Move4.Accuracy + " PP:" + this.Move4.PP);
        Console.WriteLine();
    }

    public Pokemon Clone()
    {
        Pokemon clonedPokemon = new Pokemon(
            name: this.Name,
            gender: this.Gender,
            level: this.Level,
            type1: this.Type1,
            type2: this.Type2,
            healthPoints: this.HealthPoints,
            speed: this.Speed,
            attack: this.Attack,
            speacialAttack: this.SpeacialAttack,
            defense: this.Defense,
            speacialDefense: this.SpeacialDefense,
            evasiveness: this.Evasiveness,
            move1: this.Move1.Clone(),
            move2: this.Move2.Clone(),
            move3: this.Move3.Clone(),
            move4: this.Move4.Clone()
        );

        return clonedPokemon;
    }

    public bool isFaster(Pokemon enemy)
    {
        if (this.Speed > enemy.Speed)
        {
            return true;
        }
        else if (this.Speed < enemy.Speed)
        {
            return false;
        }
        else   //speed tie
        {
            Random speedtie = new Random();
            if (speedtie.Next(0, 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    public void addVolStatus(String status)
    {
        this.volStatus.Add(status);
    }

    public void removeVolStatus(String status)
    {
        this.volStatus.Remove(status);
    }

    public bool checkParalysis()
    {
        if (this.nonVolstatus == "Paralysis")
        {
            Random para = new Random();

            if (para.Next(1, 5) == 1)
            {
                GlobalMethods.PrintSlow("The " + Name + " is paralyzed!");
                return true;
            }
            return false;
        }
        return false;
    }

    public void checkPoison()
    {
        if (this.NonVolStatus == "Poison")
        {
            this.HealthPoints -= this.MaxHealthPoints / 16;
            GlobalMethods.PrintSlow("The " + Name + " was hurt by poison!");
        }
    }
    public bool checkFrozen()
    {
        if (NonVolStatus == "Frozen")
        {
            Random froz = new Random();
            if (froz.Next(1, 6) == 1)
            {
                GlobalMethods.PrintSlow("The " + Name + " has thawed out!");
                return false;
            }
            else
            {
                GlobalMethods.PrintSlow("The " + Name + " is frozen");
                return true;
            }
        }
        return false;
    }

    int playerSleep = 0;
    public bool checkSleep()
    {
        if (this.NonVolStatus == "Sleep")
        {
            Random sleep = new Random();

            if (sleep.Next(1, 4) == 1 || playerSleep == 3)
            {
                GlobalMethods.PrintSlow("The " + Name + " woke up!");
                playerSleep = 0;
                return false;
            }
            else
            {
                GlobalMethods.PrintSlow("The " + Name + " is asleep");
                playerSleep++;
                return true;
            }
        }
        return false;
    }
    double burnMul = 1;
    public void checkBurn()
    {
        if (NonVolStatus == "Burn")
        {
            GlobalMethods.PrintSlow("The " + Name + " was burnt");
            this.HealthPoints -= this.MaxHealthPoints / 16;
        }

    }

}
