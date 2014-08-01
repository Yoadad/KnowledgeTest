using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KnowledgeTest.Entities
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name="Question")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public QuestionType Type {get;set;}
        public int TestId { get; set; }
        public Test Test { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
