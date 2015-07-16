﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class AWSQueryStructureUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 11 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 14 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Object\r\n    /// </summary>  \r\n    public class ");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Unmarshaller : IUnmarshaller<");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", XmlUnmarshallerContext>, IUnmarshaller<");
            
            #line 16 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(", JsonUnmarshallerContext>\r\n    {\r\n        /// <summary>\r\n        /// Unmarshalle" +
                    "r the response from the service to the response class.\r\n        /// </summary>  " +
                    "\r\n        /// <param name=\"context\"></param>\r\n        /// <returns></returns>\r\n " +
                    "       public ");
            
            #line 23 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Unmarshall(XmlUnmarshallerContext context)\r\n        {\r\n            ");
            
            #line 25 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" unmarshalledObject = new ");
            
            #line 25 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
");
            
            #line 36 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

    if(this.Structure != null)
    {
        foreach (var member in this.Structure.Members)
        {
            var testExpression= GeneratorHelpers.DetermineAWSQueryTestExpression(member);

            
            #line default
            #line hidden
            this.Write("                    if (context.TestExpression(\"");
            
            #line 43 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(testExpression));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                    {\r\n                        var unmarshaller" +
                    " = ");
            
            #line 45 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 46 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

            if (member.IsMap || member.IsList)
            {

            
            #line default
            #line hidden
            this.Write("                        var item = unmarshaller.Unmarshall(context);\r\n           " +
                    "             unmarshalledObject.");
            
            #line 51 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(".Add(item);\r\n");
            
            #line 52 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                        unmarshalledObject.");
            
            #line 57 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n");
            
            #line 58 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("                        continue;\r\n                    }\r\n");
            
            #line 63 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write(@"                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name=""context""></param>
        /// <returns></returns>
        public ");
            
            #line 82 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" Unmarshall(JsonUnmarshallerContext context)\r\n        {\r\n            return null;" +
                    "\r\n        }\r\n\r\n\r\n");
            
            #line 88 "C:\Codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\AWSQueryStructureUnmarshaller.tt"

    this.AddStructureSingletonMethod();

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
