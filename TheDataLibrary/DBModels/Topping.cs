// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace TheDataLibrary.DBModels
{
    public partial class Topping
    {
        public Topping()
        {
            Pizzastoppings = new HashSet<Pizzastopping>();
        }

        public int IdToppings { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<Pizzastopping> Pizzastoppings { get; set; }
    }
}