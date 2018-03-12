namespace API.DrugFRT.Configuration.Vendor
{
    public class VendorSetting
    {
        //Setting cho cac Vendor khac nhau
        private FactorySetting FactoryInstance { get; set; }
        public VendorSetting() : this(ApiEnvironment.Local) { }

        public VendorSetting(ApiEnvironment environment)
        {
            FactoryInstance = SingletonFactorySetting.CreateFactory(environment);
        }

        #region ===Vendors===
        public ThuocMobileSetting ThuocMobileSetting => (ThuocMobileSetting)FactoryInstance.CreateVendor(Vendor.ThuocMobile);
        #endregion
        public enum Vendor
        {
            ThuocMobile = 1
        }
    }
}
