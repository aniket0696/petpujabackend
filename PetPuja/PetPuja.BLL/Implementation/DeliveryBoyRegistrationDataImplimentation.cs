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
    public class DeliveryBoyRegistrationDataImplimentation: IDeliveryBoyRegistration
    {
        private PetPujaDBEntities context = new PetPujaDBEntities();

        public string PostDeliveryBoyDetails(DeliveryBoyAndAddressAndContactAndRole deliveryBoyDetail)
        {
            Address address = new Address();
            address.houseNo = deliveryBoyDetail.houseNo;
            address.street1 = deliveryBoyDetail.street1;
            address.street2 = deliveryBoyDetail.street2;
            address.locality = deliveryBoyDetail.locality;
            address.city = deliveryBoyDetail.city;
            address.zipcode = deliveryBoyDetail.zipcode;
            address.stateName = deliveryBoyDetail.state;
            address.country = deliveryBoyDetail.country;

            context.Addresses.Add(address);
            context.SaveChanges();
            deliveryBoyDetail.addressID = address.addressID;

            DeliveryBoy deliveryBoy = new DeliveryBoy();
            deliveryBoy.deliveryBoyName = deliveryBoyDetail.deliveryBoyName;
            deliveryBoy.deliveryBoyEmail = deliveryBoyDetail.deliveryBoyEmail;
            deliveryBoy.addressID = deliveryBoyDetail.addressID;
            deliveryBoy.deliveryBoyUsername = deliveryBoyDetail.deliveryBoyUsername;
            deliveryBoy.deliveryBoyPassword = deliveryBoyDetail.deliveryBoyPassword;
            deliveryBoy.statusID = deliveryBoyDetail.statusID;
            deliveryBoy.roleID = deliveryBoyDetail.roleID;

            context.DeliveryBoys.Add(deliveryBoy);
            context.SaveChanges();
            deliveryBoyDetail.deliveryBoyID = deliveryBoy.deliveryBoyID;

            Contact contact = new Contact();
            contact.deliveryBoyID = deliveryBoyDetail.deliveryBoyID;
            contact.contact_no = deliveryBoyDetail.primaryContactNo;

            context.Contacts.Add(contact);
            context.SaveChanges();

            if (deliveryBoyDetail.secondaryContactNo != 0)
            {
                contact.deliveryBoyID = deliveryBoyDetail.deliveryBoyID;
                contact.contact_no = deliveryBoyDetail.secondaryContactNo;
                context.Contacts.Add(contact);
                context.SaveChanges();
            }

            return deliveryBoy.deliveryBoyUsername;
        }
        public long GetDeliveryBoyDetails(string username, string password)
        {
            var userId = (from user in context.DeliveryBoys.Where(s => s.deliveryBoyUsername == username && s.deliveryBoyPassword == password && s.statusID == 1) select user.deliveryBoyID).SingleOrDefault();
            return userId;
        }
    }
}
