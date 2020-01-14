https://leetcode.com/problems/replace-words/

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <set>
#include <map>
#include <algorithm>
#include <functional> 
#include <cctype>
#include <locale>
#include <string>


using namespace std;

std::string& ltrim(std::string& str, const std::string& chars = "\t\n\v\f\r ")
{
    str.erase(0, str.find_first_not_of(chars));
    return str;
}
 
std::string& rtrim(std::string& str, const std::string& chars = "\t\n\v\f\r ")
{
    str.erase(str.find_last_not_of(chars) + 1);
    return str;
}
 
std::string& trim(std::string& str, const std::string& chars = "\t\n\v\f\r ")
{
    return ltrim(rtrim(str, chars), chars);
}

string replaceWords(vector<string>& dict, string sentence) {
   
    set<string> hash; 
    for(int i =0; i<dict.size(); i++) {
    	hash.insert(dict[i]);
	}
    
    string ans = "";
    string concat = "";
    for(int i =0; i<sentence.length(); i++)
    {
        if (sentence[i] != ' ')
        {
            concat += sentence[i];

            if(hash.find(concat) != hash.end())
            {
                ans += concat + " ";
                concat = "";
                while (i < sentence.length() && sentence[i] != ' ') i++;
            }
        }
        else
        {
            ans += concat + " ";
            concat = "";
        }
    }

    ans += concat + " ";
    concat = "";
    
   	
   	return trim(ans);
        
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
  
  
    

    
    return 0;
}
