// Exercise 2: Factory Method Pattern
interface Document { void open(); }
class WordDocument implements Document { public void open() { System.out.println("Word"); } }
class PdfDocument implements Document { public void open() { System.out.println("PDF"); } }
class ExcelDocument implements Document { public void open() { System.out.println("Excel"); } }
abstract class DocumentFactory { abstract Document createDocument(); }
class WordFactory extends DocumentFactory { Document createDocument() { return new WordDocument(); } }
class PdfFactory extends DocumentFactory { Document createDocument() { return new PdfDocument(); } }
class ExcelFactory extends DocumentFactory { Document createDocument() { return new ExcelDocument(); } }
class FactoryTest {
    public static void main(String[] args) {
        DocumentFactory f = new PdfFactory();
        Document d = f.createDocument();
        d.open();
    }
}