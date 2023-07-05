using System;


class Program
{
    static void Main(string[] args)
    {
        Video video1= new Video("Introducing the Dyson 360 Vis Nav™ robot vacuum", "Dyson", 19);
        Video video2 = new Video("Introducing the Dyson Purifier Big+Quiet™ Formaldehyde", "Dyson", 18);
        Video video3 = new Video("Unboxing the Google Pixel Tablet", "Google", 17);
        Video video4 = new Video("First look at the Google", "Google", 39);
        Comment commentTitle1_1 = new Comment("user-wy9dg7bn9j", "I thought it was a video of a product released 10 years ago.");
        Comment commentTitle1_2 = new Comment("o0o74", "does it avoid poo?  what about privacy?");
        Comment commentTitle1_3 = new Comment("brad7571", "$1600??");
        Comment commentTitle1_4 = new Comment("manuelpiston", "5k or 10k?");

        Comment commentTitle2_1 = new Comment("joshua01", "Really impressive stuff, really looking forward to it hitting the market…");
        Comment commentTitle2_2 = new Comment("Lakshyakapila", "Outstanding, believe me i own v12 detect slim..Dyson makes some of the best products in market ❤");
        Comment commentTitle2_3 = new Comment("Cleaning_Hero", "I’d like to see the CADR rates. I am skeptical about Dyson’s P.O.L.A.R. method. My BlueAir units were purchased based on the cadr ratings, and sq footage. They are supposed to do 674 sq ft rooms with 8 foot ceilings 4.8x per hour on high speed, when placed in the right space. How does Dyson’s POLAR method differ? I’d like to see some animation or explanation as to why CADR is not efficient and why POLAR works better. Something along those lines.");
        Comment commentTitle2_4 = new Comment("user-kb7yv1yb6b", "I wished customer service actually do something about the problem associated with the model TP09 that is making a whistling noise. A lot of people are having the same problems and what you guys do is just replace it with the new item that has the same motor design failure and yet I am still having exactly the same issues as before. The biggest problem is that the replacement does not come with a new warranty. so if your warranty is done you are done.");

        Comment commentTitle3_1 = new Comment("Motwera", "A tablet doubling as a smart speaker is something many companies should've done a while ago, glad to see Google give it a shot.");
        Comment commentTitle3_2 = new Comment("TurtleSB", "Google hardware products seem to be ignored, they're great.");
        Comment commentTitle3_3 = new Comment("MrCommentGod", "Pointless knowledge of the day: This YouTube short is exactly 17 seconds long");
        Comment commentTitle3_4 = new Comment("130unnak", "The tablets really good when it’s not even available in Asia in the first place- make it available here please.");

        Comment commentTitle4_1 = new Comment("lianaho2231", "Wow! This looks amazing!");
        Comment commentTitle4_2 = new Comment("im_gamersp", "Will it be available in India too😅");
        Comment commentTitle4_3 = new Comment("andrijanamikkelsen", "if i want to draw is it possible with the pen?");
        Comment commentTitle4_4 = new Comment("ThePolishDad", "Can't wait for it to arrive! Come on June 20th! ❤");

        video1.StoreComment(commentTitle1_1);
        video1.StoreComment(commentTitle1_2);
        video1.StoreComment(commentTitle1_3);
        video1.StoreComment(commentTitle1_4);

        video2.StoreComment(commentTitle2_1);
        video2.StoreComment(commentTitle2_2);
        video2.StoreComment(commentTitle2_3);

        video3.StoreComment(commentTitle3_1);
        video3.StoreComment(commentTitle3_2);
        video3.StoreComment(commentTitle3_3);
        video3.StoreComment(commentTitle3_4);

        video4.StoreComment(commentTitle4_1);
        video4.StoreComment(commentTitle4_2);
        video4.StoreComment(commentTitle4_3);

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        
        video1.DisplayData();
        video2.DisplayData();
        video3.DisplayData();
        video4.DisplayData();
    }
}