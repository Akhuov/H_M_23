using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_M_23
{
    internal static class StaticClass
    {

        static public int? CtOf;
        public static void CreateNewTxtFiles(int n)
        {
            CtOf = n;
            for (int i = 1; i <= n; i++)
            {
                var path = $"D:\\Study\\.Net(Najot)\\C#\\H_M_23\\TxtFiles\\{i}.txt";
                FileStream f = new FileStream(path, FileMode.Create);
                f.Close();
            }
        }



        public static void AddTextToTxtFiles(string s)
        {
            for (int i = 1; i <= CtOf; i++)
            {
                var r = new StreamWriter($"D:\\Study\\.Net(Najot)\\C#\\H_M_23\\TxtFiles\\{i}.txt", false, Encoding.UTF8);
                r.WriteLine(s);
                r.Close();
            }
        }




    }
}
