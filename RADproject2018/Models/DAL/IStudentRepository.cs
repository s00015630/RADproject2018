using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace RADproject2018.Models.DAL
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IList<Student>> GetStudentList();
        
        bool CheckStudentExists(int studentID);
        
    }
}