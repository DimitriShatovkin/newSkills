using System;
using NewSkills.Controller;
using System.IO;
using System.Windows;
using System.Drawing;

namespace NewSkills.ViewModel
{
    public class NextLetterService
    {
        public string returnLetter { get; set; }
        public string returPicturePath { get; set; }

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
            Letter_JO = 'Ё',
            Letter_jo = 'ё',
            Letter_ZG = 'Ж',
            Letter_zg = 'ж',
            Letter_Z = 'З',
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
            Letter_ZE = 'Ц',
            Letter_ze = 'ц',
            Letter_CH = 'Ч',
            Letter_ch = 'ч',
            Letter_Sh = 'Ш',
            Letter_sh = 'ш',
            Letter_SCHe = 'Щ',
            Letter_sche = 'щ',
            Letter_HARD = 'ъ',
            Letter_bl = 'ы',
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
            Letter_QuestionMark = '?',
            Letter_Quotes = '"',
            Letter_UnderScore = '_',
            Letter_Score = '-',
            Letter_Semicolon = ';',
            Letter_Colon = ':',
            Letter_BracketLeft = '(',
            Letter_BrackertRight = ')',
            Letter_Percent = '%',
            Letter_Number = '№',
            Letter_Stern = '*'
        }

        public void getLetter(char letter)
        {
            switch (letter)
            {
                case (char)alphabet.Letter_А:
                    returnLetter = "'A'  Shift + Левая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_a:
                    returnLetter = "'a'  Левая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_B:
                    returnLetter = "'Б'  Shift + Правая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_b:
                    returnLetter = "'б'  Правая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_W:
                    returnLetter = "'В'  Shift + Левая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_w:
                    returnLetter = "'в'  Левая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_G:
                    returnLetter = "'Г'  Shift + Правая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_g:
                    returnLetter = "'г'  Правая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_D:
                    returnLetter = "'Д'  Shift + Правая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_d:
                    returnLetter = "'д'  Правая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_E:
                    returnLetter = "'Е'  Shift +  Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_e:
                    returnLetter = "'е' Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_JO:
                    returnLetter = "'Ё'  Shift +  Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_jo:
                    returnLetter = "'ё' Левая - 1-м направо вверх";
                    break;
                case (char)alphabet.Letter_ZG:
                    returnLetter = "'Ж' Шифт + Правая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_zg:
                    returnLetter = "'ж'  Правая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_Z:
                    returnLetter = "'З'  Шифт + Правая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_z:
                    returnLetter = "'з'  Правая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_I:
                    returnLetter = "'И'  Шифт + Левая - 1-м направо вниз";
                    break;
                case (char)alphabet.Letter_i:
                    returnLetter = "'и'  Левая - 1-м направо вниз";
                    break;
                case (char)alphabet.Letter_II:
                    returnLetter = "'Й'  Шифт + Левая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_ii:
                    returnLetter = "'й'  Левая - 4-м вверх";
                    break;
                case (char)alphabet.Letter_K:
                    returnLetter = "'К'  Шифт + Левая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_k:
                    returnLetter = "'к'  Левая - 1-м вверх";
                    break;
                case (char)alphabet.Letter_L:
                    returnLetter = "'Л'  Шифт + Правая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_l:
                    returnLetter = "'л'  Правая - 2-м на месте";
                    break;
                case (char)alphabet.Letter_M:
                    returnLetter = "'М'  Шифт + Левая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_m:
                    returnLetter = "'м'  Левая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_N:
                    returnLetter = "'Н'  Шифт + Правая - 1-м налево вверх";
                    break;
                case (char)alphabet.Letter_n:
                    returnLetter = "'н'  Правая - 1-м налево вверх";
                    break;
                case (char)alphabet.Letter_O:
                    returnLetter = "'О'  Шифт + Правая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_o:
                    returnLetter = "'о'  Правая - 1-м на месте";
                    break;
                case (char)alphabet.Letter_P:
                    returnLetter = "'П'  Шифт + Левая - 1-м направо на месте";
                    break;
                case (char)alphabet.Letter_p:
                    returnLetter = "'п'  Левая - 1-м направо на месте";
                    break;
                case (char)alphabet.Letter_R:
                    returnLetter = "'Р'  Шифт + Правая - 1-м налево на месте";
                    break;
                case (char)alphabet.Letter_r:
                    returnLetter = "'р'  Правая - 1-м налево на месте";
                    break;
                case (char)alphabet.Letter_S:
                    returnLetter = "'С'  Шифт + Левая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_s:
                    returnLetter = "'с'  Левая - 2-м вниз";
                    break;
                case (char)alphabet.Letter_T:
                    returnLetter = "'Т'  Шифт + Правая - 1-м налево вниз";
                    break;
                case (char)alphabet.Letter_t:
                    returnLetter = "'т'  Правая - 1-м налево вниз";
                    break;
                case (char)alphabet.Letter_Y:
                    returnLetter = "'У'  Шифт + Левая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_y:
                    returnLetter = "'у'  Левая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_F:
                    returnLetter = "'Ф'  Шифт + Левая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_f:
                    returnLetter = "'ф'  Левая - 4-м на месте";
                    break;
                case (char)alphabet.Letter_X:
                    returnLetter = "'Х'  Шифт + Правая - 4-м направо вверх";
                    break;
                case (char)alphabet.Letter_x:
                    returnLetter = "'х'  Правая - 4-м направо вверх";
                    break;
                case (char)alphabet.Letter_ZE:
                    returnLetter = "'Ц'  Шифт + Левая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_ze:
                    returnLetter = "'ц'  Левая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_CH:
                    returnLetter = "'Ч'  Шифт + Левая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_ch:
                    returnLetter = "'ч'  Левая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_Sh:
                    returnLetter = "'Ш'  Шифт + Правая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_sh:
                    returnLetter = "'ш'  Правая - 2-м вверх";
                    break;
                case (char)alphabet.Letter_SCHe:
                    returnLetter = "'Щ'  Шифт + Правая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_sche:
                    returnLetter = "'щ'  Правая - 3-м вверх";
                    break;
                case (char)alphabet.Letter_HARD:
                    returnLetter = "'ъ'  Правая - 4-м направо в угол";
                    break;
                case (char)alphabet.Letter_bl:
                    returnLetter = "'ы'  Левая - 3-м на месте";
                    break;
                case (char)alphabet.Letter_Soft:
                    returnLetter = "'ь'  Правая - 1-м вниз";
                    break;
                case (char)alphabet.Letter_EE:
                    returnLetter = "'Э'  Шифт + Правая - 4-м направо на месте";
                    break;
                case (char)alphabet.Letter_ee:
                    returnLetter = "'э'  Правая - 4-м направо на месте";
                    break;
                case (char)alphabet.Letter_You:
                    returnLetter = "'Ю'  Шифт + Правая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_you:
                    returnLetter = "'ю'  Правая - 3-м вниз";
                    break;
                case (char)alphabet.Letter_JA:
                    returnLetter = "'Я'  Шифт + Левая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_ja:
                    returnLetter = "'я'  Левая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_1:
                    returnLetter = "'1'  Левая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_2:
                    returnLetter = "'2'  Левая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_3:
                    returnLetter = "'3'  Левая - 2-м вершина";
                    break;
                case (char)alphabet.Letter_4:
                    returnLetter = "'4'  Левая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_5:
                    returnLetter = "'5'  Левая - 1-м направо вершина";
                    break;
                case (char)alphabet.Letter_6:
                    returnLetter = "'6'  Правая - 1-м налево вершина";
                    break;
                case (char)alphabet.Letter_7:
                    returnLetter = "'7'  Правая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_8:
                    returnLetter = "'8'  Правая - 2-м вершина";
                    break;
                case (char)alphabet.Letter_9:
                    returnLetter = "'9'  Правая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_0:
                    returnLetter = "'0'  Правая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_Comma:
                    returnLetter = "','  Шифт + Правая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_Punkt:
                    returnLetter = "'.'  Правая - 4-м вниз";
                    break;
                case (char)alphabet.Letter_Score:
                    returnLetter = "' - '  Правая - 4-м направо вершина";
                    break;
                case (char)alphabet.Letter_UnderScore:
                    returnLetter = "'_'  Шифт + Правая - 4-м направо вершина";
                    break;
                case (char)alphabet.Letter_ExclamationMark:
                    returnLetter = "'!'  Шифт + Левая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_QuestionMark:
                    returnLetter = "'?'  Шифт + Правая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_Semicolon:
                    returnLetter = "';'  Шифт + Левая - 1-м вершина";
                    break;
                case (char)alphabet.Letter_Colon:
                    returnLetter = "':'  Шифт + Правая - 1-м налево вершина";
                    break;
                case (char)alphabet.Letter_BracketLeft:
                    returnLetter = "'('  Шифт + Правая - 3-м вершина";
                    break;
                case (char)alphabet.Letter_BrackertRight:
                    returnLetter = "')'  Шифт + Правая - 4-м вершина";
                    break;
                case (char)alphabet.Letter_Percent:
                    returnLetter = "'%'  Шифт + Левая - 1-м направо вершина";
                    break;
                case (char)alphabet.Letter_Stern:
                    returnLetter = "'*'  Шифт + Правая - 2-м вершина";
                    break;
                case (char)alphabet.Letter_Number:
                    returnLetter = "'№'  Шифт + Левая - 3-м вершина";
                    break;
            }
        }

