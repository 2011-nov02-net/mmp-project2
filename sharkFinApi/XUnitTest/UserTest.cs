﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTest
{
    public class UserTest : IDisposable
    {
        User testUser;
        public UserTest()
        {
             testUser = new User
            {
                FirstName = "Paul",
                LastName = "Cortez",
                Email = "pbcortez@revature.net",
                UserName = "pbcortez"
            };
        }

        [Fact]
        public void UserTest1()
        {

            //Act
            testUser.FirstName = "Matthew";


            //Assert
            Assert.Equal("Matthew", testUser.FirstName);
        }

        [Fact]
        public void UserTest2()
        {
            //Arrange

            //Act
            testUser.LastName = "Goodman";

            //Assert
            Assert.Equal("Goodman", testUser.LastName);
        }
        [Fact]
        public void UserTest3()
        {
            //Arrange

            //Act
            testUser.Email = "mattg@revature.net";

            //Assert
            Assert.Equal("mattg@revature.net", testUser.Email);
        }
        [Fact]
        public void UserTest4()
        {
            //Arrange

            //Act
            testUser.UserName = "mattg";

            //Assert
            Assert.Equal("mattg", testUser.UserName);
        }

        public void Dispose()
        {
            testUser = null;
        }
    }
}