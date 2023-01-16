namespace DAL;
using System.Data;
using Model;
using MySql.Data.MySqlClient;

public class StudentData
{
    public static string conString=@"server=localhost;port=3306;user=root; password=Shubham@0154;database=college";
//------------GetAllStudents------
    public static List<Student>GetAllStudents()
    {
        List<Student> allNotes = new List<Student>();

        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            String query ="select * from student";
            DataSet ds = new DataSet();
            MySqlCommand cmd =  new MySqlCommand(query,con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                Student student = new Student
                {
                    id=int.Parse(row["id"].ToString()),
                    name=row["name"].ToString(),
                    course=row["course"].ToString()
                };
                allNotes.Add(student);            
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allNotes;
    } 
//------------InsertNewStudent------------
    public static void InsertNewStudent(Student student)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try 
        {
            con.Open();
            string query =$"insert into student(name,course) values('{student.name}','{student.course}')";
            MySqlCommand command = new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
//---------DeleteStudent-----------
    public static void DeleteStudent(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try{
            con.Open();                                         //#opne the connection
            string query ="delete from student where id =" + id; //# write the query
            MySqlCommand command = new MySqlCommand(query,con);  //#add query to Database
            command.ExecuteNonQuery(); 
            con.Close();  //# Cloing the connection
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

}