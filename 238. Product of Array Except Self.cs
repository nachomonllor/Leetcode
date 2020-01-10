public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         List<int> ans=new List<int>();
            
            // write your code here
            int[] izquierda = new int[nums.Length];
            izquierda[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                izquierda[i] = izquierda[i - 1] * nums[i];
            }
            int[] derecha = new int[nums.Length];

            derecha[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                derecha[i] = derecha[i + 1] * nums[i];
            }

             

            for (int i = 0; i < nums.Length; i++)
            {

                int prod = 1;
                if (i - 1 >= 0) prod *= izquierda[i - 1];
                if (i + 1 < nums.Length) prod *= derecha[i + 1];
                ans.Add(prod);
            }

            return ans.ToArray();
    }
}