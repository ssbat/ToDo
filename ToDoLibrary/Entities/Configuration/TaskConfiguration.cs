using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Task = ToDoLibrary.Entities.Task;


namespace ToDoLibrary.Entities.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Time)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
        }
    }
}
