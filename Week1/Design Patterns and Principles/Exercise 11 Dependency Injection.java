// Exercise 11: Dependency Injection
interface CustomerRepository { String findCustomerById(int id); }
class CustomerRepositoryImpl implements CustomerRepository {
    public String findCustomerById(int id) { return \"Customer \" + id; }
}
class CustomerService {
    private CustomerRepository repo;
    CustomerService(CustomerRepository repo) { this.repo = repo; }
    void find(int id) { System.out.println(repo.findCustomerById(id)); }
}
class DIExample {
    public static void main(String[] args) {
        CustomerRepository repo = new CustomerRepositoryImpl();
        CustomerService service = new CustomerService(repo);
        service.find(101);
    }
}