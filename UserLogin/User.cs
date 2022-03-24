using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        private String _Username;
        public String Username { get; set; }
        private String _Password;
        public String Password { get; set; }
        private String _FacNum;
        public String FacNum { get; set; }
        private UserRoles _Role;
        public UserRoles Role { get; set; }

        public DateTime Created;
        public User()
        {
            
        }
        
       
    }
}
