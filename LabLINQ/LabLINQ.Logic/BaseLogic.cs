﻿using LabLINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLINQ.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }
    }
}
