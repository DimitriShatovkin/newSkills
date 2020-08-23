using System;
using NewSkills.Controller;
using System.IO;

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
            Letter_Stern= '*'
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
                    returnLetter = "'-'  Правая - 4-м направо вершина";
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

        public void getPicture(char letter)
        {
            switch (letter)
            {
                case (char)alphabet.Letter_А:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_a1.png";
                    break;
                case (char)alphabet.Letter_a:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_a2.png";
                    break;
                case (char)alphabet.Letter_B:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_b1.png";
                    break;
                case (char)alphabet.Letter_b:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_b2.png";
                    break;
                case (char)alphabet.Letter_W:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_v1.png";
                    break;
                case (char)alphabet.Letter_w:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_v2.png";
                    break;
                case (char)alphabet.Letter_G:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_g1.png";
                    break;
                case (char)alphabet.Letter_g:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_g2.png";
                    break;
                case (char)alphabet.Letter_D:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_d1.png";
                    break;
                case (char)alphabet.Letter_d:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_d2.png";
                    break;
                case (char)alphabet.Letter_E:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_e1.png";
                    break;
                case (char)alphabet.Letter_e:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_e2.png";
                    break;
                case (char)alphabet.Letter_JO:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_jo1.png";
                    break;
                case (char)alphabet.Letter_jo:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_jo2.png";
                    break;
                case (char)alphabet.Letter_ZG:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_zg1.png";
                    break;
                case (char)alphabet.Letter_zg:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_zg2.png";
                    break;
                case (char)alphabet.Letter_Z:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_z1.png";
                    break;
                case (char)alphabet.Letter_z:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_z2.png";
                    break;
                case (char)alphabet.Letter_I:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_i1.png";
                    break;
                case (char)alphabet.Letter_i:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_i2.png";
                    break;
                case (char)alphabet.Letter_II:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_j1.png";
                    break;
                case (char)alphabet.Letter_ii:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_j2.png";
                    break;
                case (char)alphabet.Letter_K:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_k1.png";
                    break;
                case (char)alphabet.Letter_k:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_k2.png";
                    break;
                case (char)alphabet.Letter_L:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_l1.png";
                    break;
                case (char)alphabet.Letter_l:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_l2.png";
                    break;
                case (char)alphabet.Letter_M:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_m1.png";
                    break;
                case (char)alphabet.Letter_m:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_m2.png";
                    break;
                case (char)alphabet.Letter_N:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_n1.png";
                    break;
                case (char)alphabet.Letter_n:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_n2.png";
                    break;
                case (char)alphabet.Letter_O:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_o1.png";
                    break;
                case (char)alphabet.Letter_o:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_o2.png";
                    break;
                case (char)alphabet.Letter_P:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_p1.png";
                    break;
                case (char)alphabet.Letter_p:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_p2.png";
                    break;
                case (char)alphabet.Letter_R:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_r1.png";
                    break;
                case (char)alphabet.Letter_r:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_r2.png";
                    break;
                case (char)alphabet.Letter_S:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_s1.png";
                    break;
                case (char)alphabet.Letter_s:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_s2.png";
                    break;
                case (char)alphabet.Letter_T:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_t1.png";
                    break;
                case (char)alphabet.Letter_t:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_t2.png";
                    break;
                case (char)alphabet.Letter_Y:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_u1.png";
                    break;
                case (char)alphabet.Letter_y:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_u2.png";
                    break;
                case (char)alphabet.Letter_F:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_f1.png";
                    break;
                case (char)alphabet.Letter_f:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_f2.png";
                    break;
                case (char)alphabet.Letter_X:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_x1.png";
                    break;
                case (char)alphabet.Letter_x:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_x2.png";
                    break;
                case (char)alphabet.Letter_ZE:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ze1.png";
                    break;
                case (char)alphabet.Letter_ze:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ze2.png";
                    break;
                case (char)alphabet.Letter_CH:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ch1.png";
                    break;
                case (char)alphabet.Letter_ch:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ch2.png";
                    break;
                case (char)alphabet.Letter_Sh:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_sh1.png";
                    break;
                case (char)alphabet.Letter_sh:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_sh2.png";
                    break;
                case (char)alphabet.Letter_SCHe:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_sche1.png";
                    break;
                case (char)alphabet.Letter_sche:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_sche2.png";
                    break;
                case (char)alphabet.Letter_HARD:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_hard.png";
                    break;
                case (char)alphabet.Letter_bl:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_bl.png";
                    break;
                case (char)alphabet.Letter_Soft:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_bsign.png";
                    break;
                case (char)alphabet.Letter_EE:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ee1.png";
                    break;
                case (char)alphabet.Letter_ee:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ee2.png";
                    break;
                case (char)alphabet.Letter_You:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ju1.png";
                    break;
                case (char)alphabet.Letter_you:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ju2.png";
                    break;
                case (char)alphabet.Letter_JA:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ja1.png";
                    break;
                case (char)alphabet.Letter_ja:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_ja2.png";
                    break;
                case (char)alphabet.Letter_1:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_1.png";
                    break;
                case (char)alphabet.Letter_2:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_2.png";
                    break;
                case (char)alphabet.Letter_3:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_3.png";
                    break;
                case (char)alphabet.Letter_4:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_4.png";
                    break;
                case (char)alphabet.Letter_5:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_5.png";
                    break;
                case (char)alphabet.Letter_6:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_6.png";
                    break;
                case (char)alphabet.Letter_7:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_7.png";
                    break;
                case (char)alphabet.Letter_8:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_8.png";
                    break;
                case (char)alphabet.Letter_9:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_9.png";
                    break;
                case (char)alphabet.Letter_0:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_0.png";
                    break;
                case (char)alphabet.Letter_ExclamationMark:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_1sign.png";
                    break;
                case (char)alphabet.Letter_Quotes:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_2sign.png";
                    break;
                case (char)alphabet.Letter_Number:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_3sign.png";
                    break;
                case (char)alphabet.Letter_Semicolon:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_4sign.png";
                    break;
                case (char)alphabet.Letter_Percent:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_5sign.png";
                    break;
                case (char)alphabet.Letter_Colon:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_6sign.png";
                    break;
                case (char)alphabet.Letter_QuestionMark:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_7sign.png";
                    break;
                case (char)alphabet.Letter_Stern:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_8sign.png";
                    break;
                case (char)alphabet.Letter_BracketLeft:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_9sign.png";
                    break;
                case (char)alphabet.Letter_BrackertRight:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_0sign.png";
                    break;
                case (char)alphabet.Letter_Comma:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_comma.png";
                    break;
                case (char)alphabet.Letter_Punkt:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_punkt.png";
                    break;
                case (char)alphabet.Letter_Score:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter-.png";
                    break;
                case (char)alphabet.Letter_UnderScore:
                    returPicturePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\ImgLetters\\letter_.png";
                    break;
            }
        }
    }
}
