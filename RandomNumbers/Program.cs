using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        const int MAX_SIZE = 10000;
        static void Main(string[] args)
        {
            int[] numArray = new int[MAX_SIZE];
            int x = 0;
            Random r = new Random();
            string time = DateTime.Now.ToString("yyyyMMddHHmmss");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\numbers" + time + ".txt";
            for (int i = 0; i < MAX_SIZE; i++)
            {
                while (true)
                {
                    x = r.Next(0, 10000);
                    if (numArray[x] == 0)
                    {
                        numArray[x] = i + 1;
                        break;
                    }
                }
            }
            using (StreamWriter sr = new StreamWriter(Path.Combine(path)))
            {
                foreach (int m in numArray)
                    sr.WriteLine(m);
            }
        }
    }
}
