using System;

namespace ch1
{
    class ch1_ans
    {
        static void Main(string[] args) // Code runs first from this method
        {
            q2();
        }

        public static void q1()//unique alphas without any data structure
        {
            var str1 = "tessqwrt";
            int slen = str1.Length;

            for (int i = 0; i < slen - 1; i++)
            {
                //Console.WriteLine($"i value is:{str1[i]}");
                for (int j = i + 1; j < slen; j++)
                {
                    //Console.WriteLine($"j value is:{str1[j]}");
                    if (str1[i] == str1[j])
                    {
                        Console.WriteLine($"Dup found");
                        return;
                    }

                }
            }

        }

        public static void q2() //st1 is permuation of str2
        {
            var str1 = "1103";
            var str2 = "1012";
            int s1_len = str1.Length;
            int s2_len = str2.Length;

            if (s1_len != s2_len)
            {
                Console.WriteLine("not a premuation");
            }
            else
            {
                var s1_arr = new char[s1_len];
                var s2_arr = new char[s2_len];
                int i = 0;

                while (i < s1_len)
                {
                    s1_arr[i] = str1[i];
                    s2_arr[i] = str2[i];
                    i++;
                }
                Array.Sort(s1_arr);
                Array.Sort(s2_arr);
                for (int t = 0; t < s1_len; t++)
                {
                    if (s1_arr[t] != s2_arr[t])
                    {
                        Console.WriteLine($"not a permutation");
                        return;
                    }
                    if (t == s1_len - 1)
                    {
                        Console.WriteLine($"it is a permutation");
                    }
                }
            }
        }

    }
}