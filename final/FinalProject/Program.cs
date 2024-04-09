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
    static Grading grading = new Grading();

    static void DisplayMenu()
    {
        int choice;
        do
        {
            WriteLine("========= Welcome to Academic Portal =========");
            WriteLine("1. Grading ");
            WriteLine("2. Management Systems(For Authorized Personel)");
            WriteLine("3. Exit");
            WriteLine();
            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    Grading();
                    break;
                case 2:
                    Clear();
                    if (AuthenticateUser())
                    {
                        Write("Logging in");
                        Animation(3);
                        Clear();
                        DisplayManagementMenu();
                    }
                    else
                    {
                        Write("Invalid username or password. ");
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Access denied.\n");
                        ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case 3:
                    WriteLine("Exiting program...");
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        } while (choice != 6);
    }
    static bool AuthenticateUser()
    {
        Authentication auth = new Authentication();
        Write("Enter username: ");
        string username = ReadLine();
        Write("Enter password: ");
        string password = ReadLine();
        return auth.Authenticate(username, password);
    }
    static void Animation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Write(".");
            Thread.Sleep(250);
            Write("\b \b");
            Write("..");
            Thread.Sleep(250);
            Write("\b\b  \b\b");
            Write("...");
            Thread.Sleep(250);
            Write("\b\b\b   \b\b\b");
            Write(" ");
            Thread.Sleep(250);
            Write("\b \b");
        }
    }
    static void DisplayManagementMenu()
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
            WriteLine("6. Back to main Menu");
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

    // Gdrading
    static void Grading()
    {
        int choice;

        do
        {
            WriteLine("========= Grading =========");
            WriteLine("1. Grade a Student");
            WriteLine("2. Display grades");
            WriteLine("3. Change Grade");
            WriteLine("4. Delete Grade");
            WriteLine("5. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    grading.AddGrade();
                    break;
                case 2:
                    Clear();
                    grading.DisplayGrades();
                    break;
                case 3:
                    grading.UpdateGrade();
                    break;
                case 4:
                    grading.DeleteGrade();
                    break;
                case 5:
                    Clear();
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
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
                    student.AddStudent();
                    break;
                case 2:
                    Clear();
                    student.DisplayStudents();
                    break;
                case 3:
                    Clear();
                    student.UpdateStudent();
                    break;
                case 4:
                    student.DeleteStudent();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
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
                    course.AddCourse();
                    break;
                case 2:
                    Clear();
                    course.DisplayCourses();
                    break;
                case 3:
                    Clear();
                    course.UpdateCourse();
                    break;
                case 4:
                    course.DeleteCourse();
                    break;
                case 5:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }

    //Enrollment Management
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
                    Clear();
                    enrollment.EnrollStudent();
                    break;
                case 2:
                    Clear();
                    enrollment.DisplayEnrollments();
                    break;
                case 3:
                    Clear();
                    enrollment.WithdrawStudent();
                    break;
                case 4:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        } while (choice != 4);
    }

    //Faculty Management
    static void FacultyManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Faculty Management =========");
            WriteLine("1. Add Faculty");
            WriteLine("2. Display Faculty");
            WriteLine("3. Update Faculty");
            WriteLine("4. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    faculty.AddFaculty();
                    break;
                case 2:
                    Clear();
                    faculty.DisplayFaculties();
                    break;
                case 3:
                    Clear();
                    faculty.UpdateFaculty();
                    break;
                case 4:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }

    // Semester management
    static void SemesterManagementMenu()
    {
        int choice;

        do
        {
            WriteLine("========= Semester Management =========");
            WriteLine("1. Add Semester");
            WriteLine("2. Display Semesters");
            WriteLine("3. Update Semester");
            WriteLine("4. Back to Main Menu");
            WriteLine();

            Write("Enter your choice: ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    Clear();
                    semester.AddSemester();
                    break;
                case 2:
                    Clear();
                    semester.DisplaySemesters();
                    break;
                case 3:
                    Clear();
                    semester.UpdateSemester();
                    break;
                case 4:
                    break;
                default:
                    WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        } while (choice != 5);
    }

}
