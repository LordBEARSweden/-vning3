
using System;
using System.Collections.Generic;
namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonHandler handler = new PersonHandler();

            //Person person1 = new Person();
            //try
            //{
            //    person1 = handler.CreatePerson(11, "Kalle", "Anka", 120, 60);
            //  // person1 = new Person()
            //    //{
            //    //   // Age = 20,
            //    //    FName = "Björn",
            //    //    LName = "Andersson",
            //    //    Height = 184,
            //    //    Weight = 25
            //    //};



            //}
            //catch (ArgumentException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //handler.SetAge(person1, 55);
            //var age = handler.GetAge(person1);



            //Console.WriteLine(person1?.Age);
            //Console.WriteLine(person1?.FName);
            //Console.WriteLine(person1?.LName);
            //Console.WriteLine(person1?.Height);
            //Console.WriteLine(person1?.Weight);
            //Console.ReadLine();


            Horse horse = new Horse(2, "Brunte", 300, "Ardenner");
            Wolf wolf = new Wolf(10, "Varg", 90);
            //Console.WriteLine(horse.Stats());

            List<Animal> ListAnimal = new List<Animal>();
            ListAnimal.Add(horse);
            ListAnimal.Add(wolf);
            
            foreach(Animal animal in ListAnimal)
            {
               if  (animal is IPerson)
                {
                    var person = (IPerson)animal;
                   person.Talk();
                }
               else
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
            }

            List<UserError> ErrorList = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError()
            };
            foreach (var error in ErrorList)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
// frågor
//Arv Fråga 13: Vi bör lägga det i grundklassen för Fåglar.
//Fråga 14: Då bör vi lägga det i grundklassen för Animals.
//
//Polimorphism
//Fråga 9: För att de tillhör olika listor/klasser med olika attribut.
//Fråga 10: Listan måste vara en Base typ för att alla klasser skall kunna lagras tillsammans.
//Fråga 13: Programmet kallar på på stats från de olika klasserna och skriver sedan ut dem i konsollen.
// Fråga 17: vet ej
//
//Fråga 11: Det är viktigt att behärska eftersom det ändå är en stor del av objektorienterad programmering
// och dessutom så kan det snabb bli väldigt komplicerat och svårt att hålla koll om man inte är helt med på hur
// det fungerar.
//Fråga 12:
//Fråga 13: 