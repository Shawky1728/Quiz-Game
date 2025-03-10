namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions =
            {
                "What is the capital of Italy ?",
                "What is the red planet ?",
                "What is the largest animale ?"
            };

            string[] answers =
            {
                "Rome",
                "Mars",
                "Whale"
            };

            int Total = 0;

            Console.WriteLine("Welcome To My Game (^_^) Press Any Key to start");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please Answer The Following Questions \n");

            for (int i=0;i<answers.Length;i++) {

                Console.WriteLine(questions[i]);
                string result = Console.ReadLine();
                bool score = CheckAnswer(result, answers[i]);
                if (score) { 
                  Total++;
                }
                Console.Clear();
            }

            Console.WriteLine($"Your Final Score = {Total}/{questions.Length}");
        }

        private static bool CheckAnswer(string userInput,string answer)
        {
            if(userInput == answer)
            {
                return true;
            }
            return false;
        }

    }
}
