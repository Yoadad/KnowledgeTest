using KnowledgeTest.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeTest.DataContexts
{
    public class IdentityDb: IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
                : base("DefaultConnection")
            {
            }
    }
}