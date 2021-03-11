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


        public string partyname
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
    class mathsStuff
    {
      private int votes{ get; set; }
      private int toatSeats{ get; set; }
      private int curSeats{ get; set; }
      private string[] noms{ get; set; }

      public void pMaker(string _pName, int _votes, int _toatSeats, int _curSeats, string[] _noms)
      {
        pName=_pname;
        votes=_votes;
        toatSeats=_toatSeats;
        curSeats=_curSeats;
        noms=_noms;

      }

      }
    }
    class Program
    {
      public int curRound = 1;

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
              
              //removes the ";" from the end of the line
              
              string linemin1 = line.Remove(line.Length - 1, 1);
              
              //splits the item in the list into an array
              string[] splitline = linemin1.Split(",");
              
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
              
              // make pname the _partyname 
              //make pvotes the _votes
              //make pnoms the _nom 
              
              //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
              //!!!!!!!HUGH create new objects here!!!!!!!!
              //!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!-!
              if(curRounds=1)
              {
                pMaker p1 = new pMaker(pname,pvotes,rounds, curRound, pnoms);
              }
              if(curRounds=2)
              {
                pMaker p2 = new pMaker(pname,pvotes,rounds, curRound, pnoms);
              }
              if(curRounds=3)
              {
                pMaker p3 = new pMaker(pname,pvotes,rounds, curRound, pnoms);
              }
              if(curRounds=4)
              {
                pMaker p4 = new pMaker(pname,pvotes,rounds, curRound, pnoms);
              }
              if(curRounds=5)
              {
                pMaker p5 = new pMaker(pname,pvotes,rounds, curRound, pnoms);
              }
              

            }

        if(p1.votes<p2.votes && p1.votes<p3.votes && p1.votes<p4.votes && p1.votes<p5.votes)
        {
          p1.curSeats += 1;
          p1.votes = p1.votes / (p1.curSeats + 1);
        }
        else if(p2.votes<p1.votes && p2.votes<p3.votes && p2.votes<p4.votes && p2.votes<p5.votes)
        {
          p2.curSeats += 1;
          p2.votes = p1.votes / (p2.curSeats + 1);
        }
        else if(p3.votes<p1.votes && p3.votes<p2.votes && p3.votes<p4.votes && p3.votes<p5.votes){
          p3.curSeats += 1;
          p3.votes = p1.votes / (p3.curSeats + 1);
        }
        else if(p4.votes<p1.votes && p4.votes<p2.votes && p4.votes<p3.votes && p4.votes<p5.votes){
          p4.curSeats += 1;
          p4.votes = p4.votes / (p4.curSeats + 1);
        }
        else if(p5.votes<p1.votes && p5.votes<p2.votes && p5.votes<p3.votes && p5.votes<p4.votes){
          p5.curSeats += 1;
          p5.votes = p5.votes / (p5.curSeats + 1);
        }
        
    }
}
