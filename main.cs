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
        private int _seats = 0;


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
        
        public int seats
       {
            get { return _seats; }
            set { _seats = value; }
        }

      


        public int calculations(int v1,int v2,int w1,int w2,int x1,int x2,int y1,int y2,int z1,int z2)
        {
          
          if(v1 < w1 && v1 < x1 && v1 < y1 && v1 < z1)
          {
            v2 += 1;
            v1 = v1 / (v2 + 1);
            return 1;
          }
          
          else if (w1 < v1 && w1 < x1 && w1 < y1 && w1 < z1)
          { 
            w2 += 1;
            w1 = w1 / (w2 + 1);
            return 2;
          }
          
          else if (x1 < v1 && x1 < w1 && x1 < y1 && x1 < z1)
          {
            x2 += 1;
            x1 = x1 / (x2 + 1);
            return 3;
          }
          
          else if (y1 < v1 && y1 < w1 && y1 < x1 && y1 < z1)
          {
            y2 += 1;
            y1 = y1 / (y2 + 1);
            return 4;
          }
          
          else if (z1 < v1 && z1 < w1 && z1 < x1 && z1 < y1)
          {
            z2 += 1;
            z1 = z1 / (z2 + 1);
            return 5;
          }
          else 
          
          return -1;
        }

        
    }  

    class Program
    {
        public int rounds = 0;
        //public int ans = 0;

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
              rounds += 1;
              //removes the ";" from the end of the line
              
              string linemin1 = line.Remove(line.Length - 1, 1);
              
              //splits the item in the list into an array
              string[] splitline = linemin1.Split(",");
              
              //sets first two items as party name and total _votes 
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
              
              if(rounds==1)
              {
                Party p1 = new Party();
                p1.partyname = pname;
                p1.votes = pvotes;
                p1.noms = pnoms;
              }
              if(rounds==2)
              {
                Party p2 = new Party();
                p2.partyname = pname;
                p2.votes = pvotes;
                p2.noms = pnoms;
              }
              if(rounds==3)
              {
                Party p3 = new Party();
                p3.partyname = pname;
                p3.votes = pvotes;
                p3.noms = pnoms;
              }
              if(rounds==4)
              {
                Party p4 = new Party();
                p4.partyname = pname;
                p4.votes = pvotes;
                p4.noms = pnoms;
              }
              if(rounds==5)
              {
                Party p5 = new Party();
                p5.partyname = pname;
                p5.votes = pvotes;
                p5.noms = pnoms;
              }
              

            }
            for (int i = 0; i < 5; i++) 
            {
              int ans = Party.calculations(p1.votes(), p1.seats(), p2.votes(), p2.seats(), p3.votes(), p3.seats(), p4.votes(), p4.seats(), p5.votes(), p5.seats());
              if (ans == 1)
              {
                p1.votes() = p1.votes() / p1.seats +1;
                
              }
              else if (ans == 2)
              {
                p2.votes() = p2.votes() / p2.seats +1;
                
              }
              if (ans == 3)
              {
                p3.votes() = p3.votes() / p3.seats +1;
                
              }
              if (ans == 4)
              {
                p4.votes() = p4.votes() / p4.seats +1;
                
              }
              if (ans == 5)
              {
                p5.votes() = p5.votes() / p5.seats +1;
                
              }
              //Console.WriteLine(p1.votes);
              //Console.WriteLine(p2.votes);
              //Console.WriteLine(p3.votes);
             // Console.WriteLine(p4.votes);
              //Console.WriteLine(p5.votes);



            }
          }
        }
    }
//}
