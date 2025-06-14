using System;

class Employee {
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;
}

class EmployeeSystem {
    Employee[] employees = new Employee[100];
    int count = 0;

    public void Add(Employee e) {
        employees[count++] = e;
    }

    public Employee Search(int id) {
        for (int i = 0; i < count; i++)
            if (employees[i].EmployeeId == id) return employees[i];
        return null;
    }

    public void Traverse() {
        for (int i = 0; i < count; i++)
            Console.WriteLine($"{employees[i].EmployeeId} {employees[i].Name}");
    }

    public void Delete(int id) {
        for (int i = 0; i < count; i++) {
            if (employees[i].EmployeeId == id) {
                for (int j = i; j < count - 1; j++)
                    employees[j] = employees[j + 1];
                count--;
                break;
            }
        }
    }

    public static void Main() {
        EmployeeSystem sys = new EmployeeSystem();
        sys.Add(new Employee { EmployeeId = 1, Name = "Alice", Position = "Dev", Salary = 50000 });
        sys.Add(new Employee { EmployeeId = 2, Name = "Bob", Position = "QA", Salary = 40000 });
        sys.Delete(2);
        sys.Traverse();
    }
}
