﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Data.Domain
{
    public class Employee
    {
        #region [Ctor]
        public Employee()
        {

        }
        #endregion

        #region [Properties]
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string City { get; set; }
        public string Gender { get; set; }
        #endregion
    }
}
