
// Exercise 11: Dependency Injection
public interface CustomerRepository {
    public String findCustomerById(int id);
}

// Concrete repository implementation
class CustomerRepositoryImpl implements CustomerRepository {
    @Override
    public String findCustomerById(int id) {
        if (id <= 0) {
            throw new IllegalArgumentException("Invalid customer ID: " + id);
        }
        return String.format("Customer %d", id);
    }
}

// Service class using dependency injection
class CustomerService {
    private final CustomerRepository repo;

    // Constructor injection
    CustomerService(CustomerRepository repo) {
        this.repo = repo;
    }

    public void find(int id) {
        System.out.println(repo.findCustomerById(id));
    }
}

// Main class to test dependency injection
public class DIExample {
    public static void main(String[] args) {
        try {
            CustomerRepository repo = new CustomerRepositoryImpl();
            CustomerService service = new CustomerService(repo);
            service.find(101); // Output: Customer 101
            // Test invalid input
            service.find(-1); // Throws exception
        } catch (IllegalArgumentException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
