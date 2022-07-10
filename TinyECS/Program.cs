namespace TinyECS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e = new List<Entity>();
            e.Add(new Entity() { Id = 12 });
            e.Add(new Entity() { Id = 12 });

            

            Console.WriteLine($"{e[0].Id}");
        }
    }
}