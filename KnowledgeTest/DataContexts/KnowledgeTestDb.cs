using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KnowledgeTest.Entities;

namespace KnowledgeTest.DataContexts
{
    public class KnowledgeTestDb:DbContext
    {
        public KnowledgeTestDb()
            : base("DefaultConnection")
        {

        }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}