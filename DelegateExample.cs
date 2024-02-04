public delegate int Str2IntDelegate(in string str);
class DelegateExample
{
    static public int Foo(in string str)
    {
        Console.WriteLine("DelegateExample::Foo(\"" + str + "\")");
        return str.Length;
    }

    public int Bar( in string str) {
        Console.WriteLine("DelegateExample::Bar(\"" + str + "\")");
        return str.Length;
    }

    static void Main(string[] args)
    {
        Str2IntDelegate d1 = new Str2IntDelegate(DelegateExample.Foo);
        Console.WriteLine(d1.Invoke( "Hello,"));

        Str2IntDelegate d2 = new Str2IntDelegate(new DelegateExample().Bar);
        Console.WriteLine( d2( "World!!!")); // same with Invoke()

        Str2IntDelegate d3 = d2 + d1;
        d3("multi-delegate");
    }
}
