using System;
using System.Collections.Generic;
using API.DrugFRT.Configuration.Interface;

namespace API.DrugFRT.Configuration.Vendor
{
    public class FactorySetting
    {
        private readonly Dictionary<VendorSetting.Vendor, BaseSetting> _listSetting = new Dictionary<VendorSetting.Vendor, BaseSetting>();
        private ApiEnvironment Env { get; set; }
        public FactorySetting(ApiEnvironment env)
        {
            Env = env;
        }
        public BaseSetting GetVenDor(VendorSetting.Vendor enumVendor)
        {
            BaseSetting vendor;
            if (!_listSetting.ContainsKey(enumVendor))
            {
                vendor = CreateVendor(enumVendor);
                _listSetting.Add(enumVendor, vendor);
            }
            else
                vendor = _listSetting[enumVendor];
            return vendor;
        }

        public BaseSetting CreateVendor(VendorSetting.Vendor enumVendor)
        {
            switch (enumVendor)
            {
                case VendorSetting.Vendor.ThuocMobile:
                    return new ThuocMobileSetting(Env);
                default:
                    throw new NotSupportedException();
            }
        }

    }

    public class SingletonFactorySetting
    {
        private static readonly FactorySetting InstanceFactory = null;
        private SingletonFactorySetting()
        {

        }
        public static FactorySetting CreateFactory(ApiEnvironment env)
        {
            if (InstanceFactory == null)
            {
                return new FactorySetting(env);
            }
            return InstanceFactory;
        }
    }
}
