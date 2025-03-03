

public class Student{

    private string studentName;
    private string studentId;

    public Student(string studentName, string studentId){
        this.studentName = studentName;
        this.studentId = studentId;
    }

    public void setStudentName(string studentName){
        this.studentName = studentName;
    }

    public string getStudentName(){
        return studentName;
    }

    public string getStudentId(){
        return studentId;
    }
}