using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Services.Interfaces
{
    public interface IFileService
    {
        string ReadFile(string path, string template);
    }
}
