Console.WriteLine("write number of elements in array :");
int number = Convert.ToInt32(Console.ReadLine());

string [] stringArray = new string[number];
     for (int i = 0; i < number; i++)
        {
            Console.Write($"Input word, number or symbol {i + 1}: ");
            string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("it is not possible to leave empty string, try again :");
                        i--; 
                    }
                else
                    {
                    stringArray[i] = input;
                    }
        }


