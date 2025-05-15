﻿using System.ComponentModel.DataAnnotations;

namespace ItemListTemplate.Entities
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
