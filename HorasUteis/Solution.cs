using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasUteis
{
    public class Solution
    {

        public int Solucao(string s)
        {
            String[] list = s.Split(' ');
            List<int> inteiros = new List<int>();
            try
            {
                foreach (string x in list)
                {
                    if (x.ToUpper() == "DUP")
                    {
                        inteiros.Add(inteiros.ElementAt(inteiros.Count - 1));
                    }
                    else if (x.ToUpper() == "POP")
                    {
                        inteiros.Remove(inteiros.ElementAt(inteiros.Count - 1));
                    }
                    else if (x.ToUpper() == "+")
                    {
                        int numOne = inteiros.ElementAt(inteiros.Count - 1);
                        inteiros.Remove(inteiros.ElementAt(inteiros.Count - 1));
                        int numTwo = inteiros.ElementAt(inteiros.Count - 1);
                        inteiros.Remove(inteiros.ElementAt(inteiros.Count - 1));
                        inteiros.Add(numOne + numTwo);
                    }
                    else if (x.ToUpper() == "-")
                    {
                        int numOne = inteiros.ElementAt(inteiros.Count - 1);
                        inteiros.Remove(inteiros.ElementAt(inteiros.Count - 1));
                        int numTwo = inteiros.ElementAt(inteiros.Count - 1);
                        inteiros.Remove(inteiros.ElementAt(inteiros.Count - 1));
                        inteiros.Add(numOne - numTwo);

                    }
                    else
                    {
                        inteiros.Add(int.Parse(x));
                    }
                }
                return inteiros.ElementAt(inteiros.Count - 1);
            }
            catch (Exception e)
            {
                //System.out.println(e.getMessage().toString());
                return -1;
            }
        }
    }
}
