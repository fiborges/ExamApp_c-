using ExamApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Services
{
    public class ExamService
    {
        private readonly ExamDbContext _context;

        public ExamService(ExamDbContext context)
        {
            _context = context;
        }

        public async Task SaveExamResultAsync(ExamResult result)
        {
            _context.ExamResults.Add(result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ExamResult>> GetResultsByStudentIdAsync(string studentId)
        {
            return await _context.ExamResults.Where(r => r.StudentId == studentId).ToListAsync();
        }
    }
}

