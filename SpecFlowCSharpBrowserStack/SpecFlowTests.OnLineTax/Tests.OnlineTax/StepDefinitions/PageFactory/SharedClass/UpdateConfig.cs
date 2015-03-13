using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


 
namespace SpecFlow.Specs.StepDefinitions.PageFactory.SharedClass
{
    class UpdateConfig
    {
        private const string ProviderKey = "Browser";

        public string newvalue
        {
            set;
            get;
        }
        public void MakeChangeToConfig(string newvalue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings[ProviderKey] == null)
            {
                config.AppSettings.Settings.Add(ProviderKey, newvalue);
            }
            else
            {
                config.AppSettings.Settings[ProviderKey].Value = newvalue;
            }
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
