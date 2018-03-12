using System.Threading.Tasks;
using API.DrugFRT.Business.Interface;
using API.DrugFRT.Model.ResponseModels;
using API.DrugFRT.Repository.Interface;

namespace API.DrugFRT.Business.Implement
{
    public class ThuocMobileBUS : IThuocMobileBUS
    {
        private readonly IThuocMobileRepository _thuocMobileRepository;

        public ThuocMobileBUS(IThuocMobileRepository thuocMobileRepository)
        {
            _thuocMobileRepository = thuocMobileRepository;
        }

        public async Task<DuyetDatHangDetailResponseModel> GetDuyetDatHangDetail(int? intDocEntry)
        {
            return await _thuocMobileRepository.GetDuyetDatHangDetail(intDocEntry);
        }
    }
}
