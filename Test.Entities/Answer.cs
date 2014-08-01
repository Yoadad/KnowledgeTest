using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeTest.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Answer")]
        public string Name { get; set; }
        public bool IsCorrect { get; set; }
        public bool Value { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
