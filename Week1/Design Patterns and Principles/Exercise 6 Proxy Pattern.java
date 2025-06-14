// Exercise 6: Proxy Pattern
interface Image { void display(); }
class RealImage implements Image {
    private String filename;
    RealImage(String filename) { this.filename = filename; load(); }
    void load() { System.out.println("Loading " + filename); }
    public void display() { System.out.println("Displaying " + filename); }
}
class ProxyImage implements Image {
    private RealImage realImage;
    private String filename;
    ProxyImage(String filename) { this.filename = filename; }
    public void display() {
        if (realImage == null) {
            realImage = new RealImage(filename);
        }
        realImage.display();
    }
}
class ProxyTest {
    public static void main(String[] args) {
        Image img = new ProxyImage("test.jpg");
        img.display();
        img.display();
    }
}