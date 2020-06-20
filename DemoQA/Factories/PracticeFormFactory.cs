using DemoQA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                Email = "Someemail@.gmail.com",
                Gender = "Male",
                PhoneNumber = "0888885558",

            };        

        }

    }
}
