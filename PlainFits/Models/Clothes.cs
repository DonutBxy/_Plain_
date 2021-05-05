using System;
using System.ComponentModel.DataAnnotations;

namespace RazorClothes.Models
{
    public class Clothes
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public decimal Price { get; set; }
    }
}
