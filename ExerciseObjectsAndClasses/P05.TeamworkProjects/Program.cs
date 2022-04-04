using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.TeamworkProjects
{
    internal class Program
    {
        class Team
        {
            public Team(string teamName, string creatorName)
            {
                this.Name = teamName;
                this.Creator = creatorName;

                this.Members = new List<string>();
            }
            public string Name { get; set; }

            public string Creator { get; set; }
            public List<string> Members { get; set; }
            public void AddMember(string member)
            {
                this.Members.Add(member);
            }
        }
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            RegisterTeam(teams, n);

        }
        static void RegisterTeam(List<Team> teams, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creatorName = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string memberName = joinArgs[0];
                string teamName = joinArgs[1];

                Team searchedTeam = teams
                    .FirstOrDefault(t => t.Name == teamName);

                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.AddMember(memberName);

                
            }

            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name) 
                .ToList();

            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            PrintValidTeams(teamsWithMembers);

            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in teamsToDisband)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }
           
        }
        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");

                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }
        }
    }
}
