using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AzeriChat;


public partial class UserControl_Messages : UserControl
{
    public UserControl_Messages()
    {
        InitializeComponent();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {

        Label sendMessage = new Label()
        {
            Foreground = new SolidColorBrush(Colors.Black),
            FontSize = 10,
            Content = send_txt.Text,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };


        Label answerMessage = new Label()
        {
            Foreground = new SolidColorBrush(Colors.Black),
            FontSize = 10,
            Content = "Okey bro",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };


        var lenght1 = sendMessage.Content!.ToString()!.Length;
        var answerLenght = answerMessage.Content!.ToString()!.Length;



        Border border = new()
        {
            Margin = new Thickness(5, 5, 5, 5),
            Background = new SolidColorBrush(Colors.WhiteSmoke),
            Height = 40,
            Width = sendMessage.FontSize * lenght1,
            HorizontalAlignment = HorizontalAlignment.Right,
            CornerRadius = new CornerRadius(25, 25, 0, 25),
            Child = sendMessage
        };



        Border border2 = new()
        {
            Margin = new Thickness(5, 5, 5, 5),
            Background = new SolidColorBrush(Colors.WhiteSmoke),
            Height = 40,
            Width = answerMessage.FontSize * answerLenght,
            HorizontalAlignment = HorizontalAlignment.Left,
            CornerRadius = new CornerRadius(25, 25, 25, 0),
            Child = answerMessage
        };

        Chat.Children.Add(border);
        Chat.Children.Add(border2);

    }
}