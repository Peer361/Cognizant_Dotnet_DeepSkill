// Exercise 5: Decorator Pattern
interface Notifier { void send(); }
class EmailNotifier implements Notifier {
    public void send() { System.out.println("Email"); }
}
abstract class NotifierDecorator implements Notifier {
    protected Notifier notifier;
    NotifierDecorator(Notifier notifier) { this.notifier = notifier; }
}
class SMSNotifier extends NotifierDecorator {
    SMSNotifier(Notifier notifier) { super(notifier); }
    public void send() {
        notifier.send();
        System.out.println("SMS");
    }
}
class DecoratorTest {
    public static void main(String[] args) {
        Notifier n = new SMSNotifier(new EmailNotifier());
        n.send();
    }
}