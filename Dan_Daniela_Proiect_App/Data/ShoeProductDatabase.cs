using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Dan_Daniela_Proiect_App.Models;

namespace Dan_Daniela_Proiect_App.Data
{
    public class ShoeProductDatabase
    {
        IRestApi restApi;
        public ShoeProductDatabase(IRestApi service)
        {
            restApi = service;
        }
        public Task<List<ShoePage>> GetShoePageAsync()
        {
            return restApi.RefreshDataAsync();
        }

        public Task SaveShoePageAsync(ShoePage item, bool isNewItem = true)
        {
            return restApi.SaveShoePageAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShoePage item)
        {
            return restApi.DeleteShoePageAsync(item.ID);
        }

    }
}
    

