using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random rnd = new Random();
        public int contestantCount = 0;

        public Sweepstakes(string name)
        {

        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = UserInterface.GetContestantFirstName();
            contestant.lastName = UserInterface.GetContestantLastName();
            contestant.email = UserInterface.GetContestantEmail();
            contestant.registrationNumber = contestantCount;
            
            contestants.Add(contestant.registrationNumber, contestant);
            contestantCount++;

        }
	    string PickWinner()
        {
            int winningNumber = rnd.Next(0, contestantCount-1);
            Contestant winner = contestants[winningNumber];

            return winner.firstName + winner.lastName + winner.email;


        }
	    public void PrintContestantInfo(Contestant winner)
        {

            Console.WriteLine("The winning contestant is " + winner.firstName + " " + winner.lastName + " " + winner.email);

        }



    }
}
