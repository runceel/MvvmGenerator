using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmGenerator
{
    [Generator]
    public class AutoImplementNotifyPropertyChangedGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("hello", SourceText.From($@"
using System;
namespace MvvmGenerator
{{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AutoNotifyAttribute : Attribute
    {{
        public string PropertyName {{ get; }}

        public AutoNotifyAttribute() {{}}
        public AutoNotifyAttribute(string propertyName) {{ PropertyName = propertyName; }}
    }}
}}", Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AutoNotifyAttribute : Attribute
    {

    }
}
