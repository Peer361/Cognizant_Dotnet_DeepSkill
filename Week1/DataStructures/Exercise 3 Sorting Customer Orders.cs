using System;

class Order {
    public int OrderId;
    public string CustomerName;
    public double TotalPrice;
}

class OrderSorting {
    public static void BubbleSort(Order[] orders) {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice) {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
    }

    public static void QuickSort(Order[] orders, int low, int high) {
        if (low < high) {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high) {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;
        for (int j = low; j < high; j++) {
            if (orders[j].TotalPrice <= pivot) {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }
        var t = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = t;
        return i + 1;
    }

    public static void Main() {
        Order[] orders = {
            new Order { OrderId = 1, CustomerName = "Alice", TotalPrice = 1500 },
            new Order { OrderId = 2, CustomerName = "Bob", TotalPrice = 900 }
        };

        QuickSort(orders, 0, orders.Length - 1);

        foreach (var order in orders)
            Console.WriteLine($"{order.OrderId} {order.CustomerName} {order.TotalPrice}");
    }
}
