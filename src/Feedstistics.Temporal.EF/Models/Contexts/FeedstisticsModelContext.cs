//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.1.2.0
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Feedstistics.EF.Models.Context
{
   /// <inheritdoc/>
   public partial class FeedstisticsModelContext : DbContext
   {
      #region DbSets

      /// <summary>
      /// Repository for global::Feedstistics.EF.Models.Entity.Statistics - Statistics
      /// </summary>
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Feedstistics.EF.Models.Entity.Statistics> Statistics { get; set; }

      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Name=FeedstisticsModelContext";

      /// <summary>
      ///     <para>
      ///         Initializes a new instance of the <see cref="T:Microsoft.EntityFrameworkCore.DbContext" /> class using the specified options.
      ///         The <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" /> method will still be called to allow further
      ///         configuration of the options.
      ///     </para>
      /// </summary>
      /// <param name="options">The options for this context.</param>
      public FeedstisticsModelContext(DbContextOptions<FeedstisticsModelContext> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <summary>
      ///     Override this method to further configure the model that was discovered by convention from the entity types
      ///     exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
      ///     and re-used for subsequent instances of your derived context.
      /// </summary>
      /// <remarks>
      ///     If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
      ///     then this method will not be run.
      /// </remarks>
      /// <param name="modelBuilder">
      ///     The builder being used to construct the model for this context. Databases (and other extensions) typically
      ///     define extension methods on this object that allow you to configure aspects of the model that are specific
      ///     to a given database.
      /// </param>
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::Feedstistics.EF.Models.Entity.Statistics>()
                     .ToTable("Statistics")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Feedstistics.EF.Models.Entity.Statistics>()
                     .Property(t => t.Id)
                     .ValueGeneratedOnAdd()
                     .IsRequired();
         modelBuilder.Entity<global::Feedstistics.EF.Models.Entity.Statistics>()
                     .Property(t => t.FeedProviderName)
                     .HasMaxLength(50)
                     .HasColumnType("NVARCHAR(50)")
                     .IsRequired();
         modelBuilder.Entity<global::Feedstistics.EF.Models.Entity.Statistics>()
                     .Property(t => t.StatisticName)
                     .HasMaxLength(50)
                     .HasColumnType("NVARCHAR(50)")
                     .IsRequired();
         modelBuilder.Entity<global::Feedstistics.EF.Models.Entity.Statistics>()
                     .Property(t => t.SampleDateTime)
                     .IsRequired();

         OnModelCreatedImpl(modelBuilder);
      }
   }
}