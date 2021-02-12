using Syncfusion.SfSkinManager;
using System.Windows;
using System.Windows.Input;

namespace EditDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : Window
    {
        /// <summary>
        /// Window Constructor and events initialization
        /// </summary>
        public Window1()
        {
            SfSkinManager.SetTheme(this,new Theme("Office2019Colorful"));
            InitializeComponent();
            Edit1.DocumentSource = @"../../Content.txt";
            Edit1.IsUndoEnabled = false;
            Edit1.IsRedoEnabled = false;
            //Edit1.PreviewKeyDown += Edit1_PreviewKeyDown;

        }

        
        private void Edit1_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {   
          if(e.Key == Key.Z && (e.KeyboardDevice.Modifiers & ModifierKeys.Control) != 0)
        {
                //Undo feature enable by checking the keys.
               Edit1.IsUndoEnabled = true;
            }
        }
    }
}
