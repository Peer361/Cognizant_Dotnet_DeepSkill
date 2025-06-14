// Exercise 10: MVC Pattern
class Student {
    String name;
    int id;
    String grade;
    Student(String name, int id, String grade) {
        this.name = name;
        this.id = id;
        this.grade = grade;
    }
}
class StudentView {
    void display(Student student) {
        System.out.println(student.name + \" \" + student.id + \" \" + student.grade);
    }
}
class StudentController {
    private Student student;
    private StudentView view;
    StudentController(Student student, StudentView view) {
        this.student = student;
        this.view = view;
    }
    void updateView() { view.display(student); }
}
class MVCTest {
    public static void main(String[] args) {
        Student s = new Student(\"John\", 1, \"A\");
        StudentView v = new StudentView();
        StudentController c = new StudentController(s, v);
        c.updateView();
    }
}