using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dan_Daniela_Proiect_App.Models;

namespace Dan_Daniela_Proiect_App.Data
{
    public  interface IRestApi
    {
        Task<List<ShoePage>> RefreshDataAsync();
        Task SaveShoePageAsync(ShoePage item, bool isNewItem);
        Task DeleteShoePageAsync(int id);
    }
}
