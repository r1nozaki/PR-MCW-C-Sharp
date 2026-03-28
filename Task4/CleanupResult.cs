using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class CleanupResult
    {
        public int DeletedFilesCount { get; set; }
        public long TotalSizeDeleted { get; set; }
        public double SizeInKb => TotalSizeDeleted / 1024.0;
    }
}
