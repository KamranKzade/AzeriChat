using AzeriChat.Models;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AzeriChat;



public partial class UserControl_Contact : UserControl
{
    public UserControl_Contact(Human information)
    {
        InitializeComponent();
        Contact_Name_lbl.Content = information.Name;
        contact_messages_lbl.Content = information.Message;
        Message_count_lbl.Content = information.MessageCount;
        message_time_lbl.Content = information.Time;


       Profile_Image.ImageSource = new BitmapImage(new Uri(information.ImageUrl, UriKind.Relative));

    }
}