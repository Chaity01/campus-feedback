using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DutchTreat.Data.Entities
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public string Value { get; set; }

    }
}
