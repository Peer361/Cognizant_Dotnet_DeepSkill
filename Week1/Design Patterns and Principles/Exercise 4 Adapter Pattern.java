// Exercise 4: Adapter Pattern
interface PaymentProcessor { void process(); }
class PayPal { void make() { System.out.println("PayPal"); } }
class Stripe { void execute() { System.out.println("Stripe"); } }
class PayPalAdapter implements PaymentProcessor {
    private PayPal p = new PayPal();
    public void process() { p.make(); }
}
class StripeAdapter implements PaymentProcessor {
    private Stripe s = new Stripe();
    public void process() { s.execute(); }
}
class AdapterTest {
    public static void main(String[] args) {
        PaymentProcessor p = new PayPalAdapter();
        p.process();
    }
}