namespace webapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DAL;
using Model;


[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Student> GetAllStudents()
    {
       List<Student> students=StudentData.GetAllStudents();

       return students;     
    }


//------

[HttpPost]
[EnableCors()]
public IActionResult InsertNewStudent(Student student)
{
    StudentData.InsertNewStudent(student);
    return Ok(new { message ="User created"});
}

//--
[Route("{id}")]
[HttpDelete]
[EnableCors()]
public ActionResult<Student> DeleteStudent(int id)
{
    StudentData.DeleteStudent(id);
    return Ok(new { message = "Student delete"});
}

}