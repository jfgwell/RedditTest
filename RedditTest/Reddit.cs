using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Reddit;
using Reddit.Controllers.Internal;
using RedditNet;

namespace RedditTest
{
    public class Reddit
    {
        RedditNet.Auth.RedditPasswordAuth RA = new RedditNet.Auth.RedditPasswordAuth(null, null, null, null, null);
        RedditApi reddit = new RedditApi(); 
        
        
       
    }
}
