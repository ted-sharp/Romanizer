﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Romanizer
{
    internal class ToHankana : IStringTransformer
    {
        public string Transform(string input)
        {
            var newstr = HankanaDictionary.Aggregate(input, (current, value) =>
                 current.Replace(value.Key, value.Value));
            return newstr;
        }

        private static readonly Dictionary<string, string> HankanaDictionary = new()
        {
            { "ア", "ｱ" },
            { "イ", "ｲ" },
            { "ウ", "ｳ" },
            { "エ", "ｴ" },
            { "オ", "ｵ" },
            { "カ", "ｶ" },
            { "キ", "ｷ" },
            { "ク", "ｸ" },
            { "ケ", "ｹ" },
            { "コ", "ｺ" },
            { "サ", "ｻ" },
            { "シ", "ｼ" },
            { "ス", "ｽ" },
            { "セ", "ｾ" },
            { "ソ", "ｿ" },
            { "タ", "ﾀ" },
            { "チ", "ﾁ" },
            { "ツ", "ﾂ" },
            { "テ", "ﾃ" },
            { "ト", "ﾄ" },
            { "ナ", "ﾅ" },
            { "ニ", "ﾆ" },
            { "ヌ", "ﾇ" },
            { "ネ", "ﾈ" },
            { "ノ", "ﾉ" },
            { "ハ", "ﾊ" },
            { "ヒ", "ﾋ" },
            { "フ", "ﾌ" },
            { "ヘ", "ﾍ" },
            { "ホ", "ﾎ" },
            { "マ", "ﾏ" },
            { "ミ", "ﾐ" },
            { "ム", "ﾑ" },
            { "メ", "ﾒ" },
            { "モ", "ﾓ" },
            { "ヤ", "ﾔ" },
            { "ユ", "ﾕ" },
            { "ヨ", "ﾖ" },
            { "ラ", "ﾗ" },
            { "リ", "ﾘ" },
            { "ル", "ﾙ" },
            { "レ", "ﾚ" },
            { "ロ", "ﾛ" },
            { "ワ", "ﾜ" },
            { "ヲ", "ｦ" },
            { "ン", "ﾝ" },

            { "ガ", "ｶﾞ" },
            { "ギ", "ｷﾞ" },
            { "グ", "ｸﾞ" },
            { "ゲ", "ｹﾞ" },
            { "ゴ", "ｺﾞ" },
            { "ザ", "ｻﾞ" },
            { "ジ", "ｼﾞ" },
            { "ズ", "ｽﾞ" },
            { "ゼ", "ｾﾞ" },
            { "ゾ", "ｿﾞ" },
            { "ダ", "ﾀﾞ" },
            { "ヂ", "ﾁﾞ" },
            { "ヅ", "ﾂﾞ" },
            { "デ", "ﾃﾞ" },
            { "ド", "ﾄﾞ" },
            { "バ", "ﾊﾞ" },
            { "ビ", "ﾋﾞ" },
            { "ブ", "ﾌﾞ" },
            { "ベ", "ﾍﾞ" },
            { "ボ", "ﾎﾞ" },

            { "パ", "ﾊﾟ" },
            { "ピ", "ﾋﾟ" },
            { "プ", "ﾌﾟ" },
            { "ペ", "ﾍﾟ" },
            { "ポ", "ﾎﾟ" },

            { "ヴ", "ｳﾞ" },

            { "ァ", "ｧ" },
            { "ィ", "ｨ" },
            { "ゥ", "ｩ" },
            { "ェ", "ｪ" },
            { "ォ", "ｫ" },
            { "ャ", "ｬ" },
            { "ュ", "ｭ" },
            { "ョ", "ｮ" },

            // TODO: ひらがな
            // TODO: ローマ字
        };
    }
}