namespace DSA_Revisted
{
    internal static class Sum_N_Natural_Numbers
    {
        public static int FindNNaturalNumbers(int n)
        {

            //O(N) Approach
            //if (n == 0) return 0;
            //int res = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    res += i;
            //}
            //return res;

            // Most Efficient O(1) 
            return n * (n + 1) / 2;

        }

    }
}




