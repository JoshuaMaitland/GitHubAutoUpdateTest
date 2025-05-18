using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutoUpdateTest
{
    public static class UpdateChecker
    {
        public static string GetNewVersionFromGithubAPI()
        {
            var c = new WebClient();
            c.Headers.Add("User-Agent", "GitHubAutoUpdateTest");
            var s = c.DownloadString("https://api.github.com/repos/JoshuaMaitland/GitHubAutoUpdateTest/releases/latest");
            var versionTag = s.Split(new string[] { "\"tag_name\":\"" }, StringSplitOptions.None)[1].Split('"')[0];

            // Remove leading 'v' if present
            var versionNumber = versionTag.StartsWith("v", StringComparison.OrdinalIgnoreCase)
                ? versionTag.Substring(1)
                : versionTag;

            return versionNumber;
        }
    }
}
