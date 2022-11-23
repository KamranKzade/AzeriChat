using AzeriChat.Models;
using System.Collections.Generic;

namespace AzeriChat.Repository;

public class FakeRepo
{
    public static List<Human> GetContactInformation()
    {
        return new List<Human>
            {
                new Human
                {
                    //ImageUrl=@"/Images/ronaldo.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\ronaldo.png",
                    Name = "Ronaldo",
                    Message = "Come to Real Madrid",
                    MessageCount = "1",
                    Time = "12:43"
                },
                new Human
                {
                    //ImageUrl=@"/Images/messi.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\messi.png",
                    Name = "Messi",
                    Message = "Come to PSG",
                    MessageCount = null,
                    Time = "15:45"
                },
                new Human
                {
                    //ImageUrl=@"/Images/alex.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\alex.png",
                    Name = "Alex",
                    Message = "Come to Fenerbagce",
                    MessageCount = null,
                    Time = "03:15"
                },
                new Human
                {
                    //ImageUrl=@"/Images/benzema.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\benzema.png",
                    Name = "Benzema",
                    Message = "Come to Real Madrid",
                    MessageCount = null,
                    Time = "22:43"
                },
                new Human
                {
                    //ImageUrl=@"/Images/maradona.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\maradona.png",
                    Name = "Maradona",
                    Message = "Come to Napoli",
                    MessageCount = "23",
                    Time = "07:58"
                },
                new Human
                {
                    //ImageUrl=@"/Images/neymar.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\neymar.png",
                    Name = "Neymar",
                    Message = "Come to PSG",
                    MessageCount = "8",
                    Time = "21:15"
                },
                new Human
                {
                    //ImageUrl=@"/Images/seydayev.png",
                    ImageUrl=@"C:\Users\Kamran\source\repos\AzeriChat\AzeriChat\Images\seydayev.png",
                    Name = "Ramil Sheydayev",
                    Message = "Come to Karabag",
                    MessageCount = null,
                    Time = "12:22"
                }

            };

    }

}
