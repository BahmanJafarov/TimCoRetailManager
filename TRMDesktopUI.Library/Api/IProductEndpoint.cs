using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDataManager.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}