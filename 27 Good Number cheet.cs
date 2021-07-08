using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split();
            int n = Convert.ToInt32( st[0]);
            int k= Convert.ToInt32( st[1]);
            int cout = 0;
            for (int i = 0; i<n;i++ )
            {
                string t =Console.ReadLine();
                char[] t2 = t.ToCharArray();
                int co = 0;
                for (int j = 0; j <= k; j++)
                {
                    
                    for (int b = 0; b < t2.Length; b++)
                    {
                        if (j == Convert.ToInt32(t2[b].ToString())){
                            co++;
                            break;
                        }
                    }
                  
                }
                if (co == k + 1)
                {
                    cout++;
                }
                


            }

            Console.WriteLine(cout);
        }
    }
}
