using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebAppsConfText
{
    public class TextConfigurationSource:IConfigurationSource
    {
        public string FilePath;

        public TextConfigurationSource(string filepath)
        {
            FilePath = filepath;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            var filePath = builder.GetFileProvider().GetFileInfo(FilePath).PhysicalPath;
            return new TextConfigurationProvider(filePath);
        }
    }
}
