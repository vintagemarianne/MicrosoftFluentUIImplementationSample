using Microsoft.AspNetCore.Components;

namespace MicrosoftFluentUIImplementationSample.Components
{
    public partial class FluentComponent
    {
        [Parameter]
        public bool IsDisabled { get; set; }
        public int Counter { get; set; }

        public void IncreaseCounter()
        {
            Counter++;
        }
    }
}
