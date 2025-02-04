using System.Collections.Generic;
using sly.lexer;
using sly.parser.generator;

namespace ParserTests
{
    public class RegexLexAndExplicitTokensParser
    {
        [Production("main : item*")]
        public string Main(List<string> items)
        {
            return string.Join(",", items);
        }

        [Production("item : 'test' INT")]
        public string Item(Token<RegexLexAndExplicitTokensLexer> test, Token<RegexLexAndExplicitTokensLexer> integer)
        {
            return $"{test.Value}:{integer.IntValue}";
        }
    }
}