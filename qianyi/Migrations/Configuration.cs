namespace qianyi.Migrations
{
    using Microsoft.Ajax.Utilities;
    using qianyi.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<qianyi.Data.qianyiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(qianyi.Data.qianyiContext context)
        {
            Cate[] category = new Cate[6];
            for (int i = 0; i < 6; i++)
            {
                category[i] = new Cate();
            }
            category[0].Category = "Bag";
            category[1].Category = "Cup";
            category[2].Category = "Decoration";
            category[3].Category = "Luggage";
            category[4].Category = "Office";
            category[5].Category = "others";
            //category.ForEach(c => context.Cate.Add(c));
            //context.SaveChanges();
            var products = new List<Product> {
                new Product(0,29.99, "Pink minimalist handbag", "Product Description: A simple pink handbag", category[0], "p1.png"),
                new Product(1,19.99, "Tan minimalist handbag", "Product Description: A simple tan handbag", category[0], "p2.png"),
                new Product(2,129.99, "vacuum cup", "Product Description: Drink hot water anytime, anywhere", category[1], "p3.png"),
                new Product(3,729.99, "Desktop decorations", "Product description: minimalist style makes life relaxed", category[2], "p4.png"),
                new Product(4,629.99, "suitcase", "Product Description:joy in every destination", category[3], "p5.png"),
                new Product(5,529.99, "electric toothbrush", "Product Description: Making Teeth Healthier",  category[5], "p6.png"),
                new Product(6,429.99, "Minimalist decorations", "Product Description: Environmentally friendly materials for decorating daily life",  category[2], "p7.png"),
                new Product(7,39.99, "pen", "Product Description: A simple pen", category[4], "p8.png"),
                new Product(8,59.99, "Water cup", "Product description: Drinking water is beneficial for health", category[1], "p9.png"),
                new Product(9,2449.99, "Cultural Creativity Luggage", "Product Description: Traveling with Culture", category[3], "p10.png"),
                new Product(10,449.99, "Office", "Product Description: Simplify Office Work", category[4], "p11.png"),
                new Product(11,779.99, "lipstick", "Product description: Make beauty last forever",  category[5], "p12.png"),
            };
            //products.ForEach(p => context.Products.Add(p));
            //context.SaveChanges();
        }
    }
}
