using System;

namespace ExamApp.Models
{
    public class ExamResult
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string ExamId { get; set; }
        public int Score { get; set; }
        public DateTime SubmissionTime { get; set; }
    }
}
