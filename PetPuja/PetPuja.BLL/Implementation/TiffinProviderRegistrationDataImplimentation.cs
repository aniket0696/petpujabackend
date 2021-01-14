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
    public class TiffinProviderRegistrationDataImplimentation: ITiffinProviderRegistration
    {
        private PetPujaDBEntities context = new PetPujaDBEntities();

        public string PostTiffinProviderDetails(TiffinProviderAndAddressAndContactAndRole tiffinProviderDetail)
        {
            Address address = new Address();
            address.houseNo = tiffinProviderDetail.houseNo;
            address.street1 = tiffinProviderDetail.street1;
            address.street2 = tiffinProviderDetail.street2;
            address.locality = tiffinProviderDetail.locality;
            address.city = tiffinProviderDetail.city;
            address.zipcode = tiffinProviderDetail.zipcode;
            address.stateName = tiffinProviderDetail.state;
            address.country = tiffinProviderDetail.country;

            context.Addresses.Add(address);
            context.SaveChanges();
            tiffinProviderDetail.addressID = address.addressID;

            TiffinProvider tiffinProvider = new TiffinProvider();
            tiffinProvider.tiffinProviderName = tiffinProviderDetail.tiffinProviderName;
            tiffinProvider.tiffinProviderEmail = tiffinProviderDetail.tiffinProviderEmail;
            tiffinProvider.addressID = tiffinProviderDetail.addressID;
            tiffinProvider.tiffinProviderUsername = tiffinProviderDetail.tiffinProviderUsername;
            tiffinProvider.tiffinProviderPassword = tiffinProviderDetail.tiffinProviderPassword;
            tiffinProvider.statusID = tiffinProviderDetail.statusID;
            tiffinProvider.roleID = tiffinProviderDetail.roleID;
            tiffinProvider.restaurantName = tiffinProviderDetail.restaurantName;

            context.TiffinProviders.Add(tiffinProvider);
            context.SaveChanges();
            tiffinProviderDetail.tiffinProviderID = tiffinProvider.tiffinProviderID;

            Contact contact = new Contact();
            contact.tiffinProviderID = tiffinProviderDetail.tiffinProviderID;
            contact.contact_no = tiffinProviderDetail.primaryContactNo;

            context.Contacts.Add(contact);
            context.SaveChanges();

            if (tiffinProviderDetail.secondaryContactNo != 0)
            {
                contact.tiffinProviderID = tiffinProviderDetail.tiffinProviderID;
                contact.contact_no = tiffinProviderDetail.secondaryContactNo;
                context.Contacts.Add(contact);
                context.SaveChanges();
            }

            return tiffinProvider.tiffinProviderUsername;
        }
        public long GetTiffinProviderDetails(string username, string password)
        {
            var userId = (from user in context.TiffinProviders.Where(s => s.tiffinProviderUsername == username && s.tiffinProviderPassword == password && s.statusID == 1) select user.tiffinProviderID).SingleOrDefault();
            return userId;
        }
    }
}
