using System;

namespace Xalapa.API.Entities
{
    public abstract class MainEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date_register { get; set; }
    }
}