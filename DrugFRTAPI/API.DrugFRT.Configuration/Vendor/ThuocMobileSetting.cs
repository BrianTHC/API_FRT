using API.DrugFRT.Configuration.Interface;

namespace API.DrugFRT.Configuration.Vendor
{
    public class ThuocMobileSetting : BaseSetting
    {
        public ThuocMobileSetting(ApiEnvironment environment) : base(environment){ }

        //setting nhung thuoc tinh chung cho tat ca cac moi truong
        
        protected override void CommonSettings()
        {
            
        }

        //Setting cho tung moi truong
        #region ===Live===
        protected override void InitLive()
        {
            CommonSettings();
            SqlCon = "";
        }
        #endregion

        #region ===Staging===
        protected override void InitStaging()
        {
            SqlCon = "";
        }
        #endregion

        #region ===Test===
        protected override void InitTest()
        {
            SqlCon = "";
        }
        #endregion

        #region ===Local===
        protected override void InitLocal()
        {
            SqlCon = "Data Source=10.96.254.35;Initial Catalog=mPharmacy;Persist Security Info=True;User ID=sa;Password=123456a@";
        }
        #endregion

        #region ===Dev===
        protected override void InitDev()
        {
            SqlCon = "Data Source=10.96.254.35;Initial Catalog=mPharmacy;Persist Security Info=True;User ID=sa;Password=123456a@";
        }
        #endregion
    }
}
