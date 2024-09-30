double moneyAvailable = 0;
string coin = string.Empty;

while ((coin = Console.ReadLine()) != "Start")
{
	double currentCoin = double.Parse(coin);
	switch (currentCoin)
	{
		case 0.1:
		case 0.2:
		case 0.5:
		case 1:
		case 2:
			moneyAvailable += currentCoin;
			break;
		default:
			Console.WriteLine($"Cannot accept {currentCoin}");
			break;
	}
}
	string product = string.Empty;
	while ((product = Console.ReadLine()) != "End")
	{
		double productPrice = 0;

		if (product == "Nuts")
		{
		      productPrice = 2;
		}
		else if (product == "Water")
		{
			  productPrice = 0.7;
		}
		else if (product == "Crisps")
		{
			  productPrice = 1.5;
		}
		else if (product == "Soda")
		{
			  productPrice = 0.8;
		}
		else if (product == "Coke")
		{
			  productPrice = 1;
		}
		else
		{
			Console.WriteLine("Invalid product");
			continue;
		}

	    if (moneyAvailable >= productPrice)
	    {
			Console.WriteLine($"Purchased {product.ToLower()}");
			moneyAvailable -= productPrice;
	    }
	    else 
	    {
			Console.WriteLine("Sorry, not enough money");
	    }
    }
Console.WriteLine($"Change: {moneyAvailable:F2}");