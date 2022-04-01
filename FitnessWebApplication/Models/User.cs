﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        //relatia dintre abonamente si useri
        public List<User_Subscription> User_Subscriptions { get; set; }

        //relatia dintre useri si rezervare
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

    }
}
