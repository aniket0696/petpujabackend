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
    public class CustomerRegistrationDataImplementation: ICustomerRegistration
    {
        private PetPujaDBEntities context = new PetPujaDBEntities();

        public string PostCustomerDetails(CustomerAndAddressAndContactAndRole customerDetail)
        {
            Address address = new Address();
            address.houseNo = customerDetail.houseNo;
            address.street1 = customerDetail.street1;
            address.street2 = customerDetail.street2;
            address.locality = customerDetail.locality;
            address.city = customerDetail.city;
            address.zipcode = customerDetail.zipcode;
            address.stateName = customerDetail.state;
            address.country = customerDetail.country;

            context.Addresses.Add(address);
            context.SaveChanges();
            customerDetail.addressID = address.addressID ;

            Customer customer = new Customer();
            customer.customerName = customerDetail.customerName;
            customer.customerEmail = customerDetail.customerEmail;
            customer.addressID = customerDetail.addressID;
            customer.customerUsername = customerDetail.customerUsername;
            customer.customerPassword = customerDetail.customerPassword;
            customer.statusID = customerDetail.statusID;
            customer.roleID = customerDetail.roleID;

            context.Customers.Add(customer);
            context.SaveChanges();
            customerDetail.customerID = customer.customerID;

            Contact contact = new Contact();
            contact.customerID = customerDetail.customerID;
            contact.contact_no = customerDetail.primaryContactNo;

            context.Contacts.Add(contact);
            context.SaveChanges();

            if (customerDetail.secondaryContactNo != 0)
            {
                contact.customerID = customerDetail.customerID;
                contact.contact_no = customerDetail.secondaryContactNo;
                context.Contacts.Add(contact);
            }
            
            return customer.customerUsername;
        }
        public long GetCustomerDetails(string username, string password)
        {
            var userId = (from user in context.Customers.Where(s => s.customerUsername == username && s.customerPassword == password && s.statusID == 1) select user.customerID).SingleOrDefault();
            return userId;   
        }
    }
}
