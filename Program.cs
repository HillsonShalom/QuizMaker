using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(@"1. Create questions
2. Answer Questions
");
            string input = Console.ReadLine();
            if (input == "1")
            {
                XMLService xmlService = new XMLService("Data/data.xml");
                Console.WriteLine("-Type your question");
                string ques = Console.ReadLine();
                Console.WriteLine("-Type the answer");
                string ans = Console.ReadLine();
                Quiz newQuiz = new Quiz(ques, ans);
                xmlService.CreateNodeFromModel(newQuiz);
            }else if (input == "2")
            {
                XMLService xMLService = new XMLService("Data.data.xml");
                
            }
        }
    }

    public class Quiz
    {
        public string question;
        public string answer;

        public Quiz(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public Quiz() { }
    }
}
