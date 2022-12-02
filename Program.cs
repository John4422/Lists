string menu;
bool done = false;
Random generator = new Random();
var rand = new Random();
List<int> numbers = new List<int>();


for (int i = 0; i < 24; i++)
{
    numbers.Add(rand.Next(10, 21));
}

while (!done)
{
    foreach (int i in numbers)
    {

        Console.Write($"{i},");
    }
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1) Sorting");
    Console.WriteLine("2) New List");
    Console.WriteLine("3) Remove");
    Console.WriteLine("4) ");
    Console.WriteLine("5) ");
    Console.WriteLine("X) Exit");
    Console.Write("Enter a selection to run it: ");
    menu = Console.ReadLine()!.ToLower();

    switch (menu)
    {
        case "1":
            
            numbers.Sort();               
            Console.WriteLine();
            break;

        case "2":
                
            numbers.Clear();
            for (int i = 0; i < 24; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }

            break;
        case "3":
            int numberre = Int32.Parse( Console.ReadLine()); 
            numbers.RemoveAll(item => item == numberre);
            numbers.Sort();
            foreach (int i in numbers)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();


            break;
        case "4":
        
        break;
        case "5":
        var radds = new Random();
        List<int> numbbes = new List<int>();


        for (int i = 0; i < 24; i++)
        {
            numbbes.Add(radds.Next(10, 21));
        }

        foreach (int i in numbbes)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        break;
        case "x":
            done = true;
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
        }
    }
