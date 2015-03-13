using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.IO;
using System.Threading.Tasks;
using System.Configuration;


namespace OTGPreProd
{
    public class logWriter
    {
        public string path;
        public TextWriter tw;
         
    }
    public void logStartWrite(string mytext)
    {
        path = ConfigurationManager.AppSettings["mypath"];
      
        if (!File.Exists(path))
        {File.Create(path);}
        tw = new StreamWriter(path);
        tw.WriteLine("The next line!");
        tw.Close(); 
     
    }

    
}
