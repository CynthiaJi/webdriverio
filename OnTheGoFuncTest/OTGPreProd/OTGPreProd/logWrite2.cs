using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTGPreProd
{
    public class logWriter2
    {
        public string path;
        public TextWriter tw;

        public void MyString(string mytext)
        {
            path = ConfigurationManager.AppSettings["mypath"];

            //if (!File.Exists(path)){ File.Create(path); }
            tw = new StreamWriter(path,true);
            try
            {
                //tw.WriteLine(DateTime.Today.ToString());
                
                tw.WriteLine(mytext);
                //File.AppendAllText
            }
            catch (Exception)
            {
                
                //did not writer properly
            }
            
            
            tw.Close(); 
        }

        
    }
}