using System;

class Task {
    public int TaskId;
    public string TaskName;
    public string Status;
    public Task Next;
}

class TaskList {
    Task head;

    public void Add(Task t) {
        t.Next = head;
        head = t;
    }

    public Task Search(int id) {
        Task current = head;
        while (current != null) {
            if (current.TaskId == id) return current;
            current = current.Next;
        }
        return null;
    }

    public void Traverse() {
        Task current = head;
        while (current != null) {
            Console.WriteLine($"{current.TaskId} {current.TaskName} {current.Status}");
            current = current.Next;
        }
    }

    public void Delete(int id) {
        Task current = head, prev = null;
        while (current != null && current.TaskId != id) {
            prev = current;
            current = current.Next;
        }
        if (current == null) return;
        if (prev == null) head = head.Next;
        else prev.Next = current.Next;
    }

    public static void Main() {
        TaskList list = new TaskList();
        list.Add(new Task { TaskId = 1, TaskName = "Setup", Status = "Pending" });
        list.Add(new Task { TaskId = 2, TaskName = "Code", Status = "In Progress" });
        list.Delete(1);
        list.Traverse();
    }
}
