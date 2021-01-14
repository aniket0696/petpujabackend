using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using PetPuja.BLL.Interfaces;
using PetPuja.DAL.Context;
using PetPuja.Models;

namespace PetPuja.BLL.Implementation
{
    public class TiffinProviderImplementation : ITiffinProviderOperations
    {
        private PetPujaDBEntities db = new PetPujaDBEntities();

        private List<TiffinProviderMenu> GetMenuList(long id,int status)
        {
            var query = db.Menus.Where(m => m.tiffinProviderID == id && m.statusID == status).ToList();
            List<TiffinProviderMenu> menuList = new List<TiffinProviderMenu>();
            foreach (Menu m in query)
            {
                TiffinProviderMenu menu = new TiffinProviderMenu();
                menu.menuID = m.menuID;
                menu.menuName = m.menuName;
                menu.menuImage = m.menuImage;
                menu.menuDescription = m.menuDescription;
                menu.price = m.price;
                menu.statusID = m.statusID;
                menu.tiffinProviderID = m.tiffinProviderID;
                menu.category = m.category;
                menuList.Add(menu);
            }
            return menuList;
        }
        public List<TiffinProviderMenu> GetDeclainedMenu(long id)
        {
            return GetMenuList(id, 3);
        }

        public List<TiffinProviderMenu> GetMyMenu(long id)
        { 
            return GetMenuList(id,8);
        }

        public List<TiffinProviderMenu> GetPendingMenu(long id)
        {
            return GetMenuList(id, 0);
        }

        public TiffinProviderDetails GetTiffinProviderProfile(long id)
        {
            TiffinProvider tiffinProvider = db.TiffinProviders.Find(id);

            TiffinProviderDetails details = new TiffinProviderDetails();


            details.tiffinProviderID = tiffinProvider.tiffinProviderID;
            details.tiffinProviderName = tiffinProvider.tiffinProviderName;
            details.tiffinProviderEmail = tiffinProvider.tiffinProviderEmail;
            details.restaurantName = tiffinProvider.restaurantName;
            details.tiffinProviderUsername = tiffinProvider.tiffinProviderUsername;
            details.tiffinProviderPassword = tiffinProvider.tiffinProviderPassword;
            details.statusID = tiffinProvider.statusID;
            details.roleID = tiffinProvider.roleID;
            details.tiffinProviderImage = tiffinProvider.tiffinProviderImage;
            details.houseNo = tiffinProvider.Address.houseNo;
            details.street1 = tiffinProvider.Address.street1;
            details.street2 = tiffinProvider.Address.street2;
            details.locality = tiffinProvider.Address.locality;
            details.city = tiffinProvider.Address.city;
            details.zipcode = tiffinProvider.Address.zipcode;
            details.stateName = tiffinProvider.Address.stateName;
            details.country = tiffinProvider.Address.country;

            details.contact_no = tiffinProvider.Contacts.SingleOrDefault().contact_no;



            return details;
        }

        public void UpdateTiffinProvider(long id, TiffinProviderDetails updatedTiffinProvider)
        {


            TiffinProvider tiffinProvider = db.TiffinProviders.Find(id);
            tiffinProvider.tiffinProviderName = updatedTiffinProvider.tiffinProviderName;
            tiffinProvider.tiffinProviderEmail = updatedTiffinProvider.tiffinProviderEmail;
            tiffinProvider.restaurantName = updatedTiffinProvider.restaurantName;
            tiffinProvider.tiffinProviderUsername = updatedTiffinProvider.tiffinProviderUsername;
            tiffinProvider.tiffinProviderPassword = updatedTiffinProvider.tiffinProviderPassword;
            tiffinProvider.tiffinProviderImage = updatedTiffinProvider.tiffinProviderImage;

            db.Entry(tiffinProvider).State = EntityState.Modified;

            Address address = db.Addresses.Find(tiffinProvider.addressID);
            address.houseNo = updatedTiffinProvider.houseNo;
            address.street1 = updatedTiffinProvider.street1;
            address.street2 = updatedTiffinProvider.street2;
            address.locality = updatedTiffinProvider.locality;
            address.city = updatedTiffinProvider.city;
            address.zipcode = updatedTiffinProvider.zipcode;
            address.stateName = updatedTiffinProvider.stateName;
            address.country = updatedTiffinProvider.country;

            db.Entry(address).State = EntityState.Modified;            
            db.SaveChanges();
            Console.WriteLine("Tiffin Provider Updated Succesfully");
           
        }

