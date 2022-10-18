using Avalonia.Animation;

namespace AvaloniaBindError.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public double ScaleX { get; set; } = 1d;

        public double ScaleY { get; set; } = 1d;

        public IterationCount AnimationDuration { get; set; } = IterationCount.Parse("100");
        public string Greeting => "Welcome to Avalonia!";

        public MainViewModel()
        {
            ScaleX = 1d;
            ScaleY = 1d;
            AnimationDuration = IterationCount.Parse("100");
        }
    }
}
