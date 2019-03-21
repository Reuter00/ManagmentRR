using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagmentRR.Models
{
    public class Users
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display (Name = "Privilegios")]
        public int AdminPriv { get; set; }

        public Users()
        {

        }

        public Users(int id, string nome, string username, string password,int adminpriv)
        {
            Id = id;
            Nome = nome;
            UserName = username;
            Password = password;
            AdminPriv = adminpriv;
        }



    }
}
