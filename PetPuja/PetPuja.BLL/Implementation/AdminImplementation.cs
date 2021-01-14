using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using PetPuja.BLL.Interfaces;
using PetPuja.DAL.Context;
using PetPuja.Models;

namespace PetPuja.BLL.Implementation
{
    public class AdminImplementation : IAdminOperations
    {
        private PetPujaDBEntities context = new PetPujaDBEntities();

        public List<CustomerAndAddressAndContact> GetCustomerDetails()
        {
            
            var query = (from cust in context.Customers
                         join con in context.Contacts  on cust.customerID equals con.customerID
                         join ad in context.Addresses on cust.addressID equals ad.addressID
                         join st in context.StatusTables on cust.statusID equals st.statusID
                         join rl in context.RoleTables on cust.roleID equals rl.roleID 
                         select new CustomerAndAddressAndContact()
                         {
                            customerID= cust.customerID,
                            customerName= cust.customerName,
                            customerEmail= cust.customerEmail,
                           customerUsername=  cust.customerUsername,
                             //statusID = cust.statusID,
                             
                             contact_no=con.contact_no,
                             addressID = ad.addressID,
                             houseNo = ad.houseNo,
                             locality = ad.locality,
                             street1 = ad.street1,
                             street2 = ad.street2,
                             city=ad.city,
                             state= ad.stateName,
                             country = ad.country,
                             zipcode = ad.zipcode
                         }
                       ).ToList();
            return query;
        }

        public List<MenuAndTiffinProvider> GetAllMenu()
        {
            var query = (from m in context.Menus
                         join s in context.StatusTables on m.statusID equals s.statusID join
                         p in context.TiffinProviders on m.tiffinProviderID equals p.tiffinProviderID

                         select new MenuAndTiffinProvider()
                         {
                             menuID= m.menuID,
                            tiffinProviderID= m.tiffinProviderID,
                           menuDescription=  m.menuDescription,
                            menuName= m.menuName,
                            price= m.price,
                            menuImage= m.menuImage,
                            category= m.category,
                           statusID=  s.statusID,
                            restaurantName = p.restaurantName,
                            tiffinProviderName= p.tiffinProviderName
                         }
                             ).ToList();
            return query;
        }
    }
}