        public Bitmap getPicture(char letter)
        {
            switch (letter)
            {
                case (char)alphabet.Letter_А:
                    return Properties.Resources.letter_a1;
                case (char)alphabet.Letter_a:
                    return Properties.Resources.letter_a2;
                case (char)alphabet.Letter_B:
                    return Properties.Resources.letter_b1;
                case (char)alphabet.Letter_b:
                    return Properties.Resources.letter_b2;
                case (char)alphabet.Letter_W:
                    return Properties.Resources.letter_v1;                   
                case (char)alphabet.Letter_w:
                    return Properties.Resources.letter_v2;
                case (char)alphabet.Letter_G:
                    return Properties.Resources.letter_g1;
                case (char)alphabet.Letter_g:
                    return Properties.Resources.letter_g2;
                case (char)alphabet.Letter_D:
                    return Properties.Resources.letter_d1;
                case (char)alphabet.Letter_d:
                    return Properties.Resources.letter_d2;
                case (char)alphabet.Letter_E:
                    return Properties.Resources.letter_e1;
                case (char)alphabet.Letter_e:
                    return Properties.Resources.letter_e2;
                case (char)alphabet.Letter_JO:
                    return Properties.Resources.letter_jo1;
                case (char)alphabet.Letter_jo:
                    return Properties.Resources.letter_jo2;
                case (char)alphabet.Letter_ZG:
                    return Properties.Resources.letter_zg1;
                case (char)alphabet.Letter_zg:
                    return Properties.Resources.letter_zg2;
                case (char)alphabet.Letter_Z:
                    return Properties.Resources.letter_z1;
                case (char)alphabet.Letter_z:
                    return Properties.Resources.letter_z2;
                case (char)alphabet.Letter_I:
                    return Properties.Resources.letter_i1;
                case (char)alphabet.Letter_i:
                    return Properties.Resources.letter_i2;
                case (char)alphabet.Letter_II:
                    return Properties.Resources.letter_j1;
                case (char)alphabet.Letter_ii:
                    return Properties.Resources.letter_j2;
                case (char)alphabet.Letter_K:
                    return Properties.Resources.letter_k1;
                case (char)alphabet.Letter_k:
                    return Properties.Resources.letter_k2;
                case (char)alphabet.Letter_L:
                    return Properties.Resources.letter_l1;
                case (char)alphabet.Letter_l:
                    return Properties.Resources.letter_l2;
                case (char)alphabet.Letter_M:
                    return Properties.Resources.letter_m1;
                case (char)alphabet.Letter_m:
                    return Properties.Resources.letter_m2;
                case (char)alphabet.Letter_N:
                    return Properties.Resources.letter_n1;
                case (char)alphabet.Letter_n:
                    return Properties.Resources.letter_n2;
                case (char)alphabet.Letter_O:
                    return Properties.Resources.letter_o1;
                case (char)alphabet.Letter_o:
                    return Properties.Resources.letter_o2;
                case (char)alphabet.Letter_P:
                    return Properties.Resources.letter_p1;
                case (char)alphabet.Letter_p:
                    return Properties.Resources.letter_p2;
                case (char)alphabet.Letter_R:
                    return Properties.Resources.letter_r1;
                case (char)alphabet.Letter_r:
                    return Properties.Resources.letter_r2;
                case (char)alphabet.Letter_S:
                    return Properties.Resources.letter_s1;
                case (char)alphabet.Letter_s:
                    return Properties.Resources.letter_s2;
                case (char)alphabet.Letter_T:
                    return Properties.Resources.letter_t1;
                case (char)alphabet.Letter_t:
                    return Properties.Resources.letter_t2;
                case (char)alphabet.Letter_Y:
                    return Properties.Resources.letter_u1;
                case (char)alphabet.Letter_y:
                    return Properties.Resources.letter_u2;
                case (char)alphabet.Letter_F:
                    return Properties.Resources.letter_f1;
                case (char)alphabet.Letter_f:
                    return Properties.Resources.letter_f2;
                case (char)alphabet.Letter_X:
                    return Properties.Resources.letter_x1;
                case (char)alphabet.Letter_x:
                    return Properties.Resources.letter_x2;
                case (char)alphabet.Letter_ZE:
                    return Properties.Resources.letter_ze1;
                case (char)alphabet.Letter_ze:
                    return Properties.Resources.letter_ze2;
                case (char)alphabet.Letter_CH:
                    return Properties.Resources.letter_ch1;
                case (char)alphabet.Letter_ch:
                    return Properties.Resources.letter_ch2;
                case (char)alphabet.Letter_Sh:
                    return Properties.Resources.letter_sh1;
                case (char)alphabet.Letter_sh:
                    return Properties.Resources.letter_sh2;
                case (char)alphabet.Letter_SCHe:
                    return Properties.Resources.letter_sche1;
                case (char)alphabet.Letter_sche:
                    return Properties.Resources.letter_sche2;
                case (char)alphabet.Letter_HARD:
                    return Properties.Resources.letter_hard;
                case (char)alphabet.Letter_bl:
                    return Properties.Resources.letter_bl;
                case (char)alphabet.Letter_Soft:
                    return Properties.Resources.letter_bsign;
                case (char)alphabet.Letter_EE:
                    return Properties.Resources.letter_ee1;
                case (char)alphabet.Letter_ee:
                    return Properties.Resources.letter_ee2;
                case (char)alphabet.Letter_You:
                    return Properties.Resources.letter_ju1;
                case (char)alphabet.Letter_you:
                    return Properties.Resources.letter_ju2;
                case (char)alphabet.Letter_JA:
                    return Properties.Resources.letter_ja1;
                case (char)alphabet.Letter_ja:
                    return Properties.Resources.letter_ja2;
                case (char)alphabet.Letter_1:
                    return Properties.Resources.letter_1;
                case (char)alphabet.Letter_2:
                    return Properties.Resources.letter_2;
                case (char)alphabet.Letter_3:
                    return Properties.Resources.letter_3;
                case (char)alphabet.Letter_4:
                    return Properties.Resources.letter_4;
                case (char)alphabet.Letter_5:
                    return Properties.Resources.letter_5;
                case (char)alphabet.Letter_6:
                    return Properties.Resources.letter_6;
                case (char)alphabet.Letter_7:
                    return Properties.Resources.letter_7;
                case (char)alphabet.Letter_8:
                    return Properties.Resources.letter_8;
                case (char)alphabet.Letter_9:
                    return Properties.Resources.letter_9;
                case (char)alphabet.Letter_0:
                    return Properties.Resources.letter_0;
                case (char)alphabet.Letter_ExclamationMark:
                    return Properties.Resources.letter_1sign;
                case (char)alphabet.Letter_Quotes:
                    return Properties.Resources.letter_2sign;
                case (char)alphabet.Letter_Number:
                    return Properties.Resources.letter_3sign;
                case (char)alphabet.Letter_Semicolon:
                    return Properties.Resources.letter_4sign;
                case (char)alphabet.Letter_Percent:
                    return Properties.Resources.letter_5sign;
                case (char)alphabet.Letter_Colon:
                    return Properties.Resources.letter_6sign;
                case (char)alphabet.Letter_QuestionMark:
                    return Properties.Resources.letter_7sign;
                case (char)alphabet.Letter_Stern:
                    return Properties.Resources.letter_8sign;
                case (char)alphabet.Letter_BracketLeft:
                    return Properties.Resources.letter_9sign;
                case (char)alphabet.Letter_BrackertRight:
                    return Properties.Resources.letter_0sign;
                case (char)alphabet.Letter_Comma:
                    return Properties.Resources.letter_comma;
                case (char)alphabet.Letter_Punkt:
                    return Properties.Resources.letter_point;
                case (char)alphabet.Letter_Score:
                    return Properties.Resources.letter_underscore;
                case (char)alphabet.Letter_UnderScore:
                    return Properties.Resources.letter_score;
            }
            return Properties.Resources.letter_a1;
        }
    }
}
