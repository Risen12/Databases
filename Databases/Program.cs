using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Подсказка
            //using (MyDBContext context = new MyDBContext())
            //{
            //    var user1 = new User
            //    {
            //        Name = "Tom",
            //        Age = 20
            //    };
            //    var user2 = new User
            //    {
            //        Name = "David",
            //        Age = 35
            //    };
            //    context.users.Add(user1);
            //    context.users.Add(user2);
            //    context.SaveChanges();
            //    var userJob1 = new User_sJob
            //    {
            //        UserId = user1.ID,
            //        Job = "Doctor"
            //    };
            //    var userJob2 = new User_sJob
            //    {
            //        UserId = user2.ID,
            //        Job = "Driver"
            //    };
            //    context.jobs.Add(userJob1);
            //    context.jobs.Add(userJob2);
            //    context.SaveChanges();

            //    foreach (var job in context.jobs)
            //    {
            //        Console.WriteLine($" Job Name: {job.Job}  User: {job.User.Name}");
            //    }

            //}
            #endregion
            while (true)
            {
                Console.WriteLine("Please, write the action which you want do...");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Add":
                        Console.WriteLine(Add_User());
                        break;
                    case "Delete":
                        Console.WriteLine(Remove_User());
                        break;
                    case "Change":
                        Console.WriteLine(Change_User());
                        break;
                }
            }

        }
        static string Add_User()
        {
            User user = new User();
            try
            {
                Console.WriteLine("Write name of user...");
                user.Name = Console.ReadLine();
                Console.WriteLine("Write age of user...");
                user.Age = int.Parse(Console.ReadLine());
                using (MyDBContext context = new MyDBContext())
                {
                    context.users.Add(user);
                    context.SaveChanges();
                }
                return "Operation of add a new user is finished succesfully!";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        
        }
        static string Remove_User()
        {
            try
            {
                Console.WriteLine("Write id of user whom you want delete...");
                int id_delete = int.Parse(Console.ReadLine());
                using (MyDBContext context = new MyDBContext())
                {
                    User user = context.users.Find(id_delete);
                    context.users.Remove(user);
                    context.SaveChanges();
                }
                return "Operation of delete user is finished succesfully!";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        static string Add_Job()
    
        {
            User_sJob job = new User_sJob();
            try
            {
                Console.WriteLine("Write name of job...");
                job.Job = Console.ReadLine();
                Console.WriteLine("Write id of user whom have this job...");
                job.UserId = int.Parse(Console.ReadLine());
                using (MyDBContext context = new MyDBContext())
                {
                    context.jobs.Add(job);
                    context.SaveChanges();
                }
                return "Operation of adding a new job is finished succesfully!";

            }
            catch (Exception e)
            {
                return e.Message;

            }

        }

        static string Change_User()
        {
            try
            {
                Console.WriteLine("Write id of user whom you want change...");
                int id_change = int.Parse(Console.ReadLine());
                using (MyDBContext context = new MyDBContext())
                {
                    User user = context.users.Find(id_change);
                    Console.WriteLine("Write new name of user...");
                    user.Name = Console.ReadLine();
                    Console.WriteLine("Write new age of user...");
                    user.Age = int.Parse(Console.ReadLine());
                    context.SaveChanges();
                    return "Operation of change user is finished succesfully!";
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }

        }
    }
}
