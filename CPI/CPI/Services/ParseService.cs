using Code7248.word_reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPI.Services
{
    public class ParseService
    {
        public static string ParseFileExtractor(string path)
        {
            string text = "";
            try
            {
                TextExtractor extractor = new TextExtractor(path);
                text = extractor.ExtractText(); //The string 'text' is now loaded with the text from the Word Document
            }
            catch (Exception e)
            {
                text = e.Message;
            }

            return text;
        }
    }
}