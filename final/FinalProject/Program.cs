using static System.Console;

class Program
{
    static void Main()
    {
        DisplayMenu();
    }

    static Student student = new Student();
    static Course course = new Course();
    static Faculty faculty = new Faculty();
    static Semester semester = new Semester();
    static Enrollment enrollment = new Enrollment();
    static void DisplayMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Management Systems =========");
            WriteLine("1. Student Management");
            WriteLine("2. Course Management");
            WriteLine("3. Enrollment Management");
            WriteLine("4. Faculty Management");
            WriteLine("5. Semester Management");
            WriteLine("6. Exit");
            WriteLine();
            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    StudentManagementMenu();
                    break;
                case 2:
                    CourseManagementMenu();
                    break;
                case 3:
                    EnrollmentManagementMenu();
                    break;
                case 4:
                    FacultyManagementMenu();
                    break;
                case 5:
                    SemesterManagementMenu();
                    break;
                case 6:
                    WriteLine("Exiting program...");
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        } while (choice != 6);
    }
    //Student management
    static void StudentManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Student Management =========");
            WriteLine("1. Add Student");
            WriteLine("2. Display Students");
            WriteLine("3. Update Student");
            WriteLine("4. Delete Student");
            WriteLine("5. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    AddStudent();
                    break;
                case 2:
                    Clear();
                    DisplayStudents();
                    break;
                case 3:
                    Clear();
                    UpdateStudent();
                    break;
                case 4:
                    DeleteStudent();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }
    static void AddStudent()
    {
        student.AddStudent();
    }
    static void DisplayStudents()
    {
        student.DisplayStudents();
    }
    static void DeleteStudent()
    {
        student.DeleteStudent();
    }
    static void UpdateStudent()
    {
        student.UpdateStudent();
    }

    //Course management
    static void CourseManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Course Management =========");
            WriteLine("1. Add Course");
            WriteLine("2. Display Courses");
            WriteLine("3. Update Course");
            WriteLine("4. Delete Course");
            WriteLine("5. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    AddCourse();
                    break;
                case 2:
                    Clear();
                    DisplayCourses();
                    break;
                case 3:
                    Clear();
                    UpdateCourse();
                    break;
                case 4:
                    DeleteCourse();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }
    static void AddCourse()
    {
        course.AddCourse();
    }
    static void DisplayCourses()
    {
        course.DisplayCourses();
    }
    static void UpdateCourse()
    {
        course.UpdateCourse();
    }
    static void DeleteCourse()
    {
        course.DeleteCourse();
    }
    static void EnrollmentManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Enrollment Management =========");
            WriteLine("1. Enroll Student");
            WriteLine("2. Display Enrollments");
            WriteLine("3. Withdraw Student");
            WriteLine("4. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    EnrollStudent();
                    break;
                case 2:
                    DisplayEnrollments();
                    break;
                case 3:
                    //WithdrawStudent();
                    break;
                case 4:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        } while (choice != 4);
    }
    static void DisplayEnrollments()
    {
        enrollment.DisplayEnrollments();
    }
    static void EnrollStudent()
    {
        enrollment.EnrollStudent();
    }

    static void FacultyManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Faculty Management =========");
            WriteLine("1. Add Faculty");
            WriteLine("2. Display Faculty");
            WriteLine("3. Update Faculty");
            WriteLine("4. Delete Faculty");
            WriteLine("5. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    AddFaculty();
                    break;
                case 2:
                    DisplayFaculties();
                    break;
                case 3:
                    UpdateFaculty();
                    break;
                case 4:
                    DeleteFaculty();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }
    static void AddFaculty()
    {
        faculty.AddFaculty();
    }
    static void DisplayFaculties()
    {
        faculty.DisplayFaculties();
    }
    static void UpdateFaculty()
    {
        faculty.UpdateFaculty();
    }
    static void DeleteFaculty()
    {
        faculty.DeleteFaculty();
    }
    static void SemesterManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Semester Management =========");
            WriteLine("1. Add Semester");
            WriteLine("2. Display Semesters");
            WriteLine("3. Update Semester");
            WriteLine("4. Delete Semester");
            WriteLine("5. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    AddSemester();
                    break;
                case 2:
                    DisplaySemesters();
                    break;
                case 3:
                    UpdateSemester();
                    break;
                case 4:
                    DeleteSemester();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }

    static void AddSemester()
    {
        semester.AddSemester();
    }
    static void DisplaySemesters()
    {
        semester.DisplaySemesters();
    }
    static void UpdateSemester()
    {
        semester.UpdateSemester();
    }
    static void DeleteSemester()
    {
        semester.DeleteSemester();
    }


}
