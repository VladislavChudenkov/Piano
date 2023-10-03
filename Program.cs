class Program
{
    static int[] Current;
    static Dictionary<ConsoleKey, int[]> octaves;
    static void Main(string[] args)
    {
        Console.WriteLine("Пианино");
        Console.WriteLine("Переключение октав: F2-F5");
        Octaves();
        Console.WriteLine("Играть на клавишах: Q, W, E, R, T.");
        while (true)
        {
            var input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.F2 || input == ConsoleKey.F3 || input == ConsoleKey.F4 || input == ConsoleKey.F5)
            {
                Current =  Change(input);
                continue;
            }
            Sound(input);
        }
    }


    static void Octaves()
    {
        octaves = new Dictionary<ConsoleKey, int[]>();
        octaves.Add(ConsoleKey.F2, new int[] { 65, 69, 73, 77, 82 });
        octaves.Add(ConsoleKey.F3, new int[] { 130, 138, 146, 155, 164 });
        octaves.Add(ConsoleKey.F4, new int[] { 261, 277, 293, 311, 329 });
        octaves.Add(ConsoleKey.F5, new int[] { 523, 554, 587, 622, 659 });
    }
    static int[] Change(ConsoleKey input)
    {
        if (octaves.ContainsKey(input))
        {
            return octaves[input];
        }
        else
        {
            return Current;
        }
    }
    static void Sound(ConsoleKey key)
    {
    
            switch (key)
            {
                case ConsoleKey.Q:
                    Console.Beep(Current[0], 100);
                    break;
                case ConsoleKey.W:
                    Console.Beep(Current[1], 100);
                    break;
                case ConsoleKey.E:
                    Console.Beep(Current[2], 100);
                    break;
                case ConsoleKey.R:
                    Console.Beep(Current[3], 100);
                    break;
                case ConsoleKey.T:
                    Console.Beep(Current[4], 100);
                    break;
     }
 }

}
