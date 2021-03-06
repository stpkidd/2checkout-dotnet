﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoCheckout
{
    public class Sale
    {
        public DateTime date_placed { get; set; }
        public string ip_address { get; set; }
        public string ip_country { get; set; }
        public string recurring_decline { get; set; }
        public long? sale_id { get; set; }
        public Invoice[] invoices { get; set; }
        public Comments[] comments { get; set; }
        public Customer customer { get; set; }
        public DetailIP detail_ip { get; set; }
    }
}
