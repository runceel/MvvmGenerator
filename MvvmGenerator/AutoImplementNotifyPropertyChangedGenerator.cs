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
    public static class Greeter
    {{
        public static void Greet() => Console.WriteLine(""Hello world"");
    }}
}}", Encoding.UTF8));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}
