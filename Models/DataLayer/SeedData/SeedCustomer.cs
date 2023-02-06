using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleEmployeeApp.Models.DomainModels;

namespace BankAccountApp.Models.DataLayer.SeedData
{
    internal class SeedCustomer : IEntityTypeConfiguration<T>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                );
        }
    }
}
}
