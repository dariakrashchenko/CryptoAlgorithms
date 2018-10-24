using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
namespace Encry
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");
            foreach(var a in salt)
            {
                System.Console.WriteLine(a);
            }
        }
    }
}