        public void UpdateTiffinMenu(long id, TiffinProviderMenu updatedTiffinMenu)
        {
            Menu oldMenu = db.Menus.Find(id);
            //anytime when provider updates menu details its status changes to pending to get authentication from tiffin provider
            oldMenu.statusID = 0;
            oldMenu.menuName = updatedTiffinMenu.menuName;
            oldMenu.menuDescription = updatedTiffinMenu.menuDescription;
            oldMenu.menuImage = updatedTiffinMenu.menuImage;
            oldMenu.price = updatedTiffinMenu.price;
            oldMenu.category = updatedTiffinMenu.category;
            db.Entry(oldMenu).State = EntityState.Modified;
            db.SaveChanges();
            
        }

        public List<TiffinProviderFeedback> GetTiffinFeedback(long id)
        {
            List<TiffinProviderFeedback> feedbackList = new List<TiffinProviderFeedback>();
            var query = db.TiffinFeedbacks.Where(f => f.tiffinProviderID == id).ToList();
            foreach (TiffinFeedback f in query)
            {
                TiffinProviderFeedback feedback = new TiffinProviderFeedback();
                feedback.ordersID = f.ordersID;
                feedback.menuName = db.Menus.Find(f.menuID).menuName;
                feedback.menuImage = db.Menus.Find(f.menuID).menuImage;
                feedback.rating = f.rating;
                feedback.comment = f.comment;
                feedback.customerName = db.Customers.Find(f.customerID).customerName;
                feedback.customerEmail = db.Customers.Find(f.customerID).customerEmail;
                feedback.orderDateTime = db.Orders.Find(f.ordersID).orderDateTime;
                feedback.deliveryDateTime = db.Orders.Find(f.ordersID).deliveryDateTime;


                feedbackList.Add(feedback);                
            }

            return feedbackList;
        }

        private List<TiffinOrders> GetOrder(long id,int statusID)
        {
            List<TiffinOrders> listOfOrders = new List<TiffinOrders>();
            var query = db.Orders.Where(o => o.tiffinProviderID == id && o.statusID == statusID).ToList();
            foreach (Order item in query)
            {
                TiffinOrders tiffinOrder = new TiffinOrders();
                tiffinOrder.ordersID = item.ordersID;
                tiffinOrder.orderDateTime = item.orderDateTime;
                tiffinOrder.deliveryDateTime = item.deliveryDateTime;
                tiffinOrder.customerName = item.Customer.customerName;
                tiffinOrder.customerEmail = item.Customer.customerEmail;
                tiffinOrder.deliveryBoyName = item.DeliveryBoy.deliveryBoyName;
                tiffinOrder.deliveryBoyEmail = item.DeliveryBoy.deliveryBoyEmail;
                tiffinOrder.paymentDate = item.Payment.paymentDate;
                tiffinOrder.billingAmount = item.Payment.billingAmount;
                
                listOfOrders.Add(tiffinOrder);
            }


            return listOfOrders;

        }
        public List<TiffinOrders> GetOrderHistory(long id)
        {
            return GetOrder(id,7);
        }
        public List<TiffinOrders> GetTiffinCurrentOrders(long id)
        {
            return GetOrder(id, 0);
        }

        public void AddMenu(long id, TiffinProviderMenu newMenuItem)
        {
            Menu menu = new Menu();
            menu.menuName = newMenuItem.menuName;
            menu.menuImage = newMenuItem.menuImage;
            menu.menuDescription = newMenuItem.menuDescription;
            menu.price = newMenuItem.price;
            menu.category = newMenuItem.category;
            menu.statusID = 0;

            db.Menus.Add(menu);
            db.SaveChanges();            
        }

        public void DeregisterTiffinMenu(long id)
        {
            TiffinProvider tiffinProvider = db.TiffinProviders.Find(id);
            tiffinProvider.statusID = 2;
            db.Entry(tiffinProvider).State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}
