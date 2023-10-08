﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINDRailways.Model
{
    public class Ticket
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public string AccountId { get; set; }
        [Indexed]
        public int ScheduleId { get; set; }
        public string IsPaid { get; set; }
        public int InitialPaymentMethod { get; set; }
    }
}
