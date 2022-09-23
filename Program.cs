using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4 };

            OneMethod(lst);
            SecondMethod(lst);
            var ooo = new Program().yieldMethod(new List<int>() { 1, 2, 4, 5 }).SelectMany(s => s);
        }

        private static void SecondMethod(List<int> lst)
        {
            
        }

        private static void OneMethod(List<int> lst)
        {
            lst.Add(5);
        }

        private IEnumerable<byte[]> yieldMethod(IEnumerable<int> enableModuleTypes)
        {
            foreach (var module in enableModuleTypes)
            {
                yield return BitConverter.GetBytes((int)module);
            }
        }

        private byte[] getBytesArray(IEnumerable<int> enableModuleTypes)
        {
            var bytes = new List<byte>();

            foreach (var module in enableModuleTypes)
            {
                bytes.AddRange(BitConverter.GetBytes((int)module));
            }

            return bytes.ToArray();
        }
    }
}
