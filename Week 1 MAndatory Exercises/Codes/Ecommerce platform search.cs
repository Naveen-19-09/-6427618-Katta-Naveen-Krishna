using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

class Program
{
    // Linear Search by Product Name
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    // Binary Search by Product Name
    static Product BinarySearch(Product[] products, string name)
    {
        int left = 0, right = products.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        // Clothing product list
        Product[] products = new Product[]
        {
            new Product(201, "T-shirt", "Men"),
            new Product(202, "Jeans", "Women"),
            new Product(203, "Jacket", "Men"),
            new Product(204, "Dress", "Women"),
            new Product(205, "Shorts", "Kids"),
            new Product(206, "Skirt", "Women")
        };

        // Sort for binary search (by ProductName)
        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        // Take user input
        Console.Write("Enter the product name to search: ");
        string searchName = Console.ReadLine();

        Console.WriteLine("\n--- Linear Search ---");
        var result1 = LinearSearch(products, searchName);
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found");

        Console.WriteLine("\n--- Binary Search ---");
        var result2 = BinarySearch(products, searchName);
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found");

        // Summary
        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine("Linear Search: Simple but slow for large lists (O(n))");
        Console.WriteLine("Binary Search: Fast but requires sorted data (O(log n))");
    }
}
