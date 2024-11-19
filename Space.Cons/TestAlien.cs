using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Cons
{
    //static (string teamName, int totalHealth) PerformBattle(Team team)
    //{
    //    int aIndex = 0, bIndex = 0;

    //    while (aIndex < team.TeamA.Count && bIndex < team.TeamB.Count)
    //    {
    //        var a = team.TeamA[aIndex];
    //        var b = team.TeamB[bIndex];

    //        bool isTeamAAttacking = a.Speed > b.Speed;

    //        if (isTeamAAttacking)
    //        {
    //            b.Health -= a.Strength;
    //            if (b.Health <= 0) bIndex++;
    //        }
    //        else
    //        {
    //            a.Health -= b.Strength;
    //            if (a.Health <= 0) aIndex++;
    //        }
    //    }


    //    if (aIndex >= team.TeamA.Count)
    //    {
    //        int totalHealthB = team.TeamB.Skip(bIndex).Sum(p => p.Health);
    //        return ("TeamB", totalHealthB);
    //    }
    //    else
    //    {
    //        int totalHealthA = team.TeamA.Skip(aIndex).Sum(p => p.Health);
    //        return ("TeamA", totalHealthA);
    //    }
    //}
}
