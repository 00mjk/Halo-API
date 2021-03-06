using System;
using HaloEzAPI.Abstraction.Enum.Halo5;
using HaloEzAPI.Abstraction.Interfaces;

namespace HaloEzAPI.Model.Response.MetaData.Halo5
{
    public class Enemy : IDetail
    {
        public Faction Faction { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LargeIconImageUrl { get; set; }
        public string SmallIconImageUrl { get; set; }
        public uint Id { get; set; }
        public Guid ContentId { get; set; }
    }
}