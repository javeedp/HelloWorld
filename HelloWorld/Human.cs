using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Human
    {      //instance variables
        //name,height,weight,Age
        //syntax - acessmodifier datatype variable
        public string name;
        public float height, weight;
        public int age;
        //instance
        public void Speak() // method defination/signature
        {
            //method body or implementation
            Console.WriteLine("Human can Speak");
        }
        //instance
        public void HumanDetails(string HumanName, float HumanHeight, float HumanWeight, int age) // method defination/signature
        {
            //method body or implementation
            Console.WriteLine("Human Details:{0} {1} {2} {3}", HumanName, HumanHeight, HumanWeight, age);

        }
    }
}


    

