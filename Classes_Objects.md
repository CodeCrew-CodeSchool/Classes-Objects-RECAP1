# Classes-Objects-RECAP1
Classes and Objects in C#

## WHAT ?

What is Object Oriented Programming?
Object oriented programming is mimicking real world objects in code. Everything in C# is essentially a class, and we can instantiate objects from classes that we can manage at a smaller level.

- What is a class?

- What is an object?


## WHY? 



- We use Classes in C# to construct real world entities in our life

- Think about where you are, the job you currently have, your name, your family, the car you drive, etc.. ALL of these things can be constructed as classes.

- Objects just make the object come to life. We can't really do anything to a class the way it is. Think of it as breathing life into something. We can now use the obeject the way it was intended. 

- Anatomy of a class:

```

class Car {
// properties here
public string Make {get; set};

public string Model {get; set};

public int Year {get; set};

// methods here
public void Drive(){
    Console.WriteLine("I am driving!");
}

}

```

## HOW?

Lets create a pizza store
Create a program and implement the following:
A "Pizza" Store Class

Properties that describe the store (Name, Address, Size)

Constructor to specify the name of the store

OrderPizza - -returns pizza

A "Pizza" Class
Constructor that specifies the type of pizza
Properties for the ingredients
Bake() Method
Cut() Method -
Order() Method