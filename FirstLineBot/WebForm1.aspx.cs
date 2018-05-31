using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstLineBot
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = "U188367607aed099198ed96e3cddd682a";
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("LXJNy4dYT5zGUaMSipb6lYWkorxk15vEkKv440d8rQyEg1r5ByoobHKc0YJGBbIRzQEkYtrgiUM+ubacOyYAybR8DWAwUHBscDjVWiPrEEt9THMORYvtweUfUZXTTaOcgtqHJqvH3EHfFFR52epg6QdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage(id, "hellohello");
            bot.PushMessage(id, 1, 2);
            bot.PushMessage(id, new Uri("https://static1.squarespace.com/static/51b3dc8ee4b051b96ceb10de/t/5a9acf819140b7602d66bb39/1520095109871/the-emoji-movie-wins-worst-picture-at-38th-razzie-awards-heres-the-full-list-of-winners-or-losers-social.jpg?format=750w"));
        }
    }
}