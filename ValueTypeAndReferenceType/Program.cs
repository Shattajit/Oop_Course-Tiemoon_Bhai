

public class Program{
    public static void Main(string[] args){

        // value type

        int a = 10;
        int b = 20;

        Console.WriteLine("a is: "+ a);
        Console.WriteLine("b is: "+ b);

        b = a;

        Console.WriteLine("a is: "+ a);
        Console.WriteLine("b is: "+ b);


        // reference type

        Student student1 = new Student("Shataa", "b18");
        Student student2 = new Student("abit", "213");

        Console.WriteLine("Student1 name: "+student1.getStudentName());
        Console.WriteLine("Student2 name: "+student2.getStudentName());

        Student student3; // creating just a reference named as student3 but can't point to anything

        student3 = student2;

        Console.WriteLine("Student3 name: "+student3.getStudentName());

        student3.setStudentName("ghosh");

        Console.WriteLine("Student3 name: "+student3.getStudentName());
        Console.WriteLine("Student2 name: "+student2.getStudentName());

        changeValue(a);

        void changeValue(int a){
            a = 50;
        }

        Console.WriteLine("a is: "+a);

        changeValueofStudent(student1);

        void changeValueofStudent(Student student4){
            student4.setStudentName("xyz");
            student4 = null; // still student1's name exist because it just nullify the reference pointer. Didn't destroy the object!
        }

        Console.WriteLine("student1 name is: "+student1.getStudentName());

    }
}