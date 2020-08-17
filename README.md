# 200817 C# Review Lecture

## Set Up
- Create a new .NET console app called Lecture
- Change the default output message in the Program Main method to "20 08 17 Lecture"

#### Basic Class, Variables, Input and Output
- Define a `Basic` class with private properties `description` and `lectureDuration` and set the values in the constructor
- In the `Basic` class define a method to output the message "This basic object is an instance of the basic class. The description of the object is DESCRIPTION and the duration of the lecture covering this object is LECTURE_DURATION minutes" in the console
- In the `Basic` class define a method that takes no parameters to update the lectureDuration property by prompting the user in the console
- In the `Basic` class define a method that takes one parameter to update the lectureDuration property to the parameter passed in
- Create an instance of the `Basic` class in the Program Main method and call each class method

#### Class Inherence
- Define a `BaseAnimal` class with properties `scientificName`, `lifeSpan`, and `taxonomy`
- In the `BaseAnimal` class define a method to output all property values in the console
- Define an `EndangeredAnimal` that extends the `BaseAnimal` class
- Define a new `EndangeredAnimal` property `remainingAnimals`
- Overwrite the `BaseAnimal` method to output all properties to include the remainingAnimals property
- Create an instance of the `EndangeredAnimal` class in the Program main method and call the class method

#### Complex Types
- Update the type of `taxonomy` defined in the `BaseAnimal` class from string to Enum with options amphibian, bird, fish, invertebrate, mammal, reptile
- Define a method in the `BaseAnimal` class to find an animal's common name based on the scientific name 
    - define a dictionary of strings with the key as an animal's scientific name and the value as the common name
    - method outputs the common name matching the scientific name defined in the dictionary
    - gracefully handle no matching scientific name
- Update the animal objects in the Program class method and call the new class method

#### Looping
- In the Program class main method create three new instances of the `BaseAnimal` class
- Add each instance to a list 
- Output each animals properties by looping through the list of animals

#### LINQ
- In the Program class define a method to get the average lifespan of all animals in a list of animals and output that average age
- In the Program class define a method to filter all animals from a list of animals with a lifespan greater or equal to some value into a new list and output each animal in that list
- In the Program class define a method to filter all animals from a list of animals with the same taxonomy of a passed animal object and output each animal in the list
