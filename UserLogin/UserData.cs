using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    static public class UserData
    {
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static public List<User> DatabaseUsers
        {
            get
            {
                ResetDatabaseUserData();
                return _databaseUsers;
            }
        }

        private static void ResetDatabaseUserData()
        {
            if (_databaseUsers == null)
                _databaseUsers = new List<User>();
        }

        static private UserContext context = new UserContext();

        static private List<User> _testUsers;

        static private List<User> _databaseUsers;

        static private void ResetTestUserData()
        {
            if (_testUsers == null)
            {
                _testUsers = new List<User>
                {
                    new User
                    {
                        Username = "mart_m",
                        Password = "12345",
                        FakNum = "123219014",
                        Role = 1,
                        Created = DateTime.Now,
                        ExpireOn = DateTime.MaxValue
                    },
                    new User
                    {
                        Username = "yasna_v",
                        Password = "password",
                        FakNum = "123219010",
                        Role = 4,
                        Created = DateTime.Now,
                        ExpireOn = DateTime.MaxValue
                    },
                  
                };
            }
        }

        static public void AddUsers()
        {
            foreach (User u in TestUsers)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }

        static public User IsUserPassCorrect(string UserName, string Password)
        {
            if(context.Users.Count() == 0)
            {
                AddUsers();
            }

            User user = (from u in context.Users
                         where u.Username.Equals(UserName) && u.Password.Equals(Password)
                         select u).DefaultIfEmpty(null).First() ?? throw new UserNotFoundException("User was not found");

            return user;
        }

        static public void SetUserActiveTo(string UserName, DateTime date)
        {
            foreach (User user in context.Users)
            {
                if (user.Username.Equals(UserName))
                {
                    user.ExpireOn = date;
                    Logger.LogActivity("Expire date has been changed for " + UserName);
                }
            }
            context.SaveChanges();
        }

        static public void AssignUserRole(string UserName, UserRoles userRole)
        {

            User usr =
            (from u in context.Users
             where u.Username.Equals(UserName)
             select u).First();

            usr.Role = (int)userRole;
            Logger.LogActivity("Role has been changed for " + UserName);

            context.SaveChanges();
        }

        static public void DeleteUser(string UserName)
        {
            User delObj =
            (from u in context.Users
             where u.Username == UserName
             select u).First();
            context.Users.Remove(delObj);
            context.SaveChanges();
        }

        static public void ShowUsers()
        {
            foreach (User user in context.Users)
            {
                Console.WriteLine("Username: " + user.Username);
                Console.WriteLine("User password: " + user.Password);
                Console.WriteLine("User faculty number: " + user.FakNum);
                Console.WriteLine("User Role: " + (UserRoles)user.Role);
                Console.WriteLine("Created on: " + user.Created);
                Console.WriteLine("Expire on: " + user.ExpireOn);
            }
        }
    }
}