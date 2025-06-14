// Exercise 8: Strategy Pattern
interface PaymentStrategy { void pay(); }
class CreditCardPayment implements PaymentStrategy {
    public void pay() { System.out.println("Credit Card"); }
}
class PayPalPayment implements PaymentStrategy {
    public void pay() { System.out.println("PayPal"); }
}
class PaymentContext {
    private PaymentStrategy strategy;
    public void setStrategy(PaymentStrategy strategy) { this.strategy = strategy; }
    public void pay() { strategy.pay(); }
}
class StrategyTest {
    public static void main(String[] args) {
        PaymentContext ctx = new PaymentContext();
        ctx.setStrategy(new CreditCardPayment());
        ctx.pay();
        ctx.setStrategy(new PayPalPayment());
        ctx.pay();
    }
}