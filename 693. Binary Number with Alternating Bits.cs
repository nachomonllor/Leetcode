public bool HasAlternatingBits(int n)
        {
            return !((Convert.ToString(n, 2).Contains("11"))
            || (Convert.ToString(n, 2).Contains("00")));
        }