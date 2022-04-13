using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usernamesAndRecords = new Dictionary<string, int>();
            int capacity = int.Parse(Console.ReadLine());

            string cmd = Console.ReadLine();
            int records = 0;
            while (cmd != "Statistics")
            {
                string[] cmdArgs = cmd
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    string username = cmdArgs[1];
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);

                    records = sent + received;
                    if (!usernamesAndRecords.ContainsKey(username))
                    {
                        usernamesAndRecords.Add(username, records);
                    }
                    

                }
                else if (cmdType == "Message")
                {
                    string sender = cmdArgs[1];
                    string receiver = cmdArgs[2];

                    if (usernamesAndRecords.ContainsKey(sender) && usernamesAndRecords.ContainsKey(receiver))
                    {
                        usernamesAndRecords[sender] += 1;
                        usernamesAndRecords[receiver] += 1;

                    }

                    foreach (var item in usernamesAndRecords.Values)
                    {
                        if (item >= capacity)
                        {
                            var myKey = usernamesAndRecords.FirstOrDefault(x => x.Value == item).Key;
                            Console.WriteLine($"{myKey} reached the capacity!");
                            usernamesAndRecords.Remove(myKey);
                        }
                    }

                }
                else if (cmdType == "Empty")
                {
                    string username = cmdArgs[1];
                    if (usernamesAndRecords.ContainsKey(username))
                    {
                        usernamesAndRecords.Remove(username);
                    }
                    if (username == "All")
                    {
                        usernamesAndRecords.Clear();
                    }
                }

                cmd = Console.ReadLine();
            }
            
            Console.WriteLine($"Users count: {usernamesAndRecords.Count}");
            foreach (KeyValuePair<string, int> kvp in usernamesAndRecords)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
