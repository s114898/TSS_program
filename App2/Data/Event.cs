﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization.DateTimeFormatting;

namespace App2.Data
{
    [DataContract, KnownType(typeof(DateTime))]
    public class Event
    {
        public int id { get; set; }
        public int listId { get; set; }
        public int process { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public DateTime start { get; set; }
        public DateTime change { get; set; }
        public bool complete { get; set; }
        public string startFormat
        {
            get
            {
                return start.ToString("H:mm   dd/MM");
            }
        }
    }
}
