using System;
using System.Collections.Generic;
class BaseAnimal 
{
    protected string scientificName; 
    public int lifeSpan; 
    public AnimalType taxonomy;
    public BaseAnimal(string scientificName, int lifeSpan, AnimalType taxonomy)
    {
        this.scientificName = scientificName;
        this.lifeSpan = lifeSpan;
        this.taxonomy = taxonomy;
    }
    public void OutputProps()
    {
        Console.WriteLine($"Scientific Name : {this.scientificName}\nLifespan : {this.lifeSpan}\nTaxonomy : {this.taxonomy}");
    }
    public void FindCommonName()
    {
        Dictionary<string, string> animalNames = new Dictionary<string, string>();
        animalNames.Add("scientific bear", "bear");
        animalNames.Add("scientific fish", "fish");
        animalNames.Add("scientific otter", "otter");

        try{
            Console.WriteLine($"The common name of {this.scientificName} is {animalNames[this.scientificName]}");
        } catch 
        {
            Console.WriteLine($"{this.scientificName} was not found in our records");
        }

    }
}
enum AnimalType
{
    amphibian, bird, fish, invertebrate, mammal, reptile
}