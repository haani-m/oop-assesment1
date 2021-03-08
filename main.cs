using System;
using System.IO;
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
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("inputs.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
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
