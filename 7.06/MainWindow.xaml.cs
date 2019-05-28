using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7._06
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DoubleAnimation animation = new DoubleAnimation();
      animation.From = progressbar.Width;
      animation.To = progressbar.Width + 300;
      animation.Duration = new Duration(TimeSpan.FromSeconds(5));
      animation.Completed += progressbarCompleted;

      Storyboard storyboard = new Storyboard();
      storyboard.Children.Add(animation);
      Storyboard.SetTargetName(animation, progressbar.Name);
      Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));

      storyboard.Begin(this);
    }
    private void progressbarCompleted(object sender, EventArgs e)
    {
      MessageBox.Show("Загрузка завершена \n Урааааааааааааа!!!!!!!!!!!!!! \n ТЫ ЭТО СДЕЛАЛ ТЫ МОЛОДЕЦ \n Держи КРАБА");
     
       map.Source = new Uri("https://kingcrabrussia.ru/images/logotop.jpg");
     
    }
  }
}
