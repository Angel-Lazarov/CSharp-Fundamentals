namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end") 
            {

                string[] inputInfo = input.Split();
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                int serialNumber = int.Parse(inputInfo[0]);
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                double itemPrice = double.Parse(inputInfo[3]);
                double priceForABox = itemQuantity * itemPrice;

                Box box = new Box();

              //  box.Item = new Item();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.ItemQuantity = itemQuantity;
                box.PriceForABox = priceForABox;

                boxes.Add(box);
            }

            List<Box> orderByDescending = boxes.OrderByDescending(x => x.PriceForABox).ToList();
           
            foreach (Box box in orderByDescending)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");

            }
        }

        class Item 
        {
            public string Name { get; set; }
            public double Price { get; set; }   
        }
        class Box   
        {
            public Box()
            {
                Item = new Item();
            }
            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForABox { get; set; }
        }
    }
}