﻿using System;
namespace part3.Models
{
    public class Part : Product
    {
        public Part(int pid, String name, String desc, String type, double price) 
            : base(pid, name, desc, type, price)
        {
        }

    }
}
