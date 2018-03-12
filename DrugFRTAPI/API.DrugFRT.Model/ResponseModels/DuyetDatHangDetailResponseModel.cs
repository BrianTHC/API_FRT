using System.Collections.Generic;
using API.DrugFRT.Model.ViewModels;

namespace API.DrugFRT.Model.ResponseModels
{
    public class DuyetDatHangDetailResponseModel : BaseResponseModel
    {
        public List<DuyetDatHangDetailViewModel> Data { get; set; } 
    }
}
