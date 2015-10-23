using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dos2unix
{
    class Program
    {
        public static void Main(string[] args)
        {
            foreach (var item in args)
            {
                try
                {
                    FileConverter.Dos2Unix(item);
                    FileConverter.RemoveBOM(item);
                    Console.WriteLine(string.Format("{0} successfully converted", item));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error on converting {0}", item));
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
