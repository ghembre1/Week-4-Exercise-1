using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Exercise_1
{
    class Program
    {
        // Sets the array for the votes
        static int[] votes = new int[3];

        static void Main(string[] args)
        {
            bool continueVoting = true; // while the voting is true

            while (continueVoting) // while continue voting is good it will run the display
            {
                DisplayCandidates();
                int choice = GetVote();
                CastVote(choice);

                Console.WriteLine("Do you want to cast another vote? (yes/no)"); // prompts user to cast vote
                string response = Console.ReadLine().ToLower(); // takes users response
                continueVoting = response == "yes";
            }

            DisplayResults();
        }

        static void DisplayCandidates()
        {
            Console.WriteLine("Please choose a candidate to vote for:"); // prompts user the candidates
            Console.WriteLine("1. Candidate 1");
            Console.WriteLine("2. Candidate 2");
            Console.WriteLine("3. Candidate 3");
        }

        static int GetVote() // method for get vote
        {
            int choice;
            while (true)
            {
                Console.Write("Enter the number of your choice (1-3): "); //prompts users to enter their number
                string input = Console.ReadLine(); //takes users input

                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 3) // checks users input for it to only be between 1 and 3
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3."); // if input is not a valid number it prompts them
                }
            }
            return choice;
        }

        static void CastVote(int choice)
        {
            // takes the users vote and prompts them
            votes[choice - 1]++;
            Console.WriteLine($"You voted for Candidate {choice}.");
        }

        static void DisplayResults()
        {
            Console.WriteLine("Voting results:"); // prompts results to user
            for (int i = 0; i < votes.Length; i++)
            {
                Console.WriteLine($"Candidate {i + 1}: {votes[i]} votes"); // prompts user the candidates votes
            }
        }
    }
}
