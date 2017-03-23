using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 18.7f;
            pokemon.Abilities = "Blaze";
            pokemon.Category = "Lizard";
            pokemon.Gender = "QQ";
            Console.WriteLine("這個Pokemon的身高:{0}公分,體重:{1}公斤", pokemon.Height, pokemon.Weight);
        }
    }
}