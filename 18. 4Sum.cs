using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static Dictionary<int, int> copiarDiccionario(Dictionary<int, int> origen)
        {
            Dictionary<int, int> destino = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> kvp in origen)
            {
                destino.Add(kvp.Key, kvp.Value);
            }
            return destino;
        }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(nums[i]))
                {
                    hash[nums[i]]++;
                }
                else
                {
                    hash[nums[i]] = 1;
                }

            }
            Dictionary<int, int> temp = new Dictionary<int,int> ();
            HashSet<string> sinrep = new HashSet<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (hash.ContainsKey(target - (nums[i] + nums[j] + nums[k])) && hash[target - (nums[i] + nums[j] + nums[k])] > 0  )
                        {
                            temp = copiarDiccionario(hash);
                            List<int> aux = new List<int>();
                            if (hash[nums[i]] > 0)
                            {
                                aux.Add(nums[i]);
                                hash[nums[i]]--;
                            }

                            if (hash[nums[j]] > 0)
                            {
                                aux.Add(nums[j]);
                                hash[nums[j]]--;
                            }

                            if (hash[nums[k]] > 0)
                            {
                                aux.Add(nums[k]);
                                hash[nums[k]]--;
                            }

                            if (hash[target - (nums[i] + nums[j] + nums[k])] > 0)
                            {
                                aux.Add(target - (nums[i] + nums[j] + nums[k]));
                                hash[target - (nums[i] + nums[j] + nums[k])]--;
                            }

                            if (aux.Count == 4)
                            {
                                aux.Sort();
                                //IList<int> lista = new List<int>();
                                //lista = aux;
                                //ans.Add(lista);
                                sinrep.Add(aux[0] + " " + aux[1] + " " + aux[2] + " " + aux[3]);
                              
                            }
                            //hash[nums[i]]++;
                            //hash[nums[j]]++;
                            //hash[nums[k]]++;
                            //hash[target - (nums[i] + nums[j] + nums[k])]++;
                            //hash = temp;
                            hash = copiarDiccionario(temp);
                        }

                    }
                }

            }

            IList<IList<int>> ans = new List<IList<int>>();
            foreach (string item in sinrep)
            {
                //Console.WriteLine(item);
                IList<int> aux = Array.ConvertAll(item.Split(' '), e => int.Parse(e)).ToList();
                ans.Add(aux);
            }


            
            return ans;

        }



        static void Main(string[] args)
        {

            int[] nums = {1, 0, -1, 0, -2, 2};
            int target = 0;

            IList<IList<int>> lista = FourSum(nums, target);


            //foreach (List<int> item in lista)
            //{
            //    foreach (int num in item)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //}

           


            Console.ReadLine();
        }
    }
}
