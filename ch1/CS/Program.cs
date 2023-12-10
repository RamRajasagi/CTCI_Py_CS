using System;

namespace ch1
{
    class ch1_ans
    {
        static void Main(string[] args) // Code runs first from this method
        {
            q1();
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
    }


}