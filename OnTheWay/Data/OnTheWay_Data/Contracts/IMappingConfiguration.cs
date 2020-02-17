using Microsoft.EntityFrameworkCore;

namespace OnTheWay_Data.Contracts
{
    internal interface IMappingConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}