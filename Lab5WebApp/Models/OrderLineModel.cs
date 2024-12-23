﻿using DomainModel;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5WebApp.Models
{
    public class OrderLineModel
    {
        public OrderLineModel()
        {

        }
        public OrderLineModel(List<PizzaSizesDto> pizzaSizes, List<IngredientShortDto> ingredients,
            List<PizzaDto> pizzas)
        {
            pizza_sizes = pizzaSizes;
            addedingredientsIds = new List<int>();
            addedingredients = ingredients;
            this.pizzas = pizzas;
        }

        public OrderLineModel(OrderLineDto ol, List<PizzaSize> pizzaSizes, List<IngredientModel> ingredients,
            List<PizzaDto> pizzas)
        {
            Id = ol.Id;
            Name = ol.Pizza.C_name;

        }
        
        public int Id { get; set; }
        [DisplayName("Название")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Количество")]
        [Required]
        public int quantity { get; set; }
        [DisplayName("Пользовательская")]
        public bool custom { get; set; }
        [DisplayName("Цена, руб")]
        
        public decimal position_price { get; set; }
        public int PizzaSize_Id { get; set; }
        [DisplayName("Размер")]
        public string PizzaSizeName { get; set; }
        public List<PizzaSizesDto> pizza_sizes { get; set; }
        
        [DisplayName("Вес, г")]
        public decimal weight { get; set; }
        
        public int pizzaId { get; set; }
        [DisplayName("Пицца")]
        public string PizzaName { get; set; }

        public List<PizzaDto> pizzas { get; set; }

        public List<int> addedingredientsIds { get; set; }
        public List<IngredientShortDto> addedingredients { get; set; }
        
    }
}
