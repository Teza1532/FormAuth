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


        public override int SaveChanges()
        {
            var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

            AddedEntities.ForEach(E =>
            {
                E.Property("CreatedOn").CurrentValue = DateTime.Now;
            });

            var EditedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

            EditedEntities.ForEach(E =>
            {
                E.Property("UpdatedOn").CurrentValue = DateTime.Now;
            });

            return base.SaveChanges();
        }
    }

}

