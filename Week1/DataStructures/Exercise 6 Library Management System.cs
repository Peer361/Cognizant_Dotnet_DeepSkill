using System;

class Book {
    public int BookId;
    public string Title;
    public string Author;
}

class Library {
    public static Book LinearSearch(Book[] books, string title) {
        foreach (var b in books)
            if (b.Title == title) return b;
        return null;
    }

    public static Book BinarySearch(Book[] books, string title) {
        int l = 0, r = books.Length - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            int cmp = books[m].Title.CompareTo(title);
            if (cmp == 0) return books[m];
            else if (cmp < 0) l = m + 1;
            else r = m - 1;
        }
        return null;
    }

    public static void Main() {
        Book[] books = {
            new Book { BookId = 1, Title = "Alpha", Author = "Author1" },
            new Book { BookId = 2, Title = "Beta", Author = "Author2" }
        };

        var res1 = LinearSearch(books, "Alpha");
        var res2 = BinarySearch(books, "Beta");

        Console.WriteLine(res1 != null ? "Linear: Found" : "Not Found");
        Console.WriteLine(res2 != null ? "Binary: Found" : "Not Found");
    }
}
