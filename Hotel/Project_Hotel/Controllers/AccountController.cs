using Project_Hotel.Entities;
using Project_Hotel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Controllers
{
    public class AccountController
    {
        private AccountService accountService = new AccountService();

        public Account login(string email, string password)
        {
            return accountService.login(email, password);
        }

        public Account getAccountById(int id)
        {
            return accountService.getAccountById(id);
        }

        public void updateAccount(int id, string name, string email, string passwoard)
        {
            accountService.updateAccount(id, name, email, passwoard);
        }

        public void deleteAccount(int id)
        {
            accountService.deleteAccount(id);
        }
    }

}

