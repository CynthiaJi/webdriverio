using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTGPreProd
{
    public class logWriter3
    {
        public string path;
        public string appendText;

        public void MyString(string mytext)
        {
            path = ConfigurationManager.AppSettings["mypath"];

            if (!File.Exists(path))
            {
                // Create a file to write to. 
                string createText = DateTime.Today.ToString() + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            try
            {
                appendText = mytext + Environment.NewLine;
                File.AppendAllText(path, appendText);

            }
            catch (Exception)
            {
                
                //did not writer properly
            }
            
            
        }

        
    }
}