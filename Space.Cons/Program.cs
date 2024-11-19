#region oldCode

//using Involved.HTF.Common;
//using Space.Cons;
//using System.IO;
//using System.Net.Http.Json;
//using System.Text;
//using System.Text.Json;

//Uri baseUrl = new Uri("https://app-htf-2024.azurewebsites.net/");

//const string pp = "891b528b-815e-436d-8173-349ee7c7f433";
//const string uu = "Space-force";
//var client = new HttpClient();
//client.BaseAddress = baseUrl;


//client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue
//    ("bearer", "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1IiwibmJmIjoxNzMyMDA5MTA1LCJleHAiOjE3MzIwOTU1MDUsImlhdCI6MTczMjAwOTEwNX0.nluXjUMEaUtPsvCWKfwY3xBwe3nB4a2SRAjschk9KnEDCDxtDt-6HMHlNqLFr4AOidQ_zeBkpHJkAWXkoQbQpQ");
//var response = await client.PostAsJsonAsync($"/api/team/move", new { speed = "M", angle = 120 });


//#region OEF 1

//await client.GetAsync("api/a/easy/start");

//var response1 = await client.GetFromJsonAsync<A1Response>("/api/a/easy/sample");
//var response2 = await client.GetFromJsonAsync<A1Response>("/api/a/easy/puzzle");

//var resultTest = CalculateDepth("Down 7, Up 2, Forward 2");
//var result1 = CalculateDepth(response1.Commands);
//var result2 = CalculateDepth(response2.Commands);



//var response3 = await client.PostAsJsonAsync("/api/a/easy/sample", result1);
//var puzzleResponse = await client.PostAsJsonAsync("/api/a/easy/puzzle", result2);

//var resultTest1 = await response3.Content.ReadAsStringAsync();
//var resultTest2 = await puzzleResponse.Content.ReadAsStringAsync();

//Console.WriteLine("");


//static int CalculateDepth(string input)
//{

//    string[] commandsList = input.Split(',');

//    int depth = 0;
//    int distance = 0;

//    int currentDepth = 0;
//    int currentDistance = 0;

//    foreach (var command in commandsList)
//    {
//        string[] parts = command.Trim().Split(':');
//        string action = parts[0];
//        int value = int.Parse(parts[1]);

//        if (action == "Down")
//        {
//            depth += value;

//        }
//        else if (action == "Up")
//        {
//            depth -= value;

//        }
//        else if (action == "Forward")
//        {
//            currentDepth += depth;
//            currentDistance += value;
//            depth = 0;
//        }
//    }

//    int result = currentDepth * currentDistance;

//    return result;
//}
//#endregion


//#region OEF2
//await client.GetAsync("api/b/easy/alphabet");

//var responseAlpa = await client.GetAsync("/api/b/easy/alphabet");
//var responseBody = await responseAlpa.Content.ReadAsStringAsync();
//var oplos = JsonSerializer.Deserialize<Dictionary<char, char>>(responseBody);
//Console.WriteLine(responseBody);

//await client.GetAsync("api/b/easy/start");
//var responseOEF2 = await client.GetFromJsonAsync<AlphaResponse>("/api/b/easy/puzzle");
////var responseBodyOEF2 = await responseOEF2.AlienMessage.ReadAsStringAsync();

//string solution = "";

//foreach (var character in responseOEF2.AlienMessage)
//{
//    if (oplos.ContainsValue(character))
//    {
//        solution += oplos.FirstOrDefault(c => c.Value == character).Key;
//    }
//    else
//    {
//        solution += character;
//    }

//}

//var isOk = await client.PostAsJsonAsync("api/b/easy/puzzle", solution);
//#endregion









//#region Nova Centauri
//static (string teamName, int totalHealth) PerformBattle(Team team)
//{
//    int aIndex = 0, bIndex = 0;

//    while (aIndex < team.TeamA.Count && bIndex < team.TeamB.Count)
//    {
//        var a = team.TeamA[aIndex];
//        var b = team.TeamB[bIndex];

//        bool isTeamAAttacking = a.Speed >= b.Speed;

//        if (isTeamAAttacking)
//        {
//            while (a.Health > 0 && b.Health > 0)
//            {
//                b.Health -= a.Strength;
//                if (b.Health <= 0)
//                {
//                    bIndex++;
//                    break;
//                }

//                a.Health -= b.Strength;
//                if (a.Health <= 0)
//                {
//                    aIndex++;
//                    break;
//                }
//            }

//        }
//        else
//        {
//            while (a.Health > 0 && b.Health > 0)
//            {
//                a.Health -= b.Strength;
//                if (a.Health <= 0)
//                {
//                    aIndex++;
//                    break;
//                }

//                b.Health -= a.Strength;
//                if (b.Health <= 0)
//                {
//                    bIndex++;
//                    break;
//                }
//            }
//        }
//    }

//    if (aIndex >= team.TeamA.Count)
//    {
//        int totalHealthTeamB = 0;

//        foreach (var alien in team.TeamB)
//        {
//            if (alien.Health > 0)
//                totalHealthTeamB += alien.Health;
//        }

//        return ("TeamB", totalHealthTeamB);
//    }
//    else
//    {
//        int totalHealthTeamA = 0;

//        foreach (var alien in team.TeamA)
//        {
//            if (alien.Health > 0)
//                totalHealthTeamA += alien.Health;
//        }


//        return ("TeamA", totalHealthTeamA);
//    }
//}

//await client.GetAsync("api/a/medium/start");
//var teams = await client.GetFromJsonAsync<Team>("/api/a/medium/sample");

//var whoWon = PerformBattle(teams);

//WhoWon iets = new WhoWon
//{ 
//    WinningTeam = whoWon.teamName,
//    RemainingHealth = whoWon.totalHealth,
//};
//var postWonResult = await client.PostAsJsonAsync("/api/a/medium/sample", iets);
//Console.WriteLine(postWonResult);




//await client.GetAsync("api/a/medium/start");
//var teamsPuzzle = await client.GetFromJsonAsync<Team>("/api/a/medium/puzzle");
//var whoWonPuzzle = PerformBattle(teamsPuzzle);

//WhoWon winTeamPuzzle = new WhoWon
//{
//    WinningTeam = whoWonPuzzle.teamName,
//    RemainingHealth = whoWonPuzzle.totalHealth,
//};

//var postWonResultPuzzle = await client.PostAsJsonAsync("/api/a/medium/puzzle", winTeamPuzzle);

//Console.WriteLine();

//#endregion

#endregion

using Involved.HTF.Common;
using Space.Cons;
using System.Text.Json;
using System.Net.Http.Json;

Uri apiBaseUrl = new Uri("https://app-htf-2024.azurewebsites.net/");

const string teamIdentifier = "891b528b-815e-436d-8173-349ee7c7f433";
const string teamDisplayName = "Space-force";

var httpClient = new HttpClient
{
    BaseAddress = apiBaseUrl
};

httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
    "bearer",
    "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjQ1IiwibmJmIjoxNzMyMDA5MTA1LCJleHAiOjE3MzIwOTU1MDUsImlhdCI6MTczMjAwOTEwNX0.nluXjUMEaUtPsvCWKfwY3xBwe3nB4a2SRAjschk9KnEDCDxtDt-6HMHlNqLFr4AOidQ_zeBkpHJkAWXkoQbQpQ"
);

// Initial move
await httpClient.PostAsJsonAsync("/api/team/move", new { speed = "M", angle = 120 });

#region Exercise 1

await httpClient.GetAsync("api/a/easy/start");

var easySampleData = await httpClient.GetFromJsonAsync<A1Response>("/api/a/easy/sample");
var easyPuzzleData = await httpClient.GetFromJsonAsync<A1Response>("/api/a/easy/puzzle");

int testCommandResult = CalculateDepth("Down 7, Up 2, Forward 2");
int sampleCommandDepth = CalculateDepth(easySampleData.Commands);
int puzzleCommandDepth = CalculateDepth(easyPuzzleData.Commands);

await httpClient.PostAsJsonAsync("/api/a/easy/sample", sampleCommandDepth);
await httpClient.PostAsJsonAsync("/api/a/easy/puzzle", puzzleCommandDepth);

Console.WriteLine("Exercise 1 completed.");

