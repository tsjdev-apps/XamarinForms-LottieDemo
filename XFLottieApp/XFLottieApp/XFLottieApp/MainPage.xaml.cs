using Xamarin.Forms;

namespace XFLottieApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AnimationButtonOnClicked(object sender, System.EventArgs e)
        {
            if (AnimationView.IsPlaying)
            {
                AnimationView.Pause();
                AnimationButton.Text = "Start Animation";
            }
            else
            {
                AnimationView.Play();
                AnimationButton.Text = "Stop Animation";
            }
        }
    }
}
