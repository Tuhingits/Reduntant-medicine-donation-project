using Data;
using Framework;
using Framwork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framwork.Reopositiry
{
    public class MedicineRepository : Repository<Medicine, int, FrameworkContext>,IMedicineRepository
    {
        public MedicineRepository(FrameworkContext frameworkContext ) :base( frameworkContext)
        {

        }
    }
}
