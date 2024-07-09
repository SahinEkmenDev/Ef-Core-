﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EF_Core_CodeFirst
{
    public class Initializer
    {

        public static IConfigurationRoot Configuration;



        public static  void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile
               ("appsetting.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
        }
    }
}
