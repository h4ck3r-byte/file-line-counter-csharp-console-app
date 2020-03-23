using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace line_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\Users\root\Desktop\rockyou.txt");
                int linecount = 0;
                while (reader.ReadLine() != null)
                {
                    linecount++;
                }

                Console.WriteLine("Line count: {0}", linecount.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            

        }
    }
}
