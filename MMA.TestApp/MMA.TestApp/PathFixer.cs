using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.TestApp
{
    public class PathFixer
    {
        public string[] GetPathEntries()
        {
            return Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine).Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries) ;
        }

        public void SetPath(string[] entries)
        {
            var pathEntry = string.Join(";", entries);
            Environment.SetEnvironmentVariable("PATH", pathEntry, EnvironmentVariableTarget.Machine);
        }
    }
}
