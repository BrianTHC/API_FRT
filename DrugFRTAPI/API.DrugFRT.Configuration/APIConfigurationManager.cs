using System;
using System.Configuration;
using API.DrugFRT.Configuration.Vendor;

namespace API.DrugFRT.Configuration
{
    public enum ApiEnvironment
    {
        None,
        Live,
        Staging,
        Test,
        Local,
        Dev
    }

    public class ApiConfigurationManager
    {
        private static ApiEnvironment Env
        {
            get
            {
                ApiEnvironment btcdEnvironment;
                Enum.TryParse(ConfigurationManager.AppSettings["Env"], true, out btcdEnvironment);
                return btcdEnvironment;
                
            }
        }
        #region ===System===
        private static SystemSetting _systemSettings;

        public static SystemSetting SystemSettings
        {
            get
            {
                if (_systemSettings != null)
                    return _systemSettings;
                _systemSettings = new SystemSetting(Env);
                return _systemSettings;
            }
        }
        #endregion

        #region ===Vendor===
        private static VendorSetting _venSettings;

        public static VendorSetting VendorSettings
        {
            get
            {
                if (_venSettings != null)
                    return _venSettings;
                _venSettings = new VendorSetting(Env);
                return _venSettings;
            }
        }
        #endregion
    }
}
