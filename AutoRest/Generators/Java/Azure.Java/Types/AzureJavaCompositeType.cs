﻿using Microsoft.Rest.Generator.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest.Generator.Java.TemplateModels;
using Microsoft.Rest.Generator.Utilities;
using Microsoft.Rest.Generator.Azure;

namespace Microsoft.Rest.Generator.Java
{
    public class AzureJavaCompositeType : JavaCompositeType
    {
        protected string _azureRuntimePackage = "com.microsoft.azure";

        public AzureJavaCompositeType(JavaCompositeType javaCompositeType)
            : this(javaCompositeType.Package.Replace(".models", ""))
        {
            this.LoadFrom(javaCompositeType);
        }

        public AzureJavaCompositeType(CompositeType compositeType, string package)
            : this(package)
        {
            this.LoadFrom(compositeType);
        }

        public AzureJavaCompositeType(string package)
            : base(package)
        {
            this._package = package;
        }

        public override string Package
        {
	        get 
	        { 
		        if (this.IsResource) {
                    return _azureRuntimePackage;
                }
                else
                {
                    return base.Package;
                }
	        }
        }

        public bool IsResource
        {
            get
            {
                return (Name == "Resource" || Name == "SubResource") &&
                    Extensions.ContainsKey(AzureExtensions.AzureResourceExtension) &&
                        (bool)Extensions[AzureExtensions.AzureResourceExtension];
            }
        }
    }
}
