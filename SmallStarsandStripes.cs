using System;

namespace Task_C_minimal
{
    class Program
    {
        /// <summary>
        /// this code takes a user input then displays a block of stars and lines
        /// 
        /// the amount of stars and lines in each row is equal to the amount input from the user
        /// the amount of rows is also equal
        /// </summary>
        /// <param name="a">amount of rows and stars</param>
        static void Main(String[] a)
        {
            try
            {
                int v=int.Parse(a[0]); //converts user input to int

                //creates a Char array with the symbols needed
                //then creates a string with the symbol repeating as many times as selected changing every 3 rows
                //it then writes the string to the console with a newline added 
                //it then repeats, drawing each line
                for(int i=0;i<v;i++){Console.Write(new String(new Char[]{'*','*','='}[i%3],v)+"\n");}
            }
            catch (Exception e) { Console.Write(e); }
        }
    }
}
