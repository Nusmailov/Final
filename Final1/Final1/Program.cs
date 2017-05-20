using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final1
{
    class Program
    {
        static bool check(int x)
        {
            if (x == 2 || x == 1)
            {
                return true;
            }
            else {
                for (int i = 3; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            DirectoryInfo Finfo = new DirectoryInfo(@"G:\.Trash-1000\KBTU\2semestr\Final\Final1\Final1\bin\Debug");
            int cnt = 0;
           // string s = Console.ReadLine();
            for (int i = 0; i < Finfo.GetFileSystemInfos().Length; i++)
            {
                if(Finfo.GetFileSystemInfos()[i].Name.Contains(".txt"))
                {
                    Console.Write(Finfo.GetFileSystemInfos()[i].Name);
                    string s = Finfo.GetFileSystemInfos()[i].Name;
                    StreamReader sr = new StreamReader(s);
                    string p = sr.ReadLine();
                    string[] t = p.Split();
                    int[] arr = new int[t.Length];
                    for (int j = 0; j < t.Length; j++)
                    {
                        arr[j] = int.Parse(t[j]);
                        if(check(arr[j]))
                        {
                        Console.Write(" "+arr[j] + " ");
                        }
                    }
                    Console.WriteLine();
                        cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("Not Found");
            }
            Console.ReadKey();
            //Console.WriteLine);

        }
    }
}
