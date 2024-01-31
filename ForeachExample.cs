
class ForeachExample
{
    static void Main(string[] args)
    {
        IEnumerable<int> list = new List<int> { 1, 3, 5, 7, 3};
        foreach ( int i in list) {
            // NOTE:
            // Modifying the collection here, including adding and removing elements,
            // can lead to unexpected behavior and may even result in exceptions.
            // NOTE:
            // Not thread-safe, synchronization is necessary for asynchronous execution.
            Console.WriteLine( i);
        }
    }
}
