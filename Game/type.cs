using System;

public class type
{
	List<type> strongAgainst;
	List<type> weakAgainst;
	List<type> immuneAgainst;

	public type()
	{
		this.strongAgainst = new List<type>();
		this.weakAgainst = new List<type>();
		this.immuneAgainst = new List<type>();
	}


	public List<type> StrongAgainst {
		get { return strongAgainst; }
		set { strongAgainst = value; } }
	public List<type> WeakAgainst {
		get { return weakAgainst;}
		set { weakAgainst = value; }
	}
	public List<type> ImmuneAgainst {
		get { return immuneAgainst; }
		set { immuneAgainst = value; }	 
	}



    public void addStrongAgainst(type Strong)
	{
		this.strongAgainst.Add(Strong);
	}

    public void addWeakAgainst(type Weak)
    {
        this.weakAgainst.Add(Weak);
    }

	public void addImmuneAgainst(type Immune)
	{
		this.immuneAgainst.Add(Immune);
	}



}
