using System;

namespace ReviewConcepts00
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[5];
            int personIn = 0;
            string optionUser = GatterOptionsUser();

            while (optionUser != "0")
            {
                switch (optionUser)
                {
                    case "1":
                        Console.WriteLine("Type name of Person:");
                        var person = new Person();
                        person.Name = Console.ReadLine();

                        Console.WriteLine("Type Person's height:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal height))
                        {
                            person.Height = height;
                        }
                        else
                        {
                            throw new ArgumentException("The height must be decimal type");
                        }

                        persons[personIn] = person;
                        personIn++;

                        break;
                    case "2":
                        foreach (var ppl in persons)
                        {
                            if (!string.IsNullOrEmpty(ppl.Name))
                            {
                                Console.WriteLine($"Person: {ppl.Name} - Height: {ppl.Height}");
                            }
                        }
                        break;
                    case "3":
                        decimal heighTotal = 0;
                        var nrPerson = 0;

                        for (int i = 0; i < persons.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(persons[i].Name))
                            {
                                heighTotal = heighTotal + persons[i].Height;
                                nrPerson++;
                            }
                        }

                        var averageHeight = heighTotal / nrPerson;
                        EnumConcept generalConcept;

                        if (averageHeight < 1.5M)
                        {
                            generalConcept = EnumConcept.Short;
                        }
                        else if (averageHeight < 1.8M)
                        {
                            generalConcept = EnumConcept.Medium;
                        }
                        else
                        {
                            generalConcept = EnumConcept.Tall;
                        }

                        Console.WriteLine($"Average Heigh: {averageHeight} - We can say they are: {generalConcept}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                optionUser = GatterOptionsUser();
            }
        }

        private static string GatterOptionsUser()
        {
            Console.WriteLine();
            Console.WriteLine("Select the options:");
            Console.WriteLine("1 - Insert Person");
            Console.WriteLine("2 - List Person");
            Console.WriteLine("3 - Height average");
            Console.WriteLine("0 - Quit");
            Console.WriteLine();

            string optionUser = Console.ReadLine();
            Console.WriteLine();
            return optionUser;
        }
    }
}
