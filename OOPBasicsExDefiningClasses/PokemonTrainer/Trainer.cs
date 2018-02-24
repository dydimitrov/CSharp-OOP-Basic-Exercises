using System;
using System.Collections.Generic;
using System.Text;


public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> listOfPokemons;

    public Trainer()
    {
        this.Badges = 0;
        this.ListOfPokemons = new List<Pokemon>();
    }
    public Trainer(string name, List<Pokemon> listOfPokemons)
        :this()
    {
        this.Name = name;
        this.ListOfPokemons = listOfPokemons;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }   
    }

    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }

    public List<Pokemon> ListOfPokemons
    {
        get { return listOfPokemons; }
        set { listOfPokemons = value; }
    }


}
