using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAD.DataAccess
{
    internal class FileReader
    {
        public string[] ReadFileByName(string file_name)
        {
            try
            {
                string[] lines = File.ReadAllLines(file_name);
                return lines;
            }
            catch(Exception eror) {
                Console.WriteLine("You should have a file named \"10m.txt\" on your desktop.");
                return ["1"];
               
            }
        }
    }
}
