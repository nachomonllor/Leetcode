https://leetcode.com/problems/shortest-completing-word/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GFG
{

    public static string ShortestCompletingWord(string licensePlate, string[] words)
    {

        char[] hashLicense = new char[26];
        licensePlate = licensePlate.ToLower();

        //string licen = "";
        for (int i = 0; i < licensePlate.Length; i++)
        {
            if (licensePlate[i] >= 'a' && licensePlate[i] <= 'z')
            {
                hashLicense[licensePlate[i]-'a']++;
            }
        }

        string candidato = "";
        bool flag = false;
        for (int i = 0; i < words.Length; i++)
        {
            char[] hashWord = new char[26];
            int j = 0;
            for ( j = 0; j < words[i].Length; j++)
            {
                hashWord[words[i][j]-'a']++;
            }
            
            for ( j = 0; j < 26; j++)
            {
                if(  hashLicense[j] > hashWord[j])
                {
                    break;
                }
            }
            if(j >= 26)
            {
                if(!flag )
                {
                    candidato = words[i];
                    flag = true;
                }
                //return words[i];
                //candidato = words[i];

                if(flag && words[i].Length < candidato.Length)
                {
                    candidato = words[i];
                }
                
            }
        }

        return candidato;
    }

    // Driver Code 
    public static void Main(string[] args)
    {

        //string licensePlate = "1s3 456";
        //string[] words = { "looks", "pest", "stew", "show" };

        //string licensePlate = "1s3 PSt";
        //string[] words = { "step", "steps", "stripe", "stepple" };

        //string Output = "steps";

        string licensePlate = "1s3 456";
        string[] words = { "looks", "pest", "stew", "show" };

        Console.WriteLine(ShortestCompletingWord(licensePlate, words));

        //Console.WriteLine('z' - 'a' + 1);

        Console.ReadLine();
    }

}
