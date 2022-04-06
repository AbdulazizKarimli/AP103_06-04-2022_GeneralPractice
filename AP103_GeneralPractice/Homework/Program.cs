using Homework.Helpers;
using Homework.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Directory.CreateDirectory(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_06-04-2022_GeneralPractice\AP103_GeneralPractice\Homework\Files");
            //if (!File.Exists(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_06-04-2022_GeneralPractice\AP103_GeneralPractice\Homework\Files\database.json"))
            //{
            //    File.Create(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_06-04-2022_GeneralPractice\AP103_GeneralPractice\Homework\Files\database.json");
            //}

            //Department department = new Department()
            //{
            //    Id = 1,
            //    Name = "test department"
            //};


            //bool check = true;
            //do
            //{
            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1. Add employee");
            //    Console.WriteLine("2. Get employee by id");
            //    Console.WriteLine("3. Remove employee");
            //    Console.WriteLine("0. Quit");

            //    string choice = Console.ReadLine();



            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Employee id:");
            //            int id = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Name:");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Salary:");
            //            double salary = Convert.ToDouble(Console.ReadLine());

            //            Employee employee = new Employee()
            //            {
            //                Id = id,
            //                Name = name,
            //                Salary = salary
            //            };

            //            department.AddEmployee(employee);

            //            string deparmentJsonStr = JsonConvert.SerializeObject(department);

            //            using (StreamWriter sw = new StreamWriter(Constants.path))
            //            {
            //                sw.Write(deparmentJsonStr);
            //            }
            //            break;
            //        case "2":
            //            Console.WriteLine("Id:");
            //            int employeeId = Convert.ToInt32(Console.ReadLine());

            //            string result = String.Empty;
            //            using (StreamReader sr = new StreamReader(Constants.path))
            //            {
            //                result = sr.ReadToEnd();
            //            }

            //            Department deparmentObj = JsonConvert.DeserializeObject<Department>(result);

            //            Console.WriteLine(deparmentObj.GetEmployeeById(employeeId).ShowInfo());
            //            break;
            //        case "3":
            //            Console.WriteLine("Id:");
            //            int empId = Convert.ToInt32(Console.ReadLine());

            //            string resultDeparment = String.Empty;
            //            using (StreamReader sr = new StreamReader(Constants.path))
            //            {
            //                resultDeparment = sr.ReadToEnd();
            //            }

            //            Department deparmentJsonObj = JsonConvert.DeserializeObject<Department>(resultDeparment);

            //            deparmentJsonObj.RemoveEmployee(empId);

            //            string jsonResult = JsonConvert.SerializeObject(deparmentJsonObj);

            //            using (StreamWriter sw = new StreamWriter(Constants.path))
            //            {
            //                sw.Write(jsonResult);
            //            }
            //            break;
            //        case "0":
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("wrong input");
            //            break;
            //    }
            //} while (check);
            #endregion

            #region HttpClient
            HttpClient httpCliet = new HttpClient();
            var response = httpCliet.GetAsync("https://jsonplaceholder.typicode.com/posts").Result;
            string responseJsonStr = response.Content.ReadAsStringAsync().Result;

            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(responseJsonStr);

            foreach (var post in posts)
            {
                Console.WriteLine("\n--------\n");
                Console.WriteLine($"Id: {post.Id}\nUserId: {post.UserId}\nTitle: {post.Title}\nBody: {post.Body}");
            }
            #endregion
        }
    }
}
