﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TequliasRestaurant.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}