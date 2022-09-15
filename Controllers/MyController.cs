using Microsoft.AspNetCore.Mvc;
namespace Exercise9.Controllers;
[ApiController]
[Route("[controller]")]

    public class MyController: ControllerBase
    {
        [HttpGet()]
        public string GetFirst(){
            return "I am the first test";
        }
        [HttpGet("second")]
        public string GetSecond(){
            return "I am the second get method";
        }
        [HttpGet("third/{fname}")]
        public string GetThird(string fname){
            return "Hello "+fname;
        }

        [HttpPost]
        public string PostData(Student objectStudent){
            return "Hello "+objectStudent.Fname+" "+objectStudent.Lname;
        }
        [HttpPut("{id}")]
        public string PutData(int id,Student objectStuden){
            return "Student: "+id+ "new Fname="+objectStuden.Fname+
            " new Lname="+objectStuden.Lname;
        }
        
    }
