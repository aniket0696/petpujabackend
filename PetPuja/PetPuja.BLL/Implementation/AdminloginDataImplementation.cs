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
    public class AdminloginDataImplementation: IAdminLogin
    {
        private PetPujaDBEntities context = new PetPujaDBEntities();
        public long GetAdminDetails(string username, string password)
        {
            var userId = (from user in context.Admins.Where(s => s.adminUsername == username && s.adminPassword == password) select user.adminID).SingleOrDefault();
            return userId;
        }
    }
}
