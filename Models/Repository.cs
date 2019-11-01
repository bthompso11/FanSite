using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{

    
    public static class Repository
    {
        public static List<UserComments> comments = new List<UserComments>();

        public static UserComments testStory = new UserComments { Name = "Brian", Comment = "Test Comment 1" };

        //Hard coded data for UserStories
        public static List<UserStory> stories = new List<UserStory>
        {
            new UserStory{Name = "Brian", Location = "Springfield", Title = "first story", Story = "This is the first story",},                
            new UserStory{Name = "Ashley", Location = "Eugene", Title = "Second story", Story = "This is the second story"}
        };
        
        
        //BooksAndPrint list is hardcoded at this time
        public static List<BooksAndPrint> printMedia = new List<BooksAndPrint> {         
            new BooksAndPrint{Title = "Secret History of Twin Peaks", Hyperlink = "http://www.bymarkfrost.com/books/secret_history_of_twin_peaks.html", PublicationYear = "2016"},
            new BooksAndPrint{Title = "Twin Peaks Final Dossier", Hyperlink = "http://www.bymarkfrost.com/books/twin_peaks_final_dossier.html", PublicationYear = "2017"},
            new BooksAndPrint{Title = "Secret Diary of Laura Palmer", Hyperlink = "http://www.bymarkfrost.com/books/secret_diary_of_laura_palmer.html", PublicationYear = "2011"}           
            };             
        
        //OnlineResources list is hardcoded at this time.
        public static List<OnlineResources> onlineResources = new List<OnlineResources> { 
            new OnlineResources{Title = "Twin Peaks Wiki", Hyperlink = "https://en.wikipedia.org/wiki/Twin_Peaks"}      
            };        

        public static IEnumerable<UserStory> Stories
        {
            get
            {
                return stories;
            }
        }

        //Adding responses to the list stories
        public static void AddResponse(UserStory userStories)
        {
            stories.Add(userStories);
        }

        public static void AddCommentToStory(String userComment)
        {
            //TODO: Figure out logic to make this line work.
            //stories[0].StoryComments = userComment;
        }

        //TODO: Need to put the comment object in all of the lists!!!! 

      
        public static IEnumerable<UserComments> Comment
        {
            get
            {
                return comments;
            }
        }

        public static void AddComment(UserComments userComment)
        {
            comments.Add(userComment);
        }

        //Use of Lambda Expression for Lab3
        public static IEnumerable<BooksAndPrint> PrintMedia { get => printMedia; }      
        //Use if Lambda Expression for Lab3
        public static IEnumerable<OnlineResources> OnlineResources { get => OnlineResources; }

       public static void SortBooksAndPrintList()
        {
            printMedia.Sort((pm1, pm2) => string.Compare(pm1.PublicationYear, pm2.PublicationYear, StringComparison.Ordinal));
        }

        public static void SortStories()
        {
            stories.Sort((s1,s2) => string.Compare(s1.Title, s2.Title, StringComparison.Ordinal));
        }


    }
}
