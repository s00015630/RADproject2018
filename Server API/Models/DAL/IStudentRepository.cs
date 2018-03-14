using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Server_API.Models.DAL;
namespace Server_API.Models.DAL
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IList<Student>> GetStudentList();
        
        bool CheckStudentExists(int studentID);
        
    }
}