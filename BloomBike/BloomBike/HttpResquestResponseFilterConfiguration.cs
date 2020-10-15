using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BloomBike
{
    public class HttpResquestResponseFilterConfiguration
    {
        private IEnumerable<Regex> ignorePathsRegexes;
        public bool Active { get; set; }

        public IEnumerable<string> IgnoreHttpMethods { get; set; }
        public IEnumerable<string> IgnorePathPattern { get; set; }

        public IEnumerable<Regex> IgnorePathRegexes
        {
            get
            {
                if (ignorePathsRegexes == null)
                    ignorePathsRegexes = IgnorePathPattern.Select(pathPattern => ToRegex(pathPattern));
                return ignorePathsRegexes;
            }
        }

        private Regex ToRegex(string igonerePath)
        {
            var replacePath = igonerePath.Replace("/*", "[/]?.*");
            return new Regex($"(.*{replacePath}$)", RegexOptions.Compiled & RegexOptions.IgnoreCase);
        }

        public bool ShouldLog(string method, string path)
        {
            return Active && !IgnoreHttpMethods.Any(x => x.ToUpper() == method.ToUpper()) &&
                !ignorePathsRegexes.Any(regex => regex.IsMatch(path));
        }
    }
}