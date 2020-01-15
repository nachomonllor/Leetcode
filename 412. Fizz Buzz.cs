 public class Solution
        {
            public IList<string> FizzBuzz(int n)
            {
                List<string> lista = new List<string>();
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        lista.Add("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        lista.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        lista.Add("Buzz");
                    }
                    else
                    {
                        lista.Add(i + "");
                    }
                }
                return lista;
            }
        }