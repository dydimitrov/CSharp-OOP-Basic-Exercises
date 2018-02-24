using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private int power;
    private int displacement;
    private string efficiency;

    public Engine()
    {
        this.Efficiency = "n/a";
        this.Displacement = 0;
    }
    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
    }
    public Engine(string model, int power,int displacemnt):this(model,power)
    {
        this.Displacement = displacemnt;
    }
    public Engine(string model, int power, int displacemnt, string efficiency):this(model,power,displacemnt)
    {
        this.Efficiency = efficiency;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public int Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
