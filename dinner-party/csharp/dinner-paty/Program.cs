using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // calls the GetGuests method to get a list of guests
        var guests = GetGuests();

        //  dictionary called tables with two keys: "Table 1" and "Table 2". Each key has an associated value of an empty list of Guest objects
        var tables = new Dictionary<string, List<Guest>>
        {
            { "Table 1", new List<Guest>() },
            { "Table 2", new List<Guest>() }
        };

        // the code then iterates over each guest in the guests list using a foreach loop
        foreach (var guest in guests)
        {
            // it creates a new list called table1Occupations which contains the occupations of all guests currently seated at "Table 1"
            var table1Occupations = tables["Table 1"].ConvertAll(g => g.Occupation);

            // checks if the current guest’s occupation is already present in table1Occupations. If it is, the guest is added to "Table 2". Otherwise, the guest is added to "Table 1"
            if (table1Occupations.Contains(guest.Occupation))
            {
                tables["Table 2"].Add(guest);
            }
            else
            {
                tables["Table 1"].Add(guest);
            }
        }

        // iterates over each table in the tables dictionary using another foreach loop
        foreach (var tableName in tables.Keys)
        {
            var tableGuests = tables[tableName];

            // it first prints the table name to the console
            Console.WriteLine(tableName); 

            // it then retrieves the list of guests seated at that table and iterates over them using another foreach loop
            foreach (var guest in tableGuests)
            {
                // it prints their name, occupation and bio to the console in a formatted string
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        }
    }

    // the GetGuests method simply returns a hard-coded list of Guest objects
    static List<Guest> GetGuests()
    {
        return new List<Guest>
        {
            new Guest
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            },
            new Guest
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            },
            new Guest
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968) American civil rights campaigner"
            },
            new Guest
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005) American civil rights activist"
            },
            new Guest
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            },
            new Guest
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
            },
            new Guest
            {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
            },
            new Guest
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
            }
        };
    }
}

// the Guest class is used in the GetGuests method to create a list of Guest objects representing the guests at the event
class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }
}
