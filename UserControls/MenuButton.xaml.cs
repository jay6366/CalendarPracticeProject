using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace CalenderPracticeProject.UserControls
{
    /// <summary>
    /// MenuButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        //Caption속성을 위한 종속속성 CaptionProperty 등록
        public static readonly DependencyProperty CaptionProperty = DependencyProperty.
            Register("Caption", typeof(string), typeof(MenuButton));

        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        //Icon속성을 위한 종속속성 IconProperty 등록
        public static readonly DependencyProperty IconProperty = DependencyProperty.
            Register("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MenuButton));
    }
}
