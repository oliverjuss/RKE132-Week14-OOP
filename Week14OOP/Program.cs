Console.WriteLine("Name your Dog: ");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My naghbors dos name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");

while(myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;


    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }


    public void Rename(string NewName)
    {
        _name = NewName;
        Console.WriteLine($"The dog has been renamed to: {NewName}");
    }


    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHapiness++;
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}