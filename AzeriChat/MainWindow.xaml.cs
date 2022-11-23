using AzeriChat.Models;
using AzeriChat.Repository;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace AzeriChat;



public partial class MainWindow : Window
{
    public List<Human>? info { get; set; }


    public MainWindow()
    {
        InitializeComponent();

        info = new List<Human>();
        info = FakeRepo.GetContactInformation();

        foreach (var item in info)
        {
            UserControl_Contact user = new (item);

            if (item.MessageCount is null)
            {
                user.border.Background = new SolidColorBrush(Colors.Transparent);
            }

            Thickness margin = contact_stackpanel.Margin;
            margin.Bottom = 10;
           
            contact_stackpanel.Margin = margin;

            user.Width = 300;
            user.Height = 60;
            contact_stackpanel.Children.Add(user);

            user.MouseDoubleClick += User_MouseDoubleClick;

        }
    }

    private void User_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        mygrid.Children.Clear();
        tabcontrol.SelectedIndex = 1;
        var human = sender as UserControl_Contact;

        UserControl_Messages messages = new ();


        messages.Name.Content = human!.Contact_Name_lbl.Content;
        messages.Profile_Image.ImageSource = human.Profile_Image.ImageSource;
        messages.messages.Content = human.contact_messages_lbl.Content;

        messages.Width = 330;
        messages.Height = 380;

        mygrid.Children.Add(messages);
    }
}