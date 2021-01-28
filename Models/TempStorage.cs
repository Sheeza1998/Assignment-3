using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public static class TempStorage
    {
        //Creating a class to pass the list of movies
        private static List<Class> applications = new List<Class>();

        //making the class public
        public static IEnumerable<Class> Applications => applications;

        public static void AddApplication(Class apps)
        {
            applications.Add(apps);
        }

    }
}
