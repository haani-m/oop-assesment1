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

            try
            {
                
                StreamReader fileread = new StreamReader("inputs.txt");
                
                fileline = fileread.ReadLine();
                
                while (fileline != null)
                {
                    
                    Console.WriteLine(fileline);
                    
                    fileline = fileread.ReadLine();
                }
                //close the file
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
