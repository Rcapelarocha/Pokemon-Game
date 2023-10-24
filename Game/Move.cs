using System;

public class Move 
{

	private type moveType;
	private string moveName;
	private string moveClass;
	private double power;
	private double accuracy;
    private int pp;
    private string volEffect;
    private string nonVolEffect;
	public Move(string moveName, type moveType, double power, double accuracy, string moveClass, int pp)
    {
        this.moveName = moveName;
        this.moveType = moveType;
        this.moveClass = moveClass;
        this.power = power;
        this.accuracy = accuracy;
        this.pp = pp;
    }

    public Move(string moveName, type moveType, double accuracy, string moveClass, int pp, string volEffect, string nonVolEffect)
    {
        this.MoveName = moveName;
        this.moveType = moveType;
        this.accuracy = accuracy;
        this.moveClass = moveClass;
        this.pp = pp;
        this.volEffect = volEffect;
        this.nonVolEffect = nonVolEffect;
        this.nonVolEffect = nonVolEffect;
    }

    public type MoveType {
        get { return moveType; }
        set { moveType = value; } 
    }
	public string MoveName {
        get { return moveName; }
        set { moveName = value; } 
    }
    public string MoveClass 
        {
        get { return moveClass; }
        set { moveClass = value; } 
    }
	public double Power
    {
        get { return power; }
        set { power = value; }
    }
	public double Accuracy {
        get { return accuracy; }
        set{ accuracy = value; }   
        }
    
    public int PP {
        get { return pp; }
        set { pp = value; } 
    } 

    public string VolEffect
    {
        get { return volEffect; }
        set { volEffect = value; }
    }

    public string NonVolEffect
    {
        get { return nonVolEffect; }
        set { nonVolEffect = value; }
    }


	//Check for SuperEffective
	public Boolean isSuperEffectiveAgainst(Pokemon enemy, type type)       
	{
		
        if (this.MoveType.StrongAgainst.Contains(type))
		{
			return true;
		}
		return false;
	}

    //Check for Not Very Effective
    public Boolean isNotVeryEffectiveAgainst(Pokemon enemy, type type)
    {
        if (this.MoveType.WeakAgainst.Contains(type))
        {
            return true;
        }
        return false;
    }

    //Check for Immunity
    public Boolean isImmuneAgainst(Pokemon enemy, type type)
    {
        if (this.MoveType.ImmuneAgainst.Contains(type))
        {
            return true;
        }
        return false;
    }


    public Move Clone()
    {
        Move clonedMove = new Move(
            moveName: this.MoveName,
            moveType: this.MoveType,
            power: this.Power,
            accuracy: this.Accuracy,
            moveClass: this.MoveClass,
            pp: this.PP
        );

        return clonedMove;
    }


}
