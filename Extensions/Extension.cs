using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal static class Extension
    {
        public static bool customContains(this string write, string read)
        {


            if (read.Equals(write) || read.Equals(write.ToLower()))
            {
                return true;
            }

            string[] arr = write.Split();

            foreach (string word in arr)
            {
               if (word == read)
                {
                    return true;
                    break;
                }
                    else if (read.Equals(word))
                    {
                        return true;
                    }
                else if (read.Equals(word.ToLower()))
                {
                    return true;
                }
                else if (word.EndsWith(read))
                {
                    return true;
                }
                else if (word.StartsWith(read))
                    {
                        return true;
                    }
                
                else if (read.Trim().EndsWith(word))
                    {
                        return true;
                    }
                else if (read.Trim().StartsWith(word))
                {
                    return true;
                }

            }         
         
            return false;
        }
    }
}
