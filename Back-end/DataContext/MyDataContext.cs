using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalHub.DataContext
{
    public class MyDataContext : DbContext
    {

        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options)
        {

        }

        public DbSet<Assessments> Assessments { get; set; }
        public DbSet<Assessments_Questions> Assessments_Questions { get; set; }
        public DbSet<Assessment_Questions_Relation> Assessment_Questions_Relations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment_enrols> Assessment_Enrols { get; set; }
        public DbSet<Assessment_Options> Assessment_Options {get;set;}
        public DbSet<Assessment_text> Assessment_Texts {get;set;}
        public DbSet<Assessment_True_False> Assessment_True_Falses {get;set;}
        public DbSet<Assesstment_Match> Assesstment_Matches {get;set;}
        public DbSet<Assessment_Answer> Assessment_Answers {get;set;}



    }
}