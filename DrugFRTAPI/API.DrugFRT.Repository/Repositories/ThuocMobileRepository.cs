using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.DrugFRT.Framework.Interface;
using API.DrugFRT.Model.ResponseModels;
using API.DrugFRT.Model.ViewModels;
using API.DrugFRT.Repository.Interface;
using Dapper;

namespace API.DrugFRT.Repository.Repositories
{
    public class ThuocMobileRepository : RepositoryBase, IThuocMobileRepository
    {
        public ThuocMobileRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<DuyetDatHangDetailResponseModel> GetDuyetDatHangDetail(int? intDocEntry)
        {
            return await WithConnection(async connecttion =>
            {
                var parameter = new DynamicParameters();

                parameter.Add("@DocEntry", intDocEntry, DbType.Int32);

                var result = await connecttion.QueryAsync<DuyetDatHangDetailViewModel>("sp_Get_Detail_DuyetDatHang", parameter,
                    commandType: CommandType.StoredProcedure);

                return new DuyetDatHangDetailResponseModel
                {
                    Data = result.ToList()
                };
            });
        }
    }
}
