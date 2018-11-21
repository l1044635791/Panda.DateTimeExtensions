using System;

namespace Panda.DateTimeExtensions.FormatParsers {
    public interface IFormatParser {
        DateTimeRange Parse(string content, DateTimeOffset relativeBaseTime);
    }
}
