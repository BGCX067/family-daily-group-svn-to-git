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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FamilyDaily
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MemberPage : Page
    {
        public MemberPage()
        {
            this.InitializeComponent();
            Story1.Begin();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Content.Text = "Công dụng: Theo mô hình trên, ta thấy Filter bao bọc lấy các tài nguyên trên server và có khả năng quản lý đồng thời cả request lẫn response hoặc có thể chỉ quản lý đơn lẻ chúng. Một request/response có thể phải đi qua không, một hoặc nhiều Filter trước khi đi đến đích của nó là các trang jsp, servlet, các server pages hoặc các tài nguyên khác trên server. " +
            "\nƯu điểm: Filter cho phép người lập trình có thể cấy các đoạn code để xử lý các luồng yêu cầu và phản hồi hoặc loại bỏ chúng một cách một cách dễ dàng. Chính khả năng này đã giúp filter hoàn toàn trong suốt với các tầng xử lý phía sau.";
        }
    }
}
