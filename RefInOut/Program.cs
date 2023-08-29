namespace RefInOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input string:");
            string value = Console.ReadLine();

            if(CustomTryParse(value,out int result))
            {
                Console.WriteLine("Parsed successfully: " + result);
            }
            else
            {
                Console.WriteLine("Parsed failed: " + result);
            }
            
        }
        public static bool CustomTryParse(string value,out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(value);
                return true;
            }
            catch 
            { 
                return false; 
            }
        }
    }
}