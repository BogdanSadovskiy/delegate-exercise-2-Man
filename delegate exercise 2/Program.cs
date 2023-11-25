
namespace Myspace;


class program
{
    static void Main(string[] args)
    {
        List<Men> mens = new List<Men>();
        mens.Add(new Men("Bogdan", 27));
        mens.Add(new Men("Ostap", 13));
        mens.Add(new Men("Bogdan Sad", 26));
        mens.Add(new Men("Bandera", 160));
        mens.Add(new Men("Non Name", 10000));
        Console.WriteLine("\tAll man:");
        mens.ForEach((men)=>Console.WriteLine(men));
        Console.WriteLine("+-------------------------------+\n");

        Console.WriteLine("\tSorted by names:");
        mens.Sort((men1, men2) => men1.Name.CompareTo(men2.Name));
        mens.ForEach((men) => Console.WriteLine(men));
        Console.WriteLine("+-------------------------------+\n");

        Console.WriteLine("\tMan older then 25:");
        mens.RemoveAll((men) => men.age < 18);
        mens.ForEach((men) => Console.WriteLine(men));
        Console.WriteLine("+-------------------------------+\n");
        mens.FindAll((men)=>men.age < 100).ForEach((men)=>Console.WriteLine(men));
    }

}



