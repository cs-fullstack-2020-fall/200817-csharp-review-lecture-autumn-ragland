using System;
class Basic
{
    private string description;
    private int lectureDuration;
    public Basic(string description, int lectureDuration)
    {
        this.description = description;
        this.lectureDuration = lectureDuration;
    }

    public void OutputProps()
    {
        Console.WriteLine($"This basic object is an instance of the basic class. The description of the object is {this.description} and the duration of the lecture covering this object is {this.lectureDuration} minutes");
    }
    public void UpdateLectureDuration()
    {
        Console.WriteLine($"The current duration is {this.lectureDuration}\nEnter the new lecture duration : ");
        this.lectureDuration = Int16.Parse(Console.ReadLine());
    }
    public void UpdateLectureDuration(int newDuration)
    {
        this.lectureDuration = newDuration;
        Console.WriteLine($"The new lecture duration is {newDuration}");
    }
}
