
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Personality Quiz!");
        Console.WriteLine("Answer each question with 'A', 'B', 'C', or 'D'.");

        string[] questions = {
            "1. What is your favorite color?\nA) Red\nB) Blue\nC) Green\nD) Yellow",
            "2. What is your ideal vacation?\nA) Relaxing on a beach\nB) Exploring a new city\nC) Hiking in the mountains\nD) Adventurous activities like skydiving",
            "3. How do you handle stress?\nA) Meditate or practice yoga\nB) Talk to a friend or family member\nC) Exercise or go for a run\nD) Take some time alone to recharge",
            "4. What type of movie do you prefer?\nA) Romance\nB) Action\nC) Comedy\nD) Documentary"
        };

        int[] responses = new int[4];

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            string answer = Console.ReadLine().ToUpper();

            switch (answer)
            {
                case "A":
                    responses[0]++;
                    break;
                case "B":
                    responses[1]++;
                    break;
                case "C":
                    responses[2]++;
                    break;
                case "D":
                    responses[3]++;
                    break;
                default:
                    Console.WriteLine("Invalid response, please try again.");
                    i--;
                    break;
            }
        }

        string personalityType = DeterminePersonality(responses);

        Console.WriteLine($"Your personality type is: {personalityType}");
        Console.ReadLine();
    }

    static string DeterminePersonality(int[] responses)
    {
        if (responses[0] > responses[1] && responses[0] > responses[2] && responses[0] > responses[3])
        {
            return "Type A - Calm and introspective";
        }
        else if (responses[1] > responses[0] && responses[1] > responses[2] && responses[1] > responses[3])
        {
            return "Type B - Adventurous and outgoing";
        }
        else if (responses[2] > responses[0] && responses[2] > responses[1] && responses[2] > responses[3])
        {
            return "Type C - Humorous and laid-back";
        }
        else
        {
            return "Type D - Analytical and logical";
        }
    }
}
