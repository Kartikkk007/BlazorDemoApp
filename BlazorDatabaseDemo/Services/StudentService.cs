using BlazorDatabaseDemo.Data;
using BlazorDatabaseDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDatabaseDemo.Services
{
    public class StudentService
    {
        private readonly ApplicationDBContext _context;

        public StudentService(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.AsNoTracking().ToListAsync();
        }
    }
}
