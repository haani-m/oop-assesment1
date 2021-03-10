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
    }  
    class Program
    {

        static void Main(string[] args)

        {
          //MAKE IT SO EVERY LINE IS ADDED AS AN ELEMENT TO A NEW LIST
          //FROM THERE INITIALISE NEW INTANCES OF THE PARTY CLASS PER EACH ELEMENT IN
          //THE LIST, BESIDES THE FIRST 3
          //
            //opens file, turns each line into an item in a list
            string filepath = "inputs.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            
            //writes info to theconsole
            foreach (string line in lines)
            {
              Console.WriteLine(line);
            }

            //sets general info for election
            string title = lines[0];
            int rounds = Int32.Parse(lines[1]);
            int totalvotes = Int32.Parse(lines[2]);

            //removes that info from the list
            lines.RemoveRange(0,3);

            //goes through each item in the list, turning it into an array 
            foreach(string line in lines)
            {
              //removes the ";" from the end
              linemin1 = line.Remove(line.Length - 1, 1);
              //splits the item in the list into an array
              string[] splitline = linmin1.Split(",");
              
              //sets first two items as party name and total votes 
              string pname = splitline[0];
              int pvotes = Int32.Parse(splitline[1]);
              
              //converts array to list in order to remove the first two items, 
              //so we are left with just the nominees
              List<string> tempnoms = new List<string>();
              tempnoms = splitline.ToList();
              tempnoms.RemoveRange(0,2);

              //converts list back to array so it is compatible with the class
              string[] pnoms = tempnoms.ToArray();
              
              //outputs for testing TO BE REMOVED !!!!!!!!!!!
              Console.WriteLine(pname);
              Console.WriteLine(pvotes);
              foreach (string nomin in pnoms)
              {
                Console.WriteLine(nomin);
              }


              //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
              //!!!!!!!HUGH create new objects here!!!!!!!!
              //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
              

            }
            
            
            //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
            //OLD CODE FOR SAFE KEEPING DELETE BEFORE SUBMISSION
            //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
            //String fileline;
            //String partyline;
            //try
           // {
                
           //     StreamReader fileread = new StreamReader("inputs.txt");

                
                //title = fileread.Readline();
                //Console.WriteLine(title);
                //rounds = fileread.Readline();
                //totalvotes = fileread.Readline();

           //     partyline = fileread.ReadLine();
        
            //    while (partyline != null)
           //     {
                
                    //var splitline = partyline.Split(",");
                    //Console.WriteLine(splitline);
                    //Console.WriteLine(partyline);
                    //partyline = fileread.ReadLine();
               // }
                
                //fileread.Close();
                //Console.ReadLine();
            //}
            //catch (Exception e)
            //{
                //Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
                //Console.WriteLine("Executing finally block.");
            //}


        }
    }
}
