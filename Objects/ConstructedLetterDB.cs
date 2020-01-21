using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDictionaryApp.Objects
{
    public static class ConstructedLetterDB
    {
        //class was unneccessary in the end. Could be used to create a digital display frontend but ultimately useless towards completing the exercise.

        public static Dictionary<char, DigitalLetter> MatchedCharacters = new Dictionary<char, DigitalLetter>();

        public static void CreateDigitalLetterReferences()
        {
            DigitalLetter digitalA = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalB = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalC = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalD = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = false,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalE = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalF = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalG = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalH = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalI = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalJ = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = false,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalL = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = true,
            };

            DigitalLetter digitalN = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = false,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalO = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalP = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalQ = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = false,
                BottomRightSegmentExists = true,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalR = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = false,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = false,
            };
            DigitalLetter digitalS = new DigitalLetter()
            {
                TopSegmentExists = true,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = false,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalT = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = false,
                TopLeftSegmentExists = true,
                CenterSegmentExists = true,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = false,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalU = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = true,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };
            DigitalLetter digitalY = new DigitalLetter()
            {
                TopSegmentExists = false,
                TopRightSegmentExists = true,
                TopLeftSegmentExists = true,
                CenterSegmentExists = false,
                BottomLeftSegmentExists = false,
                BottomRightSegmentExists = true,
                BottomSegmentExists = true,
            };

            MatchedCharacters.Add('a', digitalA);
            MatchedCharacters.Add('b', digitalB);
            MatchedCharacters.Add('c', digitalC);
            MatchedCharacters.Add('d', digitalD);
            MatchedCharacters.Add('e', digitalE);
            MatchedCharacters.Add('f', digitalF);
            MatchedCharacters.Add('g', digitalG);
            MatchedCharacters.Add('h', digitalH);
            MatchedCharacters.Add('i', digitalI) ;
            MatchedCharacters.Add('j', digitalJ);
            MatchedCharacters.Add('l', digitalL) ;
            MatchedCharacters.Add('n', digitalN) ;
            MatchedCharacters.Add('o', digitalO);
            MatchedCharacters.Add('p', digitalP);
            MatchedCharacters.Add('q', digitalQ);
            MatchedCharacters.Add('r', digitalR);
            MatchedCharacters.Add('s', digitalS);
            MatchedCharacters.Add('t', digitalT);
            MatchedCharacters.Add('u', digitalU);
            MatchedCharacters.Add('y', digitalY);

        }
    }
}
