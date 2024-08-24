using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_253501_Stepanov.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int CategoryId { get; set; }
        public string Description {  get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public Dish() { }
    }
}
