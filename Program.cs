namespace golrang01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "110"; 
            string[] zero = { "***", "*.*", "***" };
            string[] one = { ".*.", ".*.", ".*." }; 
            string[] result = new string[3];
            foreach (char digit in input)
            {
                string[] representation = digit == '0' ? zero : one;
                for (int i = 0; i < 3; i++) 
                { if (result[i] == null)
                        result[i] = representation[i];
                    else result[i] += representation[i];
                }
            } foreach (string line in result)
            { 
                Console.WriteLine(line);
            }
        }

        #region
        //    static void Main(string[] args)
        //    {
        //        Console.Write(inputO());
        //        Console.Write(inputZ()); 
        //    }
        //    static string inputZ()
        //    {
        //        return "***\n *.*\n ***";
        //    }

        //    static string inputO()
        //    {
        //        return ".*. \n.*.  \n.*.";
        //    }
        #endregion
    }
}
