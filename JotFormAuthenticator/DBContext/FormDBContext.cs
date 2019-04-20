using FormModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormAuthenticator.DBContext
{
    public class FormDBContext : DbContext
    {
        public FormDBContext(DbContextOptions<FormDBContext> options) : base(options) { }
        public DbSet<FormModel> FormModels { get; set; }
        public DbSet<FieldModel> FieldModels { get; set; }
        public DbSet<FormSubmission> FormSubmissions { get; set; }
        public DbSet<SubmissionFieldValues> SubmissionFieldValues { get; set; }
    }
}
