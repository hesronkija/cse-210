using static System.Console;
using MySql.Data.MySqlClient;

public class Enrollment : Connection
{
    public void DisplayEnrollments()
    {
        using (MySqlConnection connection = OpenConnection())
        {
            string query = "SELECT first_name, last_name, c.course_code, c.course_title, sect.section_no, sem.term, sem.year " + 
                            "FROM student s " + 
                            "INNER JOIN enrollment en ON s.student_id = en.student_id " +
                            "INNER JOIN section sect ON en.sect_id = sect.sect_id " +
                            "INNER JOIN course c ON sect.course_code = c.course_code " +
                            "INNER JOIN semester sem ON sect.semester_id = sem.semester_id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                WriteLine("Enrolments: ");
                while (reader.Read())
                {
                    string studentName = $"{reader.GetString("first_name")} {reader.GetString("last_name")}";
                    string courseCode = reader.GetString("course_code");
                    string courseTitle = reader.GetString("course_title");
                    int sectionNumber = reader.GetInt32("section_no");
                    string term = reader.GetString("term");
                    int year = reader.GetInt32("year");                 

                    WriteLine(studentName + " enrolled in ");
                    WriteLine($"\t{courseCode}-{courseTitle}: section({sectionNumber}) {term} {year}"); 
                }
            }
        }
    }

    public void EnrollStudent()
    {
        
    }

}