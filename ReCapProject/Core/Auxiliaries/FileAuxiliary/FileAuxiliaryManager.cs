using Core.Auxiliaries.GuidAuxiliary;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auxiliaries.FileAuxiliary
{
    internal class FileAuxiliaryManager : IFileAuxiliary
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                string extension = Path.GetExtension(file.FileName);
                string guid = GuidCreator.CreateGuid();
                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }
    }
}
