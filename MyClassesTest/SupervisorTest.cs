﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;

namespace MyClassesTest
{
    [TestClass]
    public class SupervisorTest
    {
        [TestMethod]
        public void DoEmployeeExistTest()
        {
            Supervisor super = new Supervisor();

            super.Employees = new List<Employee>();

            super.Employees.Add(new Employee
            {
                FirstName= "Ligia",
                LastName = "Viana"

            });

            Assert.IsTrue(super.Employees.Count > 0);

        }
    }
}
