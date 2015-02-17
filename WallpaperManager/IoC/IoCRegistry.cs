﻿using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MikeRobbins.WallpaperManager.Interfaces;
using StructureMap.Configuration.DSL;

namespace MikeRobbins.WallpaperManager.IoC
{
    public class IoCRegistry : Registry
    {
        public IoCRegistry()
        {
            //   var container = new Container();

            For<IFileAccess>().Use<FileAccess>();
        }
    }
}