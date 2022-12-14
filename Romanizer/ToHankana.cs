using System;
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
            #region ひらがな

            { "あ", "ｱ" },
            { "い", "ｲ" },
            { "う", "ｳ" },
            { "え", "ｴ" },
            { "お", "ｵ" },
            { "か", "ｶ" },
            { "き", "ｷ" },
            { "く", "ｸ" },
            { "け", "ｹ" },
            { "こ", "ｺ" },
            { "さ", "ｻ" },
            { "し", "ｼ" },
            { "す", "ｽ" },
            { "せ", "ｾ" },
            { "そ", "ｿ" },
            { "た", "ﾀ" },
            { "ち", "ﾁ" },
            { "つ", "ﾂ" },
            { "て", "ﾃ" },
            { "と", "ﾄ" },
            { "な", "ﾅ" },
            { "に", "ﾆ" },
            { "ぬ", "ﾇ" },
            { "ね", "ﾈ" },
            { "の", "ﾉ" },
            { "は", "ﾊ" },
            { "ひ", "ﾋ" },
            { "ふ", "ﾌ" },
            { "へ", "ﾍ" },
            { "ほ", "ﾎ" },
            { "ま", "ﾏ" },
            { "み", "ﾐ" },
            { "む", "ﾑ" },
            { "め", "ﾒ" },
            { "も", "ﾓ" },
            { "や", "ﾔ" },
            { "ゆ", "ﾕ" },
            { "よ", "ﾖ" },
            { "ら", "ﾗ" },
            { "り", "ﾘ" },
            { "る", "ﾙ" },
            { "れ", "ﾚ" },
            { "ろ", "ﾛ" },
            { "わ", "ﾜ" },
            { "ゐ", "ｲ" },
            { "ゑ", "ｴ" },
            { "を", "ｦ" },
            { "ん", "ﾝ" },

            { "が", "ｶﾞ" },
            { "ぎ", "ｷﾞ" },
            { "ぐ", "ｸﾞ" },
            { "げ", "ｹﾞ" },
            { "ご", "ｺﾞ" },
            { "ざ", "ｻﾞ" },
            { "じ", "ｼﾞ" },
            { "ず", "ｽﾞ" },
            { "ぜ", "ｾﾞ" },
            { "ぞ", "ｿﾞ" },
            { "だ", "ﾀﾞ" },
            { "ぢ", "ﾁﾞ" },
            { "づ", "ﾂﾞ" },
            { "で", "ﾃﾞ" },
            { "ど", "ﾄﾞ" },
            { "ば", "ﾊﾞ" },
            { "び", "ﾋﾞ" },
            { "ぶ", "ﾌﾞ" },
            { "べ", "ﾍﾞ" },
            { "ぼ", "ﾎﾞ" },
            { "ぱ", "ﾊﾟ" },
            { "ぴ", "ﾋﾟ" },
            { "ぷ", "ﾌﾟ" },
            { "ぺ", "ﾍﾟ" },
            { "ぽ", "ﾎﾟ" },
            { "ゔ", "ｳﾞ" },

            { "ぁ", "ｧ" },
            { "ぃ", "ｨ" },
            { "ぅ", "ｩ" },
            { "ぇ", "ｪ" },
            { "ぉ", "ｫ" },
            { "ゃ", "ｬ" },
            { "ゅ", "ｭ" },
            { "ょ", "ｮ" },

            #endregion　ひらがな

            #region カタカナ

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
            { "ヰ", "ｲ" },
            { "ヱ", "ｴ" },
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

            #endregion カタカナ

            #region ローマ字

            // TODO: ローマ字

	        #endregion ローマ字
        };
    }
}
