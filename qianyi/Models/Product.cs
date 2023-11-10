using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace qianyi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Assuming an Id field for database primary key
        public double Price { get; set; }
        public string Name { get; set; }
 
        public string Description { get; set; }
        public virtual Cate Category { get; set; }
        public string ImageUrl { get; set; }
        // 默认构造函数
        public Product()
        {
            // 可以在这里设置默认值
            this.Id = 0;
            this.Name = "默认产品名称";
            this.Price = 0;
            this.Description = "默认描述";
            this.Category = null;
            this.ImageUrl = "默认图片地址";
        }
        // 自定义构造函数
        public Product(int id,double price,string name,  string description, Cate category, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.ImageUrl = imageUrl;
        }
    }
}
