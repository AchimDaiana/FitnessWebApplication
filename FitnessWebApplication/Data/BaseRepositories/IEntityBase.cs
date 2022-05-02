using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.BaseRepositories
{
    public interface IEntityBase
    {
        int Id { get; set; }
    }
}
