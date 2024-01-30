namespace ForLoopsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Michael", "Sarah", "Steven", "Jonald", "Grognak, The Destroyer: Attorney At Law", "Jeffrey"};
            for(int i = 0; i < names.Length; i ++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
