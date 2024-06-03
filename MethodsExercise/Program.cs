namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserInput("What is your name: "); // Billy
            string color = GetUserInput("What is your favorite color: "); // Green
            string animal = GetUserInput("What is your favorite animal: "); // Giraffe
            string band = GetUserInput("What is your favorite band: "); // Linkin Park

            Console.WriteLine($"{name} had always felt a deep connection with nature, particularly the color {color}.\nIt reminded him of his favorite place, the lush, sprawling fields just outside of town.\nEvery weekend, {name} would ride his bike to those fields, where he could escape the noise and chaos of everyday life.\nOne sunny afternoon, {name} packed his backpack with a few essentials and headed out, humming his favorite {band} song as he pedaled.\nThe music always seemed to give him a burst of energy, pushing him forward, filling him with a sense of invincibility.\nThe fields awaited, their {color} expanse inviting him into a world of tranquility and adventure.\nAs he arrived, Billy spotted something extraordinary in the distance.\nHe squinted his eyes and saw the graceful movements of a {animal}.\nHis heart skipped a beat; he had always loved {animal}s, their gentle demeanor, and their unique elegance.\nHe approached slowly, not wanting to startle the magnificent creature.\nThe {animal} looked at {name} with its large, curious eyes, and {name} felt an inexplicable bond form between them.\nHe spent hours in the fields, observing and occasionally talking to the {animal}, feeling a profound sense of peace and connection.\nAs the sun began to set, {name} reluctantly prepared to leave.\nHe took one last look at the {animal} and whispered, I'll be back.\nWith a smile on his face and his favorite {band} song playing in his mind, {name} rode back home, the {color} fields and the unexpected friendship with the {animal} leaving an indelible mark on his heart.");
        }

        public static string GetUserInput(string input)
        {
            Console.Write(input);

            return Console.ReadLine();
        }
    }
}
