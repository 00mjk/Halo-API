﻿using System;
using System.Collections.Generic;
using HaloEzAPI.Abstraction.Interfaces;

namespace HaloEzAPI.Model.Response.MetaData.Halo5
{
    public class Reward : IGuidContentIds
    {
        public int XP { get; set; }
        public IEnumerable<RequisitionPack> RequisitionPacks { get; set; }
        public Guid Id { get; set; }
        public Guid ContentId { get; set; }
    }
}