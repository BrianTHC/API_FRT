using System.Threading.Tasks;
using API.DrugFRT.Model.ResponseModels;

namespace API.DrugFRT.Business.Interface
{
    public interface IThuocMobileBUS
    {
        Task<DuyetDatHangDetailResponseModel> GetDuyetDatHangDetail(int? intDocEntry);
    }
}
