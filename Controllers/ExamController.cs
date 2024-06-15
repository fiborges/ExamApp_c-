using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamApp.Models;
using ExamApp.Services;

namespace ExamApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly ExamService _examService;

        public ExamController(ExamService examService)
        {
            _examService = examService;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> SubmitExam([FromBody] ExamSubmission submission)
        {
            if (submission == null || string.IsNullOrEmpty(submission.StudentId) || string.IsNullOrEmpty(submission.ExamId))
            {
                return BadRequest("Invalid submission.");
            }

            // Processar as respostas e calcular a pontuação (simulação aqui)
            Random random = new Random();
            int score = random.Next(0, 100);

            var result = new ExamResult
            {
                StudentId = submission.StudentId,
                ExamId = submission.ExamId,
                Score = score,
                SubmissionTime = DateTime.UtcNow
            };

            await _examService.SaveExamResultAsync(result);

            return Ok(new { Message = "Exam submitted successfully.", Result = result });
        }

        [HttpGet("results/{studentId}")]
        public async Task<IActionResult> GetResults(string studentId)
        {
            var results = await _examService.GetResultsByStudentIdAsync(studentId);
            return Ok(results);
        }
    }
}


