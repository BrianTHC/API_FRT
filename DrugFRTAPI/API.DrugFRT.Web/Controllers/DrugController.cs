using System.Threading.Tasks;
using System.Web.Http;
using API.DrugFRT.Business.Interface;
using API.DrugFRT.Model.ResponseModels;

namespace API.DrugFRT.Web.Controllers
{
    public class DrugController : ApiController
    {
        private readonly IThuocMobileBUS _thuocMobileBus;

        public DrugController(IThuocMobileBUS thuocMobileBus)
        {
            _thuocMobileBus = thuocMobileBus;
        }

        [HttpGet]
        [Route("api/Drug/GetDuyetDatHangDetail/{intDocEntry}")]
        public async Task<DuyetDatHangDetailResponseModel> GetDuyetDatHangDetail(int? intDocEntry)
        {
            return await _thuocMobileBus.GetDuyetDatHangDetail(intDocEntry);

        }

    }
}
