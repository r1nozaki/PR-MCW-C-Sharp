using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class CacheCleaner
    {
        public CleanupResult CleanRecursive(string path)
        {
            CleanupResult result = new CleanupResult();
            InternalRecursive(path, result);
            return result;
        }

        private void InternalRecursive(string currentDir, CleanupResult result)
        {
            string[] files = Directory.GetFiles(currentDir);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                result.TotalSizeDeleted += fi.Length;

                File.Delete(file);
                result.DeletedFilesCount++;
            }
            string[] subDirs = Directory.GetDirectories(currentDir);
            foreach (string dir in subDirs)
            {
                InternalRecursive(dir, result);
            }
        }
        public CleanupResult CleanNonRecursive(string path)
        {
            CleanupResult result = new CleanupResult();

            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string file in allFiles)
            {
                FileInfo fi = new FileInfo(file);
                result.TotalSizeDeleted += fi.Length;

                File.Delete(file);
                result.DeletedFilesCount++;
            }

            return result;
        }
    }
}
