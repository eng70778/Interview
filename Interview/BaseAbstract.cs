using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public abstract class BaseAbstract
    {
        public string LoadCSV(string filePath = null)
        {
            filePath = filePath ?? AppDomain.CurrentDomain.BaseDirectory + "\\input.csv";
            return File.ReadAllText(filePath);
        }

        public bool WriteCSV(string input, string filePath = null)
        {
            filePath = filePath ?? AppDomain.CurrentDomain.BaseDirectory + "\\output.csv";

            try
            {
                File.WriteAllText(filePath, input);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return false;
            }
        }

    }

    public interface IFindMissingNumber
    {
        int FindMissingNumber(string input);

        string ParseResultString(int missingNumber, string originalString);
    }

}
