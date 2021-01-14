using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetPuja.DAL.Context;
using PetPuja.Models;

namespace PetPuja.BLL.Interfaces
{
    interface ITiffinProviderOperations
    {
        TiffinProviderDetails GetTiffinProviderProfile(long id);
        void UpdateTiffinProvider(long id, TiffinProviderDetails tiffinProvider);
        List<TiffinProviderMenu> GetMyMenu(long id);
        List<TiffinProviderMenu> GetPendingMenu(long id);
        List<TiffinProviderMenu> GetDeclainedMenu(long id);

        void UpdateTiffinMenu(long id, TiffinProviderMenu tiffinMenu);
        List<TiffinProviderFeedback> GetTiffinFeedback(long id);
        List<TiffinOrders> GetOrderHistory(long id);
        void AddMenu(long id,TiffinProviderMenu newMenu);
        void DeregisterTiffinMenu(long id);

    }
}
