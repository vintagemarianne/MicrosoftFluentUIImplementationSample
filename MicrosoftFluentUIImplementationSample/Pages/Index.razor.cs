using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftFluentUIImplementationSample.Pages
{
    public partial class Index
    {
        public bool IsComponentDisabled { get; set; }

        protected override void OnInitialized()
        {
            IsComponentDisabled = false;
            base.OnInitialized();
        }

        public void ToggleComponentDisability()
        {
            IsComponentDisabled = !IsComponentDisabled;
        }
    }
}
