using System;

class Product {
    public int ProductId;
    public string ProductName;
    public string Category;
}

class SearchSystem {
    public static Product LinearSearch(Product[] products, string name) {
        foreach (var p in products) {
            if (p.ProductName == name) return p;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, string name) {
        int left = 0, right = products.Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            int cmp = string.Compare(products[mid].ProductName, name);
            if (cmp == 0) return products[mid];
            else if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return null;
    }

    public static void Main() {
        Product[] unsorted = {
            new Product { ProductId = 1, ProductName = "Mouse", Category = "Electronics" },
            new Product { ProductId = 2, ProductName = "Keyboard", Category = "Electronics" }
        };

        Product[] sorted = {
            new Product { ProductId = 2, ProductName = "Keyboard", Category = "Electronics" },
            new Product { ProductId = 1, ProductName = "Mouse", Category = "Electronics" }
        };

        var result1 = LinearSearch(unsorted, "Mouse");
        var result2 = BinarySearch(sorted, "Keyboard");

        Console.WriteLine(result1 != null ? "Found in linear search" : "Not found");
        Console.WriteLine(result2 != null ? "Found in binary search" : "Not found");
    }
}
