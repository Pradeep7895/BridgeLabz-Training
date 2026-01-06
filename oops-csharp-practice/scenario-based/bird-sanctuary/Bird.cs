using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Bird
    {
        //birds attribute
        protected int birdID;
        protected string name;
        protected int age;
        protected string habitat;
        protected string diet;
        protected bool IsEndangered;


        //constructor
        public Bird(int birdID, string name,int age,  string habitat, string diet, bool IsEndangered )
        {
            this.birdID = birdID;
            this.name = name;
            this.age = age;
            this.habitat = habitat;
            this.diet = diet;
            this.IsEndangered = IsEndangered;

        }
        //to string method override
        public override string ToString()
        {
            return
                $"Bird ID : {birdID}\n" +
                $"Bird Name : {name}\n" +
                $"Bird age: {age}\n" +
                $"Bird Habitat : {habitat}\n" +
                $"Bird Diet: {diet}\n" +
                $"Endengered or not: {IsEndangered}\n";
        }
    }
}
