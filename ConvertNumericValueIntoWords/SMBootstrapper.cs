using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using ConvertNumericValueIntoWords.Repository;
using StructureMap.Web;

namespace ConvertNumericValueIntoWords
{
    public class SMBootstrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ObjectRegistry>();
                x.Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                });
            });
        }
    }
    public class ObjectRegistry : Registry
    {
        // NOTE: Any types from the WebApp that follow the default conventions are wired up by default
        public ObjectRegistry()
        {
            For<INumberConverter>().HttpContextScoped().Use<NumberConverter>();

        }
    }
}