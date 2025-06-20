using System;
using System.Collections.Generic;

class Product {
    public int ProductId;
    public string ProductName;
    public int Quantity;
    public double Price;
}

class InventorySystem {
    Dictionary<int, Product> inventory = new Dictionary<int, Product>();

    public void AddProduct(Product p) {
        inventory[p.ProductId] = p;
    }

    public void UpdateProduct(Product p) {
        inventory[p.ProductId] = p;
    }

    public void DeleteProduct(int id) {
        inventory.Remove(id);
    }

    public void DisplayAll() {
        foreach (var p in inventory.Values) {
            Console.WriteLine($"{p.ProductId} {p.ProductName} {p.Quantity} {p.Price}");
        }
    }
}

class Program {
    static void Main() {
        InventorySystem inv = new InventorySystem();
        inv.AddProduct(new Product { ProductId = 1, ProductName = "Mouse", Quantity = 50, Price = 299.99 });
        inv.AddProduct(new Product { ProductId = 2, ProductName = "Keyboard", Quantity = 20, Price = 499.49 });
        inv.UpdateProduct(new Product { ProductId = 1, ProductName = "Mouse", Quantity = 45, Price = 299.99 });
        inv.DeleteProduct(2);
        inv.DisplayAll();
    }
}
