using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.Capture;
using Windows.Storage;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace FamilyDaily
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class DemoSc : FamilyDaily.Common.LayoutAwarePage
    {
        public DemoSc()
        {
            this.InitializeComponent();
            StoryboardMe.Begin();
            BackgroudColor.Begin();
            BackgroudColor.Completed += BackgroudColor_Completed;
        }

        void BackgroudColor_Completed(object sender, object e)
        {
            BackgroudColor.Begin();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            //string user = username.Text;
            //string pas = pass.Password;

            //if (AccountBUS.DangNhap(user, pas))
            //{
            //    this.Frame.Navigate(typeof(GroupDetailPage),user);
            //}
        }

        private async void imgCapture_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            var ui = new CameraCaptureUI();
            ui.PhotoSettings.CroppedAspectRatio = new Size(4, 3);
            var file = await ui.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (file != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.SetSource(await file.OpenAsync(FileAccessMode.Read));

                imgCapture.Source = bitmap;
            }
        }

    }
}
