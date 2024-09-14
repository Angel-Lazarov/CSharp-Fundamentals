//4.11.23 - 18:07

/*
 
2
Tedy-SoftUni
Tanya-CloneClub
John->SoftUni
George->SoftUni
Helena->CloneClub
Cossima->CloneClub
end of assignment

 */


int countTeams = int.Parse(Console.ReadLine());

List<Team> teams = new List<Team>();

for (int i = 0; i < countTeams; i++)
{
    string[] registerInfo = Console.ReadLine().Split("-");
    string teamCreator = registerInfo[0];
    string teamName = registerInfo[1];

    Team team = new Team(teamName, teamCreator);

    bool isTeamExist = IsTeamExist(teamName, teams);
    bool isCreatorfree = IsCreatorFree(teamCreator, teams);

    if (isTeamExist)
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }

    if (!isCreatorfree)
    {
        Console.WriteLine($"{teamCreator} cannot create another team!");
        continue;
    }

    //if (!isTeamExist && isCreatorfree)  //проверка дали съществува отбор с такова име и дали създателя има други отбори
    //{
    teams.Add(team);
    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
    //}

}

string input = string.Empty;

while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] inputInfo = input.Split("->");
    string memberName = inputInfo[0];
    string teamToJoin = inputInfo[1];

    bool isTeamExist = IsTeamExist(teamToJoin, teams);

    if (!isTeamExist)
    {
        Console.WriteLine($"Team {teamToJoin} does not exist!");
        continue;
    }

    bool isMemberInTeam = IsMemberInTeam(memberName, teams);

    if (isMemberInTeam)
    {
        Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
        continue;
    }

    if (!isMemberInTeam && isTeamExist)
    {
        foreach (Team currentTeam in teams)
        {
            if (currentTeam.TeamName == teamToJoin)
            {
                currentTeam.Members.Add(memberName);
                break;
            }
        }
    }
}


teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();

foreach (Team currentTeam in teams.Where(x => x.Members.Count > 0))
{
    Console.WriteLine($"{currentTeam.TeamName}");
    Console.WriteLine($"- {currentTeam.CreatorName}");
    string mem = CreateMembersList(currentTeam);
    Console.WriteLine(mem);
}

Console.WriteLine("Teams to disband:");
foreach (Team currentTeam in teams.Where(x => x.Members.Capacity == 0))
{
    Console.WriteLine(currentTeam.TeamName);
}


static string CreateMembersList(Team currentTeam)
{
    string mem = string.Empty;

    currentTeam.Members = currentTeam.Members.OrderBy(x => x).ToList();

    for (int i = 0; i < currentTeam.Members.Count - 1; i++)
    {
        mem += $"-- {currentTeam.Members[i]}\n";
    }
    mem += $"-- {currentTeam.Members[currentTeam.Members.Count - 1]}";
    return mem;
}
static bool IsMemberInTeam(string memberName, List<Team> teams)
{
    foreach (Team team in teams)
    {
        if (team.Members.Contains(memberName) || team.CreatorName == memberName)
        {
            return true;
        }
    }
    return false;
}
static bool IsTeamExist(string teamNameToCheck, List<Team> teams)
{
    foreach (Team team in teams)
    {
        if (team.TeamName == teamNameToCheck)
        {
            return true;
        }
    }
    return false;
}

bool IsCreatorFree(string teamCreator, List<Team> teams)
{
    foreach (Team currentTeam in teams) // мини през всички отбори в списъка
    {
        if (currentTeam.CreatorName == teamCreator)  // и провери създателя дали има вече отбор
        {
            return false;
        }
    }
    return true;
}

class Team
{

    public Team(string teamName, string creatorName)
    {
        TeamName = teamName;
        CreatorName = creatorName;
        Members = new List<string>();
    }

    public string TeamName { get; set; }
    public string CreatorName { get; set; }
    public List<string> Members { get; set; }
}