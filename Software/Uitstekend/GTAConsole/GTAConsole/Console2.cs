﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GTAConsole
{
    public class Console2
    {
        public static void Write(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        public static void WriteLine(string str, ConsoleColor color)
        {
            Console2.Write(str, color);
            Console.WriteLine();
        }

        enum LexerState
        {
            BEFORE,
            ACCENTED,
            AFTER,
            FIRST_OPENING_BRACE,
            SECOND_OPENING_BRACE,
            FIRST_CLOSING_BRACE,
            SECOND_CLOSING_BRACE
        }

        // TODO: meer dan 1 accent mogelijk in een string

        /*
        enum TokenType
        {
            TEXT,
            OPENING_TAG,
            CLOSING_TAG,
            ACCENTED_TEXT
        }

        class Token {
            TokenType type;
            string value;
        }
         */

        // Parset een Mustache-achtige-template-string (met max. 1 parameter) en print deze op de console
        // met de parameter in de accentedColor.
        public static void Write(string str, ConsoleColor basicColor, ConsoleColor accentedColor)
        {
            string before = "";
            string accented = "";
            string after = "";

            LexerState ps = LexerState.BEFORE;

            foreach (char c in str)
            {
                switch (ps)
                {
                    case LexerState.BEFORE:
                        if (c != '{')
                        {
                            before += c;
                        }
                        else
                        {
                            ps = LexerState.FIRST_OPENING_BRACE;
                        }
                        break;
                    case LexerState.FIRST_OPENING_BRACE:
                        if (c == '{')
                        {
                            ps = LexerState.SECOND_OPENING_BRACE;
                        }
                        else
                        {
                            ps = LexerState.BEFORE;
                            before += '{';
                            before += c;
                        }
                        break;
                    case LexerState.SECOND_OPENING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        }
                        else
                        {
                            ps = LexerState.ACCENTED;
                            accented += c;
                        }
                        break;
                    case LexerState.ACCENTED:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        }
                        else
                        {
                            accented += c;
                        }
                        break;
                    case LexerState.FIRST_CLOSING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.SECOND_CLOSING_BRACE;
                        }
                        else
                        {
                            accented += '}';
                            accented += c;
                        }
                        break;
                    case LexerState.SECOND_CLOSING_BRACE:
                        ps = LexerState.AFTER;
                        after += c;
                        break;
                    case LexerState.AFTER:
                        after += c;
                        break;
                }
            }

            Console2.Write(before, basicColor);
            Console2.Write(accented, accentedColor);
            Console2.WriteLine(after, basicColor);
        }

        public static void WriteLine(string str, ConsoleColor basicColor, ConsoleColor accentedColor)
        {
            Console2.Write(str, basicColor, accentedColor);
        }

    }
}


// RegEx uitprobeersels:

//Regex templateParser = new Regex(@"(.*)\{\{(.*)}}(.*)"); // De '{' moet ge-escaped worden in een RegEx.
//string templateregex = @"(.*)(jos)(.*)";

//foreach (Match match in Regex.Matches(str, templateregex))
//{
//    Console.WriteLine("{0} - {1} - {2}", match.Groups[1].Value,
//                                match.Groups[2].Value, match.Groups[3].Value);
//}

//Console.WriteLine("'{0}'",before);
//Console.WriteLine("'{0}'", accented);
//Console.WriteLine("'{0}'", after);

//Match match = templateParser.Match(str);
//string accentedString = match.Value.Trim(new char[] {'{', '}'});

//Console.WriteLine(accentedString);
//Console.WriteLine(match.Index);

//string before = str.Substring(0, match.Index);
//string after = str.Substring(match.Index);