//Person person = new Person("suleyman", new Address("az", "bak", "asd"));

//person.PrintAddressInfo();

Classroom classroom = new Classroom("P140");

classroom.PrintStudentsInfo();

classroom.PrintStudentCount();


classroom.AddStudent(new Student("Huseynova", 80));
classroom.AddStudent(new Student("Xumar", 90));
classroom.AddStudent(new Student("Rustem", 100));

classroom.PrintStudentCount();
classroom.PrintStudentsInfo();