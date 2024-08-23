using Dapper;
using GetMehrData.Models;
using System.Data.Common;
using System.Data;

namespace GetMehrData.Services
{
    public class GoodService
    {
        public readonly MehrDbContext _context;
        public GoodService(MehrDbContext mehrDbContext)
        {
            _context = mehrDbContext;
        }

        public async Task<List<GoodViewModel>> GetList()
        {
            var connection = _context.CreateConnection();
            connection.Open();
            try
            {
                string query = "SELECT goodSyscode,title,SalePrice1,categoryTitle FROM VWCompleteGood";
                //var parameters = new DynamicParameters();
                //parameters.Add("UserSecLevel", searchListViewModel.secureLevel, DbType.Int32);
                //parameters.Add("SearchText", searchListViewModel.searchText, DbType.String);
                //parameters.Add("PageId", searchListViewModel.pageId, DbType.Int32);
                //parameters.Add("pageCount", searchListViewModel.pageCount, DbType.Int32);
                var stockList = await connection.QueryAsync<GoodViewModel>(query, commandType: CommandType.Text);
                return stockList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
