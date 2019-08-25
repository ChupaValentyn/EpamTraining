using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Task3
{

    class RandomList
    {
        List<string> strlist = new List<string>();
        int counter = 0;
        public void Randstr()
        {


            char[] charstr = new char[4];
            int rands;
            Random rand = new Random();

            for (int j = 0; j < 1200; j++)
            {
                string str = "";
                for (int y = 0; y < 4; y++)
                {

                    rands = Convert.ToInt32(rand.Next(65, 91));
                    charstr[y] = Convert.ToChar(rands);
                    str = new string(charstr);
                }
                strlist.Add(str);
                counter++;

                Console.WriteLine($"{counter}:{str}");

            }
        }

        public void SearchZ()
        {

            char[] fs = new char[4];

            for (int g = 0; g < counter; g++)
            {
                fs = strlist[g].ToCharArray();
                if (fs[0] == 'Z')
                {
                    Console.WriteLine($"\nWordl with Z-start worlds:{strlist[g]}");
                    strlist.RemoveAt(g);
                    counter--;
                }
            }

            Console.WriteLine($"\nWithout Z-start worlds :{counter}");

        }

        public void SearchEqual()
        {
            for (int k = 0; k < counter; k++)
            {
                for (int j = counter - 1; j > k; j--)
                {
                    if (strlist[k] == strlist[j])
                    {

                        Console.WriteLine($"\nEqual worlds:{strlist[k]} line:{k + 1} and {strlist[j]} line:{j + 1}");
                        strlist.RemoveAt(j);
                        counter--;

                    }
                }
            }

            Console.WriteLine($"\nWithout equal worlds :{counter}");

        }

        public void PageNumber(int PageNumber)
        {
           
            if ( PageNumber * 5 < counter && PageNumber > 0)
            {

                for (int i = (PageNumber - 1) * 5; i < (PageNumber * 5); i++)
                {

                    Console.WriteLine(strlist[i]);

                }

            }
            else
            {
                Console.WriteLine("Error");

                return;
            }
        }
    }
   
}
