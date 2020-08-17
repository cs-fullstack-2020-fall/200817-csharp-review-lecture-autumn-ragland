using System;
class EndangeredAnimal : BaseAnimal
{
    private int remainingAnimals;
    public EndangeredAnimal(string scientificName, int lifeSpan, AnimalType taxonomy, int remainingAnimals) : base(scientificName, lifeSpan, taxonomy)
    {
        this.remainingAnimals = remainingAnimals;
    }
    public new void OutputProps()
    {
        Console.WriteLine($"Scientific Name : {this.scientificName}\nLifespan : {this.lifeSpan}\nTaxonomy : {this.taxonomy}\nRemaining Animals : {this.remainingAnimals}");
    }
}