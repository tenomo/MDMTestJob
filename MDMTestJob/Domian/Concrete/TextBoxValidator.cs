using System;
using System.Text.RegularExpressions;

namespace MDMTestJob.Domian.Concrete
{ 
 public  static class  TextBoxValidator 
    {
        public static bool ValidityCheck(string text)
        { 

            try
            {
                return Regex.IsMatch(text, @"^[a-zA-Яа-я()\\\-/]*$", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
             
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

           
        }
    }
}
