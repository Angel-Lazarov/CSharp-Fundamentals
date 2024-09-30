namespace _03._Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> log = new List<string>();
            string input = string.Empty;


            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();
                string commandName = command[0];
                string message1 = command[1];

                if (commandName == "Chat")
                {
                    log.Add(message1);
                }
                else if (commandName == "Delete")
                {
                    if (log.Contains(message1))
                    {
                        log.Remove(message1);
                    }
                }
                else if (commandName == "Edit")
                {
                    string editedMessage = command[2];

                    if (log.Contains(message1))
                    {
                        int currentIndex = log.IndexOf(message1);
                        log[currentIndex] = editedMessage;
                    }
                }
                else if (commandName == "Pin")
                {
                    if (log.Contains(message1)) 
                    {
                        int currentIndex = log.IndexOf(message1);
                        string currentMessage = message1;
                        log.RemoveAt(currentIndex);
                        log.Add(currentMessage);
                    }
                }
                else if (commandName == "Spam") 
                {
                    for (int i = 1; i < command.Count; i++) 
                    {
                        log.Add(command[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, log));
        }
    }
}