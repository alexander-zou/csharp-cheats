
class Properties
{
    public int Property1 { get; set; }
    // the line above is equivalent to:
    // public int Property1;

    public int Property2 { get; private set; }
    // Property2 is readonly from outside

    // coded getter/setter, used for validation and/or simple calculation:
    public int Property3 {
        get {
            return 12345;
        }
        set {
            Console.WriteLine( "Trying to set Property3 to " + value);
        }
    }
}

class PropertyExample
{
    static void Main(string[] args)
    {
        Properties obj = new Properties();

        obj.Property1 = 98765;
        Console.WriteLine( "" + obj.Property1); // result: 98765

        // obj.Property2 = 88888;
        // Compiler Error: The property or indexer 'Properties/Property2' cannot be used in this context because the set accessor is inaccessible.

        obj.Property3 = 54321;
        Console.WriteLine( "" + obj.Property3); // result: 12345

    }
}
