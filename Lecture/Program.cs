using System;
using System.Collections.Generic;
using System.Linq;
namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 08 17 Lecture");
            // Basic basicObject = new Basic("Super Basic", 15);
            // basicObject.OutputProps();
            // basicObject.UpdateLectureDuration();
            // basicObject.UpdateLectureDuration(25);
            BaseAnimal animal1 = new BaseAnimal("scientific bear", 25, AnimalType.mammal);
            // animal1.OutputProps();
            // animal1.FindCommonName();
            // EndangeredAnimal animal2 = new EndangeredAnimal("bass scientific", 5, AnimalType.fish, 400);
            // animal2.FindCommonName();
            // animal2.OutputProps();
            List<BaseAnimal> animalList = new List<BaseAnimal>();
            BaseAnimal animal3 = new BaseAnimal("scientific otter", 14, AnimalType.mammal);
            BaseAnimal animal4 = new BaseAnimal("scientific toucan", 5, AnimalType.bird);
            animalList.Add(animal1);
            animalList.Add(animal3);
            animalList.Add(animal4);
            Console.WriteLine($"Total animals in list : {animalList.Count}");

            // animalList.ForEach(animal => animal.OutputProps());
            // AvgLifespan(animalList);
            FilterByLifespan(animalList, 10);
            FilterByTaxonomy(animalList, animal3);
        }
        public static void AvgLifespan(List<BaseAnimal> animalList)
        {
            double avgSpan = animalList.Average(animal => animal.lifeSpan);
            Console.WriteLine($"The average lifespan of all animals in the list is {avgSpan}");
        }
        public static void FilterByLifespan(List<BaseAnimal> animalList, int span)
        {
            List<BaseAnimal> filtered = animalList.Where(animal => animal.lifeSpan >= span).ToList();
            Console.WriteLine("By Lifespan");
            filtered.ForEach(animal => animal.OutputProps());
        }
        public static void FilterByTaxonomy(List<BaseAnimal> animalList, BaseAnimal baseAnimal)
        {
            List<BaseAnimal> filtered = animalList.Where(animal => animal.taxonomy == baseAnimal.taxonomy).ToList();
            Console.WriteLine("Matching Taxonomy");
            filtered.ForEach(animal => animal.OutputProps());
        }
    }
}