static int CalculateDepth(string commandInput)
{
    string[] commandArray = commandInput.Split(',');

    int cumulativeDepth = 0;
    int totalForwardDistance = 0;

    foreach (var command in commandArray)
    {
        string[] commandParts = command.Trim().Split(' ');
        string actionType = commandParts[0];
        int actionValue = int.Parse(commandParts[1]);

        if (actionType == "Down") cumulativeDepth += actionValue;
        else if (actionType == "Up") cumulativeDepth -= actionValue;
        else if (actionType == "Forward") totalForwardDistance += actionValue;
    }

    return cumulativeDepth * totalForwardDistance;
}

#endregion

#region Exercise 2

await httpClient.GetAsync("api/b/easy/alphabet");

var alphabetDataResponse = await httpClient.GetAsync("/api/b/easy/alphabet");
var alienToHumanMapping = JsonSerializer.Deserialize<Dictionary<char, char>>(await alphabetDataResponse.Content.ReadAsStringAsync());

await httpClient.GetAsync("api/b/easy/start");
var alphabetPuzzleData = await httpClient.GetFromJsonAsync<AlphaResponse>("/api/b/easy/puzzle");

string translatedAlienMessage = string.Concat(
    alphabetPuzzleData.AlienMessage.Select(
        alienCharacter => alienToHumanMapping.ContainsValue(alienCharacter)
                          ? alienToHumanMapping.FirstOrDefault(mapping => mapping.Value == alienCharacter).Key
                          : alienCharacter
    )
);

await httpClient.PostAsJsonAsync("/api/b/easy/puzzle", translatedAlienMessage);

Console.WriteLine("Exercise 2 completed.");

#endregion

#region Nova Centauri Battle Simulation

await httpClient.GetAsync("api/a/medium/start");
var mediumSampleData = await httpClient.GetFromJsonAsync<Team>("/api/a/medium/sample");

var sampleBattleResult = PerformBattle(mediumSampleData);
var sampleBattleSummary = new WhoWon
{
    WinningTeam = sampleBattleResult.teamName,
    RemainingHealth = sampleBattleResult.totalHealth
};

await httpClient.PostAsJsonAsync("/api/a/medium/sample", sampleBattleSummary);

await httpClient.GetAsync("api/a/medium/start");
var mediumPuzzleData = await httpClient.GetFromJsonAsync<Team>("/api/a/medium/puzzle");

var puzzleBattleResult = PerformBattle(mediumPuzzleData);
var puzzleBattleSummary = new WhoWon
{
    WinningTeam = puzzleBattleResult.teamName,
    RemainingHealth = puzzleBattleResult.totalHealth
};

await httpClient.PostAsJsonAsync("/api/a/medium/puzzle", puzzleBattleSummary);

Console.WriteLine("Nova Centauri battle simulation completed.");

static (string teamName, int totalHealth) PerformBattle(Team battleTeam)
{
    int teamAIndex = 0, teamBIndex = 0;

    while (teamAIndex < battleTeam.TeamA.Count && teamBIndex < battleTeam.TeamB.Count)
    {
        var teamAMember = battleTeam.TeamA[teamAIndex];
        var teamBMember = battleTeam.TeamB[teamBIndex];

        bool isTeamAAttacking = teamAMember.Speed >= teamBMember.Speed;

        while (teamAMember.Health > 0 && teamBMember.Health > 0)
        {
            if (isTeamAAttacking)
            {
                teamBMember.Health -= teamAMember.Strength;
                if (teamBMember.Health <= 0) teamBIndex++;
            }
            else
            {
                teamAMember.Health -= teamBMember.Strength;
                if (teamAMember.Health <= 0) teamAIndex++;
            }
        }
    }

    if (teamAIndex >= battleTeam.TeamA.Count)
    {
        int totalRemainingHealthTeamB = battleTeam.TeamB.Where(member => member.Health > 0).Sum(member => member.Health);
        return ("TeamB", totalRemainingHealthTeamB);
    }
    else
    {
        int totalRemainingHealthTeamA = battleTeam.TeamA.Where(member => member.Health > 0).Sum(member => member.Health);
        return ("TeamA", totalRemainingHealthTeamA);
    }
}

#endregion
