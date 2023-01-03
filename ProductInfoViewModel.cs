using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class ProductInfoViewModel
    {
        public ObservableCollection<ProductInfo> ItemList { get; set; }
        public ProductInfoViewModel()
        {
            ItemList = new ObservableCollection<ProductInfo>();
            ItemList.Add(new ProductInfo() { ProductId=1,ProductName="Computer",Price=50000, ImageURL="genshin_test1.png"});
            ItemList.Add(new ProductInfo() { ProductId = 2, ProductName = "Mouse", Price = 500, ImageURL = "genshin_test2.png" });
            ItemList.Add(new ProductInfo() { ProductId = 3, ProductName = "Keyboard", Price = 400, ImageURL ="home.png" });
            ItemList.Add(new ProductInfo() { ProductId = 4, ProductName = "Laptop", Price = 4000, ImageURL="button.png" });
            ItemList.Add(new ProductInfo() { ProductId = 1, ProductName = "Pendrive", Price = 30, ImageURL = "images1.png" });

            MessagingCenter.Subscribe<AddOrEditProductPage, ProductInfo>(this, "AddOrEditProduct", (page, product) =>
            {
                if (product.ProductId == 0)
                {
                    product.ProductId = ItemList.Count + 1;
                    ItemList.Add(product);
                }
            });
        }
        
    }
}
