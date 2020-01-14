https://leetcode.com/problems/add-digits/
 
public class Solution {
    public int AddDigits(int num) {
        while (num.ToString().Length > 1)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
           
            return num;
    }
}
