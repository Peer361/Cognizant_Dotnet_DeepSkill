// Exercise 3: Builder Pattern
class Computer {
    private String cpu, ram, storage;
    private Computer(Builder b) {
        this.cpu = b.cpu;
        this.ram = b.ram;
        this.storage = b.storage;
    }
    static class Builder {
        private String cpu, ram, storage;
        Builder setCpu(String cpu) { this.cpu = cpu; return this; }
        Builder setRam(String ram) { this.ram = ram; return this; }
        Builder setStorage(String storage) { this.storage = storage; return this; }
        Computer build() { return new Computer(this); }
    }
    public String toString() {
        return cpu + " " + ram + " " + storage;
    }
}
class BuilderTest {
    public static void main(String[] args) {
        Computer c = new Computer.Builder().setCpu("i5").setRam("8GB").build();
        System.out.println(c);
    }
}