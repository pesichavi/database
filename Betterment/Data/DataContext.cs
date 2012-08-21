using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Data
{
   public class DataContext : DbContext
    {
        public DataContext()
            : base("name=ApplicationServices")  
        {

        }

    }
}
