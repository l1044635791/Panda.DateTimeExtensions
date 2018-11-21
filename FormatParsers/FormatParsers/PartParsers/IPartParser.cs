using System;
using System.Text.RegularExpressions;

namespace Panda.DateTimeExtensions.FormatParsers.PartParsers {
    public interface IPartParser {
        Regex Regex { get; }
        DateTimeOffset? Parse(Match match, DateTimeOffset relativeBaseTime, bool isUpperLimit);
    }
}