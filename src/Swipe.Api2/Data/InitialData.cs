using System;
using System.Linq;

namespace Swipe.Api.Data
{
    public static class InitialData
    {
        public static void Seed(this SwipeDBContext dbContext)
        {
            if (!dbContext.Posts.Any())
            {
                dbContext.Posts.Add(new Post
                {
                    Title = "TestFest 2020 A short relation",
                    url = "https://thebrokentest.com/testfest-2020-a-short-relation/",
                    ShortDesciption =
                        "TestFest is conference close to my heart, I know organizers very well, and it was one of the first events I have spoken at. At the End of February, there was another edition, So it is time for yet another relation from TestFes",
                    ImageUrl =
                        "https://i1.wp.com/thebrokentest.com/wp-content/uploads/2020/03/IMG_3345.jpeg?w=1536&ssl=1",
                    Tags = Tag.Testing,
                    IntroducedAt = DateTimeOffset.Now,
                    Opened = 0,
                    Ignored = 0
                });
                
                dbContext.Posts.Add(new Post
                {
                    Title = "Improving productivity vs being productive.",
                    url = "https://thebrokentest.com/improving-productivity-vs-being-productive/",
                    ShortDesciption =
                        "I think we all know these images about productivity and being smart: \nFor the last one I love all the debunking (example here) \n The message usually associated with these images is work smarter, not harder. \n  Personally, I hate this phrasing cause in some way it implies “only idiots are working hard”. But the message it tries to communicate is essential. The efficiency of your work is essential. Basically, DevOps is built around the idea of constant improvement. But one of the better examples comes from The Unicorn Project.",
                    ImageUrl =
                        "https://i1.wp.com/thebrokentest.com/wp-content/uploads/2020/03/IMG_3345.jpeg?w=1536&ssl=1",
                    Tags = Tag.SoftwareCraftmanship,
                    IntroducedAt = DateTimeOffset.Now,
                    Opened = 1,
                    Ignored = 4
                });
                
            
                dbContext.Posts.Add(new Post
                {
                    Title = "So You Want To Automate",
                    url = "https://thebrokentest.com/so-you-want-to-automate-part-ii-lets-talk-automation/",
                    ShortDesciption =
                        "The following article is second in a series where I am talking real about \"start in test automation\". My goal here is not to disinterest anybody from trying to learn it. What I want to achieve is making anybody who considers starting work as testers as informed as possible. If you haven’t read it yet, I suggest checking the first part. Especially the introduction. It contains all the essential disclaimers and clarification of terms.",
                    ImageUrl =
                        "https://i1.wp.com/thebrokentest.com/wp-content/uploads/2020/03/IMG_3345.jpeg?w=1536&ssl=1",
                    Tags = Tag.Automation,
                    IntroducedAt = DateTimeOffset.Now,
                    Opened = 15,
                    Ignored = 1
                });
                ///////////////
                dbContext.Posts.Add(new Post
                {
                    Title = "Making friends with the impostors inside",
                    url = "https://thebrokentest.com/testfest-2020-a-short-relation/",
                    ShortDesciption =
                        "Disclaimer: These are only my experiences and this should not at any case be taken as a substitute for any sort of medical advice.",
                    ImageUrl =
                        "https://images.pexels.com/photos/2838506/pexels-photo-2838506.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Tags = Tag.SoftwareCraftmanship,
                    IntroducedAt = DateTimeOffset.Now,
                    Opened = 0,
                    Ignored = 0
                });
                
                
                dbContext.SaveChanges();
            }
        }
    }
}