using System.Threading.Tasks;
using API.DrugFRT.Model.ResponseModels;

namespace API.DrugFRT.Repository.Interface
{
    public interface IThuocMobileRepository
    {
        Task<DuyetDatHangDetailResponseModel> GetDuyetDatHangDetail(int? intDocEntry);
    }
}
