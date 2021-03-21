using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        //Northwind de 5 karakterli metin olarak tutulur, bundan dolayı CustomerId string olarak belirlenir
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}
