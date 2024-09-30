namespace _02._Shopping_List
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            // 04. Programming Fundamentals Mid Exam - 02. Shopping List
            //14:44 - 15:20-29-48

            List<string> listOfProducts = Console.ReadLine().Split("!",StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split(" ");
                string commandInfo = command[0];
                string product = command[1];

                if (commandInfo == "Urgent")
                {
                    //if (!listOfProducts.Contains(product))
                    if (!listOfProducts.Exists(x => x == product))
                    {
                        listOfProducts.Insert(0, product);
                    }
                }

                else if (commandInfo == "Unnecessary")
                {
                    if (listOfProducts.Contains(product))
                    {
                        listOfProducts.Remove(product);
                    }
                }
                else if (commandInfo == "Correct")
                {
                    string newProduct = command[2];

                    //if (listOfProducts.Contains(product)) 
                    if (listOfProducts.Exists(x => x == product) && listOfProducts.Count > 0)
                    {
                        int index = listOfProducts.IndexOf(product);
                        listOfProducts.RemoveAt(index); // при махане по идекс трябва да има проверка за наличието на поне 1 елемент в листа
                        listOfProducts.Insert(index, newProduct);
                        //listOfProducts.Remove(product); // не е необходима проверка за дължината на листа
                    }
                }
                else if (commandInfo == "Rearrange")
                {
                    if (listOfProducts.Exists(x => x == product))
                    //if (listOfProducts.Contains(product)) 
                    {
                        listOfProducts.Remove(product); // при махане по идекс трябва да има проверка за наличието на поне 1 елемент в листа
                        listOfProducts.Add(product);
                    }
                }
            } 
            Console.WriteLine(string.Join(", ",listOfProducts));
        }
    }
}