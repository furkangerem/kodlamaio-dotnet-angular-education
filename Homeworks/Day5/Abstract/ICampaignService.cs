﻿using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign);
    }
}
