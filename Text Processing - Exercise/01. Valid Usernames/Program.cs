string[] userNames = Console.ReadLine().Split(", ");

foreach (var userName in userNames)
{
    if (userName.Length >= 3 && userName.Length <= 16)
    {
        if (isValid(userName))
        {
            Console.WriteLine(userName);
        }
    }
}

bool isValid(string userName)
{
    bool result = userName.All(symbol => char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_');
    return result;

    //foreach (var simbol in userName)
    //{
    //    if (char.IsLetterOrDigit(simbol) || char.Equals(simbol, '-') || char.Equals(simbol, '_'))
    //    {
    //        continue;
    //    }
    //    else 
    //    {
    //        return false;
    //    }
    //}
    //return true;
}