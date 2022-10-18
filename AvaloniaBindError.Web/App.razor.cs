using Avalonia.Web.Blazor;

namespace AvaloniaBindError.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaBindError.App>()
            .SetupWithSingleViewLifetime();
    }
}