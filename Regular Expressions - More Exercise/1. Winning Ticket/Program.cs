using System.Text.RegularExpressions;

string[] tickets = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(s => s.Trim()).ToArray();

List<string> winners = new List<string>();

foreach (string ticket in tickets)
{
    if (ticket.Length == 20)
    {
        string patternOne = @"\${6,10}";
        string patternTwo = @"\^{6,10}";
        string patternThree = @"\#{6,10}";
        string patternFour = @"\@{6,10}";

        MatchCollection matches = Regex.Matches(ticket, patternOne); //$
        if (matches.Count == 2 && matches[0].Length == matches[1].Length && ticket.Contains('$'))
        {
            if (matches[0].Length == 10)
            {
                winners.Add($"ticket {ticket} - {matches[0].Length}$ Jackpot!");
                Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}$ Jackpot!");
                continue;
            }
            //6-9
            winners.Add($"ticket \"{ticket}\" - {matches[0].Length}$");
            Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}$");
            continue;
        }
        else if (matches.Count == 2 && matches[0].Length != matches[1].Length && ticket.Contains('$'))
        {
            winners.Add($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}$");
            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}$");
            continue;
        }
        else if (matches.Count < 2 && ticket.Contains('$'))
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
            continue;
        }

        matches = Regex.Matches(ticket, patternTwo); //^
        if (matches.Count == 2 && matches[0].Length == matches[1].Length && ticket.Contains('^'))
        {
            if (matches[0].Length == 10)
            {
                winners.Add($"ticket {ticket} - {matches[0].Length}^ Jackpot!");
                Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}^ Jackpot!");
                continue;
            }

            winners.Add($"ticket \"{ticket}\" - {matches[0].Length}^");
            Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}^");
            continue;
        }
        else if (matches.Count == 2 && matches[0].Length != matches[1].Length && ticket.Contains('^'))
        {
            winners.Add($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}^");
            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}^");
            continue;
        }

        else if (matches.Count < 2 && ticket.Contains('^'))
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
            continue;
        }


        matches = Regex.Matches(ticket, patternThree); //#
        if (matches.Count == 2 && matches[0].Length == matches[1].Length && ticket.Contains('#'))
        {
            if (matches[0].Length == 10)
            {
                winners.Add($"ticket {ticket} - {matches[0].Length}# Jackpot!");
                Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}# Jackpot!");
                continue;
            }

            winners.Add($"ticket \"{ticket}\" - {matches[0].Length}#");
            Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}#");
            continue;
        }
        else if (matches.Count == 2 && matches[0].Length != matches[1].Length && ticket.Contains('#'))
        {
            winners.Add($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}#");
            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}#");
            continue;
        }

        else if (matches.Count < 2 && ticket.Contains('#'))
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
            continue;
        }


        matches = Regex.Matches(ticket, patternFour); //@
        if (matches.Count == 2 && matches[0].Length == matches[1].Length && ticket.Contains('@'))
        {
            if (matches[0].Length == 10)
            {
                winners.Add($"ticket {ticket} - {matches[0].Length}@ Jackpot!");
                Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}@ Jackpot!");
                continue;
            }

            winners.Add($"ticket \"{ticket}\" - {matches[0].Length}@");
            Console.WriteLine($"ticket \"{ticket}\" - {matches[0].Length}@");
            continue;
        }
        else if (matches.Count == 2 && matches[0].Length != matches[1].Length && ticket.Contains('@'))
        {
            winners.Add($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}@");
            Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matches[0].Length, matches[1].Length)}@");
            continue;
        }

        else if (matches.Count < 2 && ticket.Contains('@'))
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
            continue;
        }

        if (!ticket.Any(x=>x=='$'||x=='@'||x=='#' ||x=='^'))
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
        }
    }
    else 
    {
        Console.WriteLine("invalid ticket");
    }
}
