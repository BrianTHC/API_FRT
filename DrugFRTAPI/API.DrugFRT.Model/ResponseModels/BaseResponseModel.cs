using API.DrugFRT.Configuration;

namespace API.DrugFRT.Model.ResponseModels
{
    public class BaseResponseModel
    {
        public string Message { get; set; }

        public SystemSetting.StatusCode StatusCode { get; set; }
        public BaseResponseModel()
        {
            StatusCode = SystemSetting.StatusCode.OK;
        }
        public void SetStatusCodeAndMessage(SystemSetting.StatusCode statusCode)
        {
            StatusCode = statusCode;
            Message = ApiConfigurationManager.SystemSettings.DictionaryError[statusCode];
        }
    }
}
