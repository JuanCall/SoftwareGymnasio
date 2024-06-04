using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGymnasio
{
    internal class Admin
    {
        private string user;
        private string password;
        public Admin()
        {
            this.user = "admin";
            this.password = "admin";
        }
        public bool verificarAdmin(string username, string password)
        {
            return username == this.user && password == this.password;
        }
    }
}
