﻿using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace SharedComponents
{
    public class CustomCssClassProvider<ProviderType> : ComponentBase
where ProviderType : FieldCssClassProvider, new()
    {
        [CascadingParameter]
        EditContext? CurrentEditContext { get; set; }
        public ProviderType Provider { get; set; } = new();
        protected override void OnInitialized()
        {
            if (CurrentEditContext == null)
            {
                throw new
                InvalidOperationException
($"{nameof(CustomCssClassProvider<ProviderType>)} requires a cascading parameter of type" +
$" { nameof(EditContext) }.For example, you can use { nameof(CustomCssClassProvider<ProviderType>)}" +
$" inside an EditForm.");
            }
            CurrentEditContext.SetFieldCssClassProvider
            (Provider);
        }
    }            
}
