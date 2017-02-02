﻿namespace Entitas.CodeGenerator {

    public class AddFileHeaderPostProcessor : ICodeGenFilePostProcessor {

        public const string AUTO_GENERATED_HEADER_FORMAT =
@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by {0}.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
";

        public void PostProcess(CodeGenFile[] files) {
            foreach(var file in files) {
                file.fileContent = string.Format(AUTO_GENERATED_HEADER_FORMAT, file.generatorName) + file.fileContent;
            }
        }
    }
}