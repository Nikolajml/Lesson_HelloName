using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_HelloName.Classes.Lesson_12
{
    public class User
    {
        public List<User> users;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public User(List<User> users)
        {
            this.users = users;
        }

        /// <summary>
        /// 8. The method that returns "<first name> <middle name> <last name>" 
        /// if a middle name occurs or "<first name> <last name>" if a middle name does not exist.            
        /// </summary>
        public void GetUsersInfo()
        {

            var withMiddleNameUsers = users.Where(u => u.MiddleName == "");
            
            foreach (var user in withMiddleNameUsers)
            {
                Console.WriteLine(user.FirstName + " " + " " + user.LastName);
            }

            var usersWithAllIno = users.Where(u => u.MiddleName != "");
            
            foreach (var user in usersWithAllIno) 
            {                
                Console.WriteLine(user.FirstName + " " + user.MiddleName + " " + user.LastName);
            }                        
        }

        /// <summary>
        /// 9. The method that returns a list of users sorted by LastName in deletion order.            
        /// </summary>
        public void SortListByLastName()
        {
            var orderLastName = users.OrderByDescending(u => u.LastName);

            foreach (var u in orderLastName)
            {
                Console.WriteLine(u.FirstName + " " + u.MiddleName + " " + u.LastName);
            }
        } 
    }
}

//}