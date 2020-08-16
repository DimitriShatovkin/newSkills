using NewSkills.Controller;

namespace NewSkills.ViewModel
{
    public class NextLetter
    {
        public string returnLetter { get; set; }
        StreamReaderController controller = new StreamReaderController("logs");

        enum alphabet
        {

            Letter_А = 'А',
            Letter_a = 'а',
            Letter_B = 'Б',
            Letter_b = 'б',
            Letter_W = 'В',
            Letter_w = 'в',
            Letter_G = 'Г',
            Letter_g = 'г',
            Letter_D = 'Д',
            Letter_d = 'д',
            Letter_E = 'Е',
            Letter_e = 'е',
            Letter_GG = 'Ж',
            Letter_gg= 'ж',
            Letter_Z= 'З',
            Letter_z = 'з',
            Letter_I = 'И',
            Letter_i = 'и',
            Letter_II = 'Й',
            Letter_ii = 'й',
            Letter_K = 'К',
            Letter_k = 'к',
            Letter_L = 'Л',
            Letter_l = 'л',
            Letter_M = 'М',
            Letter_m = 'м',
            Letter_N = 'Н',
            Letter_n = 'н',
            Letter_O = 'О',
            Letter_o = 'о',
            Letter_P = 'П',
            Letter_p = 'п',
            Letter_R = 'Р',
            Letter_r = 'р',
            Letter_S = 'С',
            Letter_s = 'с',
            Letter_T = 'Т',
            Letter_t = 'т',
            Letter_Y = 'У',
            Letter_y = 'у',
            Letter_F = 'Ф',
            Letter_f = 'ф',
            Letter_X = 'Х',
            Letter_x = 'х',
            Letter_ZZ = 'Ц',
            Letter_zz = 'ц',
            Letter_CH = 'Ч',
            Letter_ch= 'ч',
            Letter_Sh = 'Ш',
            Letter_sh = 'ш',
            Letter_SCH = 'Щ',
            Letter_sch = 'щ',
            Letter_HARD = 'ъ',
            Letter_IE = 'ы',
            Letter_Soft = 'ь',
            Letter_EE = 'Э',
            Letter_ee = 'э',
            Letter_You = 'Ю',
            Letter_you = 'ю',
            Letter_JA = 'Я',
            Letter_ja = 'я',
            Letter_1 = '1',
            Letter_2 = '2',
            Letter_3 = '3',
            Letter_4 = '4',
            Letter_5 = '5',
            Letter_6 = '6',
            Letter_7 = '7',
            Letter_8 = '8',
            Letter_9 = '9',
            Letter_0 = '0',
            Letter_Comma = ',',
            Letter_Punkt = '.',
            Letter_ExclamationMark = '!',
            Letter_QuestinMark = '?',
            Letter_UnderScore = '_',
            Letter_Score = '-',
            Letter_Semicolon = ';',
            Letter_Colon = ':',
            Letter_BracketLeft = '(',
            Letter_BrackertRight = ')',
            Letter_Percent = '%'
        }

        public void getLetter(char letter)
        {
            switch (letter)
            {
                case (char) alphabet.Letter_А:
                    returnLetter = "'A' Shift + Левая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_a:
                    returnLetter = "'a' Левая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_B:
                    returnLetter = "'Б'  Shift + Правая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_b:
                    returnLetter = "'б' Правая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_W:
                    returnLetter = "'В'  Shift + Левая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_w:
                    returnLetter = "'в' Левая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_G:
                    returnLetter = "'Г'  Shift + Правая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_g:
                    returnLetter = "'г' Правая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_D:
                    returnLetter = "'Д' Shift + Правая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_d:
                    returnLetter = "'д' Правая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_E:
                    returnLetter = "'Е' Shift +  Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_e:
                    returnLetter = "'е' Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_GG:
                    returnLetter = "'Ж' Шифт + Правая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_gg:
                    returnLetter = "'ж' Правая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_Z:
                    returnLetter = "'З' Шифт + Правая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_z:
                    returnLetter = "'з' Правая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_I:
                    returnLetter = "'И' Шифт + Левая - 1-м направо вниз";
                    break;
                case (char)alphabet.Letter_i:
                    returnLetter = "'и' Левая - 1-м направо вниз";
                    break;
                case (char)alphabet.Letter_II:
                    returnLetter = "'Й' Шифт + Левая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_ii:
                    returnLetter = "'й' Левая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_K:
                    returnLetter = "'К' Шифт + Левая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_k:
                    returnLetter = "'к' Левая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_L:
                    returnLetter = "'Л' Шифт + Правая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_l:
                    returnLetter = "'л' Правая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_M:
                    returnLetter = "'М' Шифт + Левая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_m:
                    returnLetter = "'м' Левая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_N:
                    returnLetter = "'Н' Шифт + Правая - 1-м налево вверх";
                    break;
                case (char)alphabet.Letter_n:
                    returnLetter = "'н' Правая - 1-м налево вверх";
                    break;
                case (char)alphabet.Letter_O:
                    returnLetter = "'О' Шифт + Правая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_o:
                    returnLetter = "'о' Правая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_P:
                    returnLetter = "'П' Шифт + Левая - 1-м направо на мест";
                    break;
                case (char)alphabet.Letter_p:
                    returnLetter = "'п' Левая - 1-м направо на мест";
                    break;
                case (char)alphabet.Letter_R:
                    returnLetter = "'Р' Шифт + Правая - 1-м налево на месте";
                    break;
                case (char)alphabet.Letter_r:
                    returnLetter = "'р' Правая - 1-м налево на месте";
                    break;
                case (char)alphabet.Letter_S:
                    returnLetter = "'С' Шифт + Левая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_s:
                    returnLetter = "'с' Левая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_T:
                    returnLetter = "'Т' Шифт + Правая - 1-м налево вниз";
                    break;
                case (char)alphabet.Letter_t:
                    returnLetter = "'т' Правая - 1-м налево вниз";
                    break;
                case (char)alphabet.Letter_Y:
                    returnLetter = "'У' Шифт + Левая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_y:
                    returnLetter = "'у' Левая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_F:
                    returnLetter = "'Ф' Шифт + Левая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_f:
                    returnLetter = "'ф' Левая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_X:
                    returnLetter = "'Х' Шифт + Правая - 4-м направо вверх";
                    break;
                case (char)alphabet.Letter_x:
                    returnLetter = "'х' Правая - 4-м направо вверх";
                    break;
                case (char)alphabet.Letter_ZZ:
                    returnLetter = "'Ц' Шифт + Левая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_zz:
                    returnLetter = "'ц' Левая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_CH:
                    returnLetter = "'Ч' Шифт + Левая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_ch:
                    returnLetter = "'ч' Левая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_Sh:
                    returnLetter = "'Ш' Шифт + Правая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_sh:
                    returnLetter = "'ш' Правая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_SCH:
                    returnLetter = "'Щ' Шифт + Правая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_sch:
                    returnLetter = "'щ' Правая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_HARD:
                    returnLetter = "'ъ' Правая - 4-м направо в угол";
                    break;
                case (char)alphabet.Letter_IE:
                    returnLetter = "'ы' Левая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_Soft:
                    returnLetter = "'ь' Правая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_EE:
                    returnLetter = "'Э' Шифт + Правая - 4-м направо на месте";
                    break;
                case (char)alphabet.Letter_ee:
                    returnLetter = "'э' Правая - 4-м направо на месте";
                    break;
                case (char)alphabet.Letter_You:
                    returnLetter = "'Ю' Шифт + Правая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_you:
                    returnLetter = "'ю' Правая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_JA:
                    returnLetter = "'Я' Шифт + Левая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_ja:
                    returnLetter = "'я' Левая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_1:
                    returnLetter = "'1' Левая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_2:
                    returnLetter = "'2' Левая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_3:
                    returnLetter = "'3' Левая - 2-м вершина";
                    break;
                case (char)alphabet.Letter_4:
                    returnLetter = "'4' Левая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_5:
                    returnLetter = "'5' Левая - 1-м направо вершина";
                    break;
                case (char)alphabet.Letter_6:
                    returnLetter = "'6' Правая - 1-м налево вершина";
                    break;
                case (char)alphabet.Letter_7:
                    returnLetter = "'7' Правая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_8:
                    returnLetter = "'8' Правая - 2-м вершина";
                    break;
                case (char)alphabet.Letter_9:
                    returnLetter = "'9' Правая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_0:
                    returnLetter = "'0' Правая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_Comma:
                    returnLetter = "',' Шифт + Правая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_Punkt:
                    returnLetter = "'.' Правая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_Score:
                    returnLetter = "'-' Правая - 4-м направо вершина";
                    break;
                case (char)alphabet.Letter_UnderScore:
                    returnLetter = "'_' Шифт + Правая - 4-м направо вершина";
                    break;
                case (char)alphabet.Letter_ExclamationMark:
                    returnLetter = "'!' Шифт + Левая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_QuestinMark:
                    returnLetter = "'?' Шифт + Правая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_Semicolon:
                    returnLetter = "';' Шифт + Левая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_Colon:
                    returnLetter = "':' Шифт + Правая - 1-м налево вершина";
                    break;
                case (char)alphabet.Letter_BracketLeft:
                    returnLetter = "'(' Шифт + Правая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_BrackertRight:
                    returnLetter = "')' Шифт + Правая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_Percent:
                    returnLetter = "'%' Шифт + Левая - 1-м направо вершина";
                    break;
            }
        }

        public string getNextLetterString(char letter)
        {
            StreamReaderController.writeLetter(letter, letter.GetHashCode());
            return "";
        }

    }
}
