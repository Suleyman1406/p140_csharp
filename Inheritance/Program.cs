// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Person person = new Person("sueuman", "asd", 123);

//person.PrintInfo();


//Student student1 = new Student("xumar", "seferli", 0, 77);

//Console.WriteLine(student1.Name);
//student1.PrintInfo();


//Teacher teacher = new Teacher("suleyman", "dada", 0, 0);


//teacher.MakeExam();


//Teacher teacher1 = new Teacher("Cahandar", "asd", 0, 0);


//teacher1.MakeExam();
//teacher1.PrintInfo();

//Person teacher = new Teacher("Cahandar", "asd", 0, 1);

Teacher teacher1 = new Teacher("t1", "asd", 0, 0);
Teacher teacher2 = new Teacher("t2", "asd2", 0, 0);
Student student1 = new Student("st1", "st1", 0, 99);
Student student2 = new Student("st2", "st1", 0, 99);

Person[] people = {teacher1, teacher2, student1, student2 };


foreach(Person person in people)
{
    person.PrintInfo(); 
}

//teacher.PrintInfo();
//student.PrintInfo();





