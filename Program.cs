using System.ComponentModel;

string menu;
bool done = false;
Random generator = new Random();
var rand = new Random();
List<int> numbers = new List<int>();
int numberre;

while (!done)
{
    foreach (int i in numbers)
    {

        Console.Write($"{i},");
    }
    for (int i = 0; i < 24; i++)
    {
        numbers.Add(rand.Next(10, 21));
    }
    Console.WriteLine("This is a number game where you decied what to do with them");
    Console.WriteLine("1) Sorting");
    Console.WriteLine("2) New List");
    Console.WriteLine("3) Remove");
    Console.WriteLine("4) Adding a new value");
    Console.WriteLine("5) Finding a number");
    Console.WriteLine("6) Showing the largest number");
    Console.WriteLine("7) Showing lowest number");
    Console.WriteLine("X) Exit");
    Console.Write("Enter a selection to run it: ");
    menu = Console.ReadLine()!.ToLower();

    switch (menu)
    {
        case "1":
            
                numbers.Sort();               
                Console.Write(numbers);
                break;

        case "2":
                
                numbers.Clear();
                for (int i = 0; i < 24; i++)
                {
                    numbers.Add(generator.Next(10, 21));
                }

                break;
            case "3":
                Console.WriteLine("Please choose a number to remove");
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
                numberre = Int32.Parse(Console.ReadLine());
                numbers.RemoveAll(item => item == numberre);
                numbers.Sort();
                foreach (int i in numbers)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine();


                break;
        case "4":
            Console.WriteLine("Add any number you decide");
            numberre = Int32.Parse(Console.ReadLine());
            numbers.Add(numberre);
                foreach (int i in numbers)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine();
                break;
        case "5":
            Console.WriteLine("What number would you like to find the specific amout of?");
            int numbe = Int32.Parse(Console.ReadLine());
            if (numbers.Count == numbe)
            {
                Console.WriteLine($"Their is {numbers.Count} of {numbe}");
            }
                break;
        case "6":
            Console.WriteLine("I am going to print the largest number in the list");
            Console.WriteLine(numbers);
            int max = numbers.Max();
            Console.WriteLine($"in this list the max number is {max}");
                break;
        case "7":
            Console.WriteLine("I am going to print the smallest number in the list");
            Console.WriteLine(numbers);
            int min = numbers.Min();
            Console.WriteLine($"in this list the minimum number is {min}");
            break;
        case "x":
                done = true;
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    
}

done = false;
List<string> veg = new List<string>() { "Carrot", "Beet", "Celery", "Radish", "Cabbage" };
while (!done)
{
    foreach (string s in veg)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("Menu Options:");
    Console.WriteLine("Choose a path to go down in this game");
    Console.WriteLine("1) Remove by Index");
    Console.WriteLine("2) Remove by Value");
    Console.WriteLine("3) Searching");
    Console.WriteLine("4) Adding a vegtables");
    Console.WriteLine("5) Sorting");
    Console.WriteLine("6) Clearing");
    Console.WriteLine("X) Exit");
    Console.Write("Enter a selection to run it: ");
    menu = Console.ReadLine()!.ToLower();

    switch (menu)
    {
        case "1":
            Console.WriteLine("Decide which vegetable to remove between 1-5");
           foreach (string i in veg)
            {
                Console.WriteLine(i);
            }
            int vega = Int32.Parse(Console.ReadLine());
            veg.RemoveAt(vega);
            foreach (string i in veg)
            {
                Console.WriteLine(i);
            }
            break;
        case "2":
            Console.WriteLine("Decide which vegetable to remove between 1-5");
            foreach (string i in veg)
            {
                Console.WriteLine(i);
            }
            int vegt = Int32.Parse(Console.ReadLine());
            veg.Remove(veg[vegt]);
            foreach (string i in veg)
            {
                Console.WriteLine(i);
            }
            break;
        case "3":
            Console.WriteLine("In this you are searching for a certin vegtable shown in the list");
            string vegta =(Console.ReadLine());
            int sear = veg.IndexOf(vegta);
            Console.WriteLine("the vegtable is at index", sear);
            break;
        case "4":
            Console.WriteLine("Add any vegtable you decide");
            int vegb = Int32.Parse(Console.ReadLine());
            numbers.Add(vegb);
            foreach (string i in veg)
            {
                Console.Write($"{i}, ");
            }
            break;
        case "5":
            Console.WriteLine("I will be sorting the list in this one");
            veg.Sort();
            foreach (string i in veg)
            {
                Console.WriteLine(i);
            }
            break;
        case "6":
            Console.WriteLine("I am clearing the list in this one");
            veg.Clear();
            break;
        case "x":
            done = true;
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
}
