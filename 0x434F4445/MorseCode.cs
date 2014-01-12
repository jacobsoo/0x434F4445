using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0x434F4445
{
    class MorseCode{
        private Char[] Letters = new Char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g',
            'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8',
            '9', ' '
        };

        private String[] MorseCodeString = new String[] {
            ".-", "-...", "-.-.",
            "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
            "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---",
            "...--", "....-", ".....", "-....", "--...", "---..", "----.", " "
        };

        public String ConvertTextToMorse(String text){
            text = text.ToLower();
            String result = "";
            int index = -1;
            for (int i = 0; i <= text.Length - 1; i++){
                index = Array.IndexOf(Letters, text[i]);
                if (index != -1)
                    result += MorseCodeString[index] + " ";
            }
            return result;
        }

        public String ConvertMorseToText(String text){
            text = "@" + text.Replace(" ", "@@") + "@";
            int index = -1;
            foreach (Char c in Letters){
                index = Array.IndexOf(Letters, c);
                text = text.Replace("@" + MorseCodeString[index] + "@", "@" + c.ToString() + "@");
            }
            return text.Replace("@@@@", " ").Replace("@", "");
        }
    }
}
