using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Models
{
    public class Employee
    {
        [Key]
        //khai báo các thuộc tính= phạm vi truy cập, kiểu dl, tên thuộc tính
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        
        
        
        
        
        
    }
}