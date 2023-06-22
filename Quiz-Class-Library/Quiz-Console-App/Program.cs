using Quiz_Class_Library;

namespace Quiz_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ConsoleUI(DemoHelper.GetDemoQuiz());
        }
    }
}