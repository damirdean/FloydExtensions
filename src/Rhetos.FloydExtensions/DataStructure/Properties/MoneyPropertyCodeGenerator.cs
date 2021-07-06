﻿using System.ComponentModel.Composition;
using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using Rhetos.Extensibility;

namespace Rhetos.FloydExtensions
{
	[Export(typeof(ITypeScriptSupportedType))]
    [Export(typeof(ITypeScriptGeneratorPlugin))]
    [ExportMetadata(MefProvider.Implements, typeof(MoneyPropertyInfo))]
    public class MoneyPropertyCodeGenerator : PropertyCodeGenerator, ITypeScriptSupportedType
    {
        public override string TypeScriptType => "number";
        public string PropertyType => "Money";


        public MoneyPropertyCodeGenerator(IDslModel dslModel) : base(dslModel)
        {
        }
    }
}