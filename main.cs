using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace dhondt_project
{
    class Party
    {
        private string _partyname;
        private int _votes;
        private string[] _noms;


        public  string partyname
        {
            get { return _partyname; }
            set { _partyname = value; }
        }

        public int votes
        {
            get { return _votes; }
            set { _votes = value; }
        }

        public string[] noms
        {
            get { return _noms; }
            set { _noms = value; }
        }
        
        static void Main(string[] args)

        {
          //MAKE IT SO EVERY LINE IS ADDED AS AN ELEMENT TO A NEW LIST
          //FROM THERE INITIALISE NEW INTANCES OF THE PARTY CLASS PER EACH ELEMENT IN
          //THE LIST, BESIDES THE FIRST 3
          //
            string filepath = "inputs.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
           // foreach (String line in lines)
            //{
            //  Console.WriteLine(line);
            //}

            //var splitline = partyline.Split(",");
            //Console.WriteLine(splitline);
            string title = lines[0];
            int rounds = lines[1].ToInt32;
            int totalvotes = lines[2].ToInt32;

            String fileline;
            String partyline;
            try
            {
                
                StreamReader fileread = new StreamReader("inputs.txt");

                
                //title = fileread.Readline();
                //Console.WriteLine(title);
                //rounds = fileread.Readline();
                //totalvotes = fileread.Readline();

                partyline = fileread.ReadLine();
        
                while (partyline != null)
                {
                
                    //var splitline = partyline.Split(",");
                    //Console.WriteLine(splitline);
                    Console.WriteLine(partyline);
                    partyline = fileread.ReadLine();
                }
                
                fileread.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }


        }
    }
}
