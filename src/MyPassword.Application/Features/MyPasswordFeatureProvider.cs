using Abp.Application.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.UI.Inputs;
using Abp.Runtime.Validation;

namespace MyPassword.Application.Features
{
    public class MyPasswordFeatureProvider : FeatureProvider
    {
        public static class Names {
            public const string Contacts = "Product";
            public const string MaxContactCount = "ContactManager.MaxContactCount";
        }

        public override void SetFeatures(IFeatureDefinitionContext context)
        {
            var contacts = context.Create(Names.Contacts, "true");
            //contacts.CreateChildFeature(Names.MaxContactCount, "100", inputType: new SingleLineStringInputType(new NumericValueValidator(1, 10000)));
        }
    }
}
