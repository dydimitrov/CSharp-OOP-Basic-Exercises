using System;
using System.Collections.Generic;
using System.Text;

namespace P10_SalesMan
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car()
        {
            this.Weight = 0;
            this.Color = "n/a";
        }
        public Car(string model, Engine engine):this()
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight):this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string coler) : this(model, engine, weight)
        {
            this.Color = coler;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


    }
}
