namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is quite challenging, but some like myself are very good at it.");
                    break;
                case "Science":
                    Console.WriteLine("Science is very interesting and will open your mind up.");
                    break;
                case "English":
                    Console.WriteLine("Great choice. I struggled a lot with English up until college.");
                    break;
                case "History":
                    Console.WriteLine("Awesome. Those who do not remember the past are condemned to repeat it.");
                    break;
                case "Physical Education":
                    Console.WriteLine("Solid. Intelligence and skill can only function at the peak of their capacity when the body is healthy and strong.");
                    break;
                default:
                    Console.WriteLine($"Wow, I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}