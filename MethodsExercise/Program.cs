namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE ONE
            string name = GetUserInput("What is your name: "); // Billy
            string color = GetUserInput("What is your favorite color: "); // Green
            string animal = GetUserInput("What is your favorite animal: "); // Giraffe
            string band = GetUserInput("What is your favorite band: "); // Linkin Park

            // UNCOMMENT BELOW TO VIEW SHORT STORY
            // Console.WriteLine($"{name} had always felt a deep connection with nature, particularly the color {color}.\nIt reminded him of his favorite place, the lush, sprawling fields just outside of town.\nEvery weekend, {name} would ride his bike to those fields, where he could escape the noise and chaos of everyday life.\nOne sunny afternoon, {name} packed his backpack with a few essentials and headed out, humming his favorite {band} song as he pedaled.\nThe music always seemed to give him a burst of energy, pushing him forward, filling him with a sense of invincibility.\nThe fields awaited, their {color} expanse inviting him into a world of tranquility and adventure.\nAs he arrived, Billy spotted something extraordinary in the distance.\nHe squinted his eyes and saw the graceful movements of a {animal}.\nHis heart skipped a beat; he had always loved {animal}s, their gentle demeanor, and their unique elegance.\nHe approached slowly, not wanting to startle the magnificent creature.\nThe {animal} looked at {name} with its large, curious eyes, and {name} felt an inexplicable bond form between them.\nHe spent hours in the fields, observing and occasionally talking to the {animal}, feeling a profound sense of peace and connection.\nAs the sun began to set, {name} reluctantly prepared to leave.\nHe took one last look at the {animal} and whispered, I'll be back.\nWith a smile on his face and his favorite {band} song playing in his mind, {name} rode back home, the {color} fields and the unexpected friendship with the {animal} leaving an indelible mark on his heart.");
        
            // EXERCISE TWO
            Console.WriteLine($"Sum: {Add(1,2,3,4,5)}");
            Console.WriteLine($"Difference: {Subtract(10,3,2)}");
            Console.WriteLine($"Product: {Multiply(1,2,3,4,5)}");

            (int quotient, int remainder) = Divide(99,2,2,2,2);
            Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
        }

        public static int Add(params int[] values)
        {
            int result = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                result += values[i];
            }

            return result;
        }

        public static int Subtract(params int[] values)
        {
            int result = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                result -= values[i];
            }

            return result;
        }

        public static int Multiply(params int[] values)
        {
            int result = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                result *= values[i];
            }

            return result;
        }

        // this method adds up the remainder (modulus) values after every division calculation
        public static (int, int) Divide(params int[] values)
        {
            int result = values[0];
            int modulus = values[0];
            int modulusResult = 0;

            for (int i = 1; i < values.Length; i++)
            {
                result /= values[i];
                modulus %= values[i];
                modulusResult += modulus;
            }

            return (result, modulusResult);
        }

        public static string GetUserInput(string input)
        {
            Console.Write(input);

            return Console.ReadLine();
        }
    }
}
