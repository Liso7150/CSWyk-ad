namespace Wyklad1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Student
{
    public string Name { get; set; }
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
    
}
