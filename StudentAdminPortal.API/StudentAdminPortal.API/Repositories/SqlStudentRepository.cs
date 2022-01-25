using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            //return context.Student.ToList();  if Domain models are not there it is ok tu use but if domain model includes then data from others tables will not come
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();


        }
    }
}
