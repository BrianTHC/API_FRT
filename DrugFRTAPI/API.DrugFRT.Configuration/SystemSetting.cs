using System.Collections.Generic;
using API.DrugFRT.Configuration.Interface;

namespace API.DrugFRT.Configuration
{
    public class SystemSetting : BaseSetting
    {
        public SystemSetting(ApiEnvironment environment) : base(environment)
        {
        }

        public enum StatusCode
        {
            OK = 0,
            WRONGVALUE = -1,
            INTERNALSERVERERROR = -2,
            TIMEOUTACCESSDATA = -3,
            SQLERROR = -4,
            NOTFOUND = -5,
            UPLOADCOMPLETED = -6,
            UPLOADFILEFAIL = -7,
            NULLOREMPTY = -8,
            KEYSOKYHIEU = -9,
            INVALIDKEY = -10,
            UNAUTHORIZE = -11,
            NOTFOUNDTOKEN = -12,
            DELETEFILEFAIL = -13,
            CHANGEPASSWRONG = -14,
            WRONGUSERORPASSWORD = -15,
            VALIDATEWRONGEMAIL = -16,
            VALIDATEWRONGIDCARD = -17,
            VALIDATEWRONGPHONE = -18,
            VALIDATEWRONGUSERNAME = -19,
            WRONGSENDSMS = -20,
            WRONGSENDEMAIL = -21,
            ADDUSERWRONG = -22,
            NOTFOUNDUSERNAME = -23,
            NOTFOUNDCODEVERIFY = -24,
            USERISACTIVED = -25,
            CODEVERIFYWRONG = -26,
            VERIFYERROR = -27,
            PASSWORDOLDWRONG = -28,
            USERNOTACTIVE = -29,
            PASSWORDNOTVALID = -30,
            INFORESETWRONG = -32,
            SENDEMAILORSMSWRONG = -33,
            RESETPASSFAILED = -34,
            PHONEEMPTY = -35,
            EMAILEMPTY = -36,
            REGISTERSUCCESS = 1,
            SUCCESSVERIFY = 2
        }

        public Dictionary<StatusCode, string> DictionaryError { get; set; }
        public string PasswordDecrypt { get; set; }
        public int ExpirationTimeByMinutes { get; set; }





        protected override void CommonSettings()
        {
            DictionaryError = new Dictionary<StatusCode, string>
            {
                {StatusCode.OK, "Thanh Cong"},
                {StatusCode.INTERNALSERVERERROR, "Loi Server"},
                {StatusCode.WRONGVALUE, "Gia tri Sai"},
                {StatusCode.TIMEOUTACCESSDATA, "Het Thoi Gian Ket Noi DataBase"},
                {StatusCode.SQLERROR, "Cau Truy Van Loi"},
                {StatusCode.NOTFOUND, "Khong Tim Thay"},
                {StatusCode.UPLOADCOMPLETED, "UpLoad File Thanh Cong"},
                {StatusCode.UPLOADFILEFAIL, "UpLoad File That Bai"},
                {StatusCode.NULLOREMPTY, "Thong tin bi rong"},
                {StatusCode.KEYSOKYHIEU, "Chua dinh nghia UserId cho Don thu voi suffix so ki hieu"},
                {StatusCode.UNAUTHORIZE, "UnAuthorize"},
                {StatusCode.NOTFOUNDTOKEN, "Not Found Token"},
                {StatusCode.CHANGEPASSWRONG, "Doi Password xay ra loi"},
                {StatusCode.WRONGUSERORPASSWORD, "Sai UerName hoac PassWord"},
                {StatusCode.VALIDATEWRONGEMAIL, "Email Da Ton Tai"},
                {StatusCode.VALIDATEWRONGIDCARD, "CMND Da Ton Tai"},
                {StatusCode.VALIDATEWRONGPHONE, "So Dien Thoai Da Ton Tai"},
                {StatusCode.VALIDATEWRONGUSERNAME, "UserName Da Ton Tai"},
                {StatusCode.WRONGSENDSMS, "Send SMS Xay Ra Loi"},
                {StatusCode.WRONGSENDEMAIL, "Send Email Xay Ra Loi"},
                {StatusCode.ADDUSERWRONG, "Them User Xay Ra Loi"},
                {StatusCode.REGISTERSUCCESS, "Dang Ky Tai Khoan Thanh Cong"},
                {StatusCode.NOTFOUNDUSERNAME, "Khong Tim Thay UserName"},
                {StatusCode.NOTFOUNDCODEVERIFY, "Khong Co Ma Xac Thuc"},
                {StatusCode.USERISACTIVED, "User Da Duoc Active"},
                {StatusCode.CODEVERIFYWRONG, "Ma Xac Thuc Sao"},
                {StatusCode.PASSWORDOLDWRONG, "PassWord Thuc Cu Khong Dung"},
                {StatusCode.VERIFYERROR, "Xac Thuc Loi"},
                {StatusCode.SUCCESSVERIFY, "Xac Thuc Thanh Cong"},
                {StatusCode.USERNOTACTIVE, "Tai Khoan Chua Kich Hoat"},
                {StatusCode.PASSWORDNOTVALID, "PassWord Khong Hop Le, Lon Hon 8 Ky Tu Bao Gom Chu Va So"},
                {StatusCode.INFORESETWRONG, "Sai thong tin Reset"},
                {StatusCode.SENDEMAILORSMSWRONG, "Gui Mail hoac SMS that bai"},
                {StatusCode.RESETPASSFAILED, "Reset Mat Khau that bai"},
                {StatusCode.EMAILEMPTY, "Email Khong Duoc De Trong"},
                {StatusCode.PHONEEMPTY, "So Dien Thoai Khong Duoc De Trong"},


            };
        }

        #region ===Live Init===

        protected override void InitLive()
        {
          
            SqlCon = "";
        }
        #endregion

        #region ===Staging Init===

        protected override void InitStaging()
        {
          
            SqlCon = "";
        }
        #endregion

        #region ===Test Init===
        protected override void InitTest()
        {

            SqlCon = "";
        }
        #endregion

        #region ===Local Init===
        protected override void InitLocal()
        {
           
            SqlCon = "";
        }
        #endregion

        #region ===Dev Init===
        protected override void InitDev()
        {
           SqlCon = "";
        }

       
        #endregion


    }
}
