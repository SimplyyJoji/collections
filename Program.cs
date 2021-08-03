using System;
using System.Collections.Generic;



// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)
namespace NewCFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(numArray[2]);
            string[] names = {"Tim","Martin","Nikki", "Sara"};
            // for (int i = 0; i < names.Length; i++)
            // {
            //     Console.WriteLine($"My name is {names[i]}");
            // }
            // Console.WriteLine(numArray[2]);
            bool[] trueOrFalse = {true,false,true,false,true,false,true,false,true,false};
            // Console.WriteLine(trueOrFalse[2]);

            List<string> flavors = new List<string>();

            flavors.Add("Strawberry");
            flavors.Add("Pizza");
            flavors.Add("Noob Tears");
            flavors.Add("DogeCoin Noodles");
            flavors.Add("G-Fuel");
            
            // for (var idx = 0; idx < flavors.Count; idx++)
            // {
            //     Console.WriteLine("-" + flavors[idx]);
            // }
            // Console.WriteLine(flavors.Count -1);
            // Console.WriteLine(flavors[2]);
            flavors.Remove("Noob Tears");
            // Console.WriteLine(flavors.Count -1);

            Dictionary<string,string> profile = new Dictionary<string, string>();
            Random rand = new Random();  
            for (int i = 0; i < names.Length; i++)
            {
                
                    profile.Add(names[i],flavors[rand.Next(0,5)] );
                    Console.WriteLine($"{names[i]} is the name, {profile[names[i]]} is the random flavor");
                
                
            }
            
            
        }
    }
}

