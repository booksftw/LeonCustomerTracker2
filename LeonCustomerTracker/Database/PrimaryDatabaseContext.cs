using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using LeonCustomerTracker.Entities;

namespace LeonCustomerTracker.Database
{
    public class PrimaryDatabaseContext : DbContext
    {
        // ! Samples of Tables in DB
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
        public DbSet<Client> Clients { get; set; }

        public PrimaryDatabaseContext(DbContextOptions<PrimaryDatabaseContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PIGFLT3;Initial Catalog=leoncustomertracker;Integrated Security=True");
        }

        // Sample code for relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ! Sample of creating relationships
            //modelBuilder.Entity<ActionPlan>()
            //    .HasMany(a => a.Report)
            //    .WithOne();

            //// Start of Many to Many Relationship
            //modelBuilder.Entity<ActionPlanFoodItem>()
            //    .HasKey(af => new { af.ActionPlanId, af.FoodItemId });

            //modelBuilder.Entity<ActionPlanFoodItem>()
            //    .HasOne(af => af.ActionPlan)
            //    .WithMany(ap => ap.ActionPlanFoodItems)
            //    .HasForeignKey(af => af.ActionPlanId);

            //modelBuilder.Entity<ActionPlanFoodItem>()
            //    .HasOne(af => af.FoodItem)
            //    .WithMany(fi => fi.ActionPlanFoodItems)
            //    .HasForeignKey(af => af.FoodItemId);
        }


        // ! Sample of defining the tables and their relationships
        //public class ActionPlan
        //{
        //    [Key]
        //    public int Id { get; set; }
        //    [Required]
        //    public string Name { get; set; }
        //    public ICollection<Report> Report { get; set; } // FK
        //    public ICollection<FoodItem> FoodItem { get; set; }
        //    public ICollection<ActionPlanFoodItem> ActionPlanFoodItems { get; set; }
        //}

        //public class FoodItem
        //{
        //    [Key]
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public ICollection<ActionPlanFoodItem> ActionPlanFoodItems { get; set; }
        //}

        //public class ActionPlanFoodItem
        //{
        //    public int ActionPlanId { get; set; }
        //    public ActionPlan ActionPlan { get; set; }

        //    public int FoodItemId { get; set; }
        //    public FoodItem FoodItem { get; set; }
        //}
        
        // ! Sample Enum
        //public enum EffectiveRank
        //{
        //    _0 = 0,
        //    _1 = 1,
        //    _2 = 2,
        //    _3 = 3,
        //    _4 = 4,
        //    _5 = 5
        //}

        //public class Report
        //{
        //    [Key]
        //    public int Id { get; set; }
        //    public EffectiveRank effectiveRank { get; set; }
        //}
    }
}
