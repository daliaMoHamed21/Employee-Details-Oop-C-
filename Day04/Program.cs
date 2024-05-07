namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] id = new int[5];
            string[] name = new string[5];
            double[] salary = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter employee data : {i + 1}");
                //Enter  id and check if unique
                bool isUnique;
                do
                {
                    Console.Write("ID: ");
                    isUnique = int.TryParse(Console.ReadLine(), out id[i]) && IsUnique(id, i);
                    if (!isUnique)
                    {
                        Console.WriteLine("ID must be unique ,Please enter a different ID : ");
                    }
                } while (!isUnique);

                //Enter name 
                Console.Write("Name: ");
                name[i] = Console.ReadLine();

                //Enter salary
                Console.Write("Salary: ");
                salary[i] = double.Parse(Console.ReadLine());

                Console.WriteLine();


            }

            // Wait for 10 seconds
            Console.WriteLine("Employees data will be appear after 10 seconds ");
            Thread.Sleep(10000);

            // Print Employees data 
            Console.WriteLine("Employees Data:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" ID: {id[i]}, Name: {name[i]}, Salary: {salary[i]:C}");
            }

        }
        // Task 2 what is the difference between string and string builder

        // 1- Strings are immutablet which meaning that once a string object is created its value cann't be changed
        // 2- StringBuilder is mutable allowing us to modify the contents of the string


        static bool IsUnique(int[] id, int currIndex)
        {
            for (int i = 0; i < currIndex; i++)
            {
                if (id[i] == id[currIndex])
                {
                    return false; // ID not unique
                }
            }
            return true; // ID unique
        }
    }
}