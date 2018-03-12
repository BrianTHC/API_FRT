using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;
using API.DrugFRT.Configuration;
using NLog;

namespace API.DrugFRT.Ultilities.Extention
{
    public class ApiFilterAttributeException : ExceptionFilterAttribute
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public override async Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            if (actionExecutedContext.Exception is TimeoutException)
            {
                actionExecutedContext.Response = await CreateReponseException(actionExecutedContext, SystemSetting.StatusCode.TIMEOUTACCESSDATA);
            }
            else if (actionExecutedContext.Exception is SqlException)
            {
                actionExecutedContext.Response = await CreateReponseException(actionExecutedContext, SystemSetting.StatusCode.SQLERROR);
            }
            else if (actionExecutedContext.Exception is HttpResponseException)
            {
                actionExecutedContext.Response = await CreateReponseException(actionExecutedContext, SystemSetting.StatusCode.WRONGVALUE);
            }
            else
            {
                actionExecutedContext.Response = await CreateReponseException(actionExecutedContext, SystemSetting.StatusCode.INTERNALSERVERERROR);
            }
        }


        private static async Task<HttpResponseMessage> CreateReponseException(HttpActionExecutedContext actionExecutedContext, SystemSetting.StatusCode errorStatus)
        {
            string data;
            using (var stream = actionExecutedContext.Request.Content.ReadAsStreamAsync().Result)
            {
                if (stream.CanSeek)
                {
                    stream.Position = 0;
                }
                data = await actionExecutedContext.Request.Content.ReadAsStringAsync();
            }

            Logger.Log(LogLevel.Error, $"URL: {actionExecutedContext.Request.RequestUri}; RequestBody: {data}; Exception: {actionExecutedContext.Exception}");


            return actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, Common.GetMessageError(errorStatus));
        }
    }
}
