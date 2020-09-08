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

        public NextLetterWrapper getLetter(char letter, int fontVariant)
        {
            NextLetterWrapper wrapper = new NextLetterWrapper();

            if (fontVariant == 0)
            {
                wrapper = getLetterVariantOne(letter);
                return wrapper;
            }
            else if (fontVariant == 1)
            {
                wrapper = getLetterVariantTwo(letter);
                return wrapper;
            }
            else 
            {
                wrapper = getLetterVariantThree(letter);
                return wrapper;
            }
        }

        private NextLetterWrapper getLetterVariantOne(char letter)
        {
          NextLetterWrapper wrapper = new NextLetterWrapper();
            switch (letter)
            {
                case (char)alphabet.Letter_А:
                    wrapper.letterDescription = " 'A' Shift + Левая - 1-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_a:
                    wrapper.letterDescription =  "'a'  Левая - 1-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_B:
                    wrapper.letterDescription =  "'Б'  Shift + Правая - 2-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_b:
                    wrapper.letterDescription =  "'б'  Правая - 2-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_W:
                    wrapper.letterDescription =  "'В'  Shift + Левая - 2-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_w:
                    wrapper.letterDescription =  "'в'  Левая - 2-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_G:
                    wrapper.letterDescription =  "'Г'  Shift + Правая - 1-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_g:
                    wrapper.letterDescription =  "'г'  Правая - 1-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_D:
                    wrapper.letterDescription = "'Д'  Shift + Правая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_d:
                    wrapper.letterDescription =  "'д'  Правая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_E:
                    wrapper.letterDescription = "'Е'  Shift +  Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_e:
                    wrapper.letterDescription = "'е' Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_JO:
                    wrapper.letterDescription = "'Ё'  Shift +  Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_jo:
                    wrapper.letterDescription = "'ё' Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ZG:
                    wrapper.letterDescription = "'Ж' Шифт + Правая - 4-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_zg:
                    wrapper.letterDescription = "'ж'  Правая - 4-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Z:
                    wrapper.letterDescription = "'З'  Шифт + Правая - 4-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_z:
                    wrapper.letterDescription = "'з'  Правая - 4-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_I:
                    wrapper.letterDescription = "'И'  Шифт + Левая - 1-м направо вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_i:
                    wrapper.letterDescription = "'и'  Левая - 1-м направо вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_II:
                    wrapper.letterDescription = "'Й'  Шифт + Левая - 4-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ii:
                    wrapper.letterDescription = "'й'  Левая - 4-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_K:
                    wrapper.letterDescription = "'К'  Шифт + Левая - 1-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_k:
                    wrapper.letterDescription = "'к'  Левая - 1-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_L:
                    wrapper.letterDescription = "'Л'  Шифт + Правая - 2-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_l:
                    wrapper.letterDescription = "'л'  Правая - 2-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_M:
                    wrapper.letterDescription = "'М'  Шифт + Левая - 1-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_m:
                    wrapper.letterDescription = "'м'  Левая - 1-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_N:
                    wrapper.letterDescription = "'Н'  Шифт + Правая - 1-м налево вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_n:
                    wrapper.letterDescription = "'н'  Правая - 1-м налево вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_O:
                    wrapper.letterDescription = "'О'  Шифт + Правая - 1-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_o:
                    wrapper.letterDescription = "'о'  Правая - 1-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_P:
                    wrapper.letterDescription = "'П'  Шифт + Левая - 1-м направо на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_p:
                    wrapper.letterDescription = "'п'  Левая - 1-м направо на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_R:
                    wrapper.letterDescription = "'Р'  Шифт + Правая - 1-м налево на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_r:
                    wrapper.letterDescription = "'р'  Правая - 1-м налево на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_S:
                    wrapper.letterDescription = "'С'  Шифт + Левая - 2-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_s:
                    wrapper.letterDescription = "'с'  Левая - 2-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_T:
                    wrapper.letterDescription = "'Т'  Шифт + Правая - 1-м налево вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_t:
                    wrapper.letterDescription = "'т'  Правая - 1-м налево вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Y:
                    wrapper.letterDescription = "'У'  Шифт + Левая - 2-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_y:
                    wrapper.letterDescription = "'у'  Левая - 2-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_F:
                    wrapper.letterDescription = "'Ф'  Шифт + Левая - 4-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_f:
                    wrapper.letterDescription = "'ф'  Левая - 4-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_X:
                    wrapper.letterDescription = "'Х'  Шифт + Правая - 4-м направо вверх";
                    wrapper.directionDescription = "LeftSpace";
                    return wrapper;
                case (char)alphabet.Letter_x:
                    wrapper.letterDescription = "'х'  Правая - 4-м направо вверх";
                    wrapper.directionDescription = "LeftSpace";
                    return wrapper;
                case (char)alphabet.Letter_ZE:
                    wrapper.letterDescription = "'Ц'  Шифт + Левая - 3-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ze:
                    wrapper.letterDescription = "'ц'  Левая - 3-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_CH:
                    wrapper.letterDescription = "'Ч'  Шифт + Левая - 3-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ch:
                    wrapper.letterDescription = "'ч'  Левая - 3-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Sh:
                    wrapper.letterDescription = "'Ш'  Шифт + Правая - 2-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_sh:
                    wrapper.letterDescription = "'ш'  Правая - 2-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_SCHe:
                    wrapper.letterDescription = "'Щ'  Шифт + Правая - 3-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_sche:
                    wrapper.letterDescription = "'щ'  Правая - 3-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_HARD:
                    wrapper.letterDescription = "'ъ'  Правая - 4-м направо в угол";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_bl:
                    wrapper.letterDescription = "'ы'  Левая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Soft:
                    wrapper.letterDescription = "'ь'  Правая - 1-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_EE:
                    wrapper.letterDescription = "'Э'  Шифт + Правая - 4-м направо на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_ee:
                    wrapper.letterDescription = "'э'  Правая - 4-м направо на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_You:
                    wrapper.letterDescription = "'Ю'  Шифт + Правая - 3-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_you:
                    wrapper.letterDescription = "'ю'  Правая - 3-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_JA:
                    wrapper.letterDescription = "'Я'  Шифт + Левая - 4-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ja:
                    wrapper.letterDescription = "'я'  Левая - 4-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_1:
                    wrapper.letterDescription = "'1'  Левая - 4-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_2:
                    wrapper.letterDescription = "'2'  Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_3:
                    wrapper.letterDescription = "'3'  Левая - 2-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_4:
                    wrapper.letterDescription = "'4'  Левая - 1-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_5:
                    wrapper.letterDescription = "'5'  Левая - 1-м направо вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_6:
                    wrapper.letterDescription = "'6'  Правая - 1-м налево вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_7:
                    wrapper.letterDescription = "'7'  Правая - 1-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_8:
                    wrapper.letterDescription = "'8'  Правая - 2-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_9:
                    wrapper.letterDescription = "'9'  Правая - 3-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_0:
                    wrapper.letterDescription = "'0'  Правая - 4-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Comma:
                    wrapper.letterDescription = "'Запятая'  Шифт + Правая - 4-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Punkt:
                    wrapper.letterDescription = "'Точка'  Правая - 4-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Score:
                    wrapper.letterDescription = "' Тире '  Правая - 4-м направо вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_UnderScore:
                    wrapper.letterDescription = "'Подчеркивание'  Шифт + Правая - 4-м направо вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_ExclamationMark:
                    wrapper.letterDescription = "'Восклицательный знак'  Шифт + Левая - 4-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_QuestionMark:
                    wrapper.letterDescription = "'Вопросителный знак'  Шифт + Правая - 1-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Semicolon:
                    wrapper.letterDescription = "';'  Шифт + Левая - 1-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Colon:
                    wrapper.letterDescription = "'Двоеточие'  Шифт + Правая - 1-м налево вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_BracketLeft:
                    wrapper.letterDescription = "'Левая скоба'  Шифт + Правая - 3-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_BrackertRight:
                    wrapper.letterDescription = "'Правая скоба'  Шифт + Правая - 4-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Percent:
                    wrapper.letterDescription = "'Знак процента'  Шифт + Левая - 1-м направо вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Stern:
                    wrapper.letterDescription = "'Звёздочка'  Шифт + Правая - 2-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Number:
                    wrapper.letterDescription = "'Номер'  Шифт + Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Quotes:
                    wrapper.letterDescription = "'Номер'  Шифт + Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
            }
            return new NextLetterWrapper();
        }

        public NextLetterWrapper getLetterVariantTwo(char letter) {

            NextLetterWrapper wrapper = new NextLetterWrapper();

            switch (letter)
            {
                case (char)alphabet.Letter_А:
                    wrapper.letterDescription = " Заглавная буква 'а', шифт-правой мизинцем направо вниз,  левой указательным на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_a:
                    wrapper.letterDescription = " Буква 'а', левой указательным на месте";
                    //wrapper.letterDescription =  "'a'  Левая - 1-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_B:
                    wrapper.letterDescription = " Заглавная буква 'бэ', шифт-левой мизинцем налево вниз,  правой средним вниз";
                    //wrapper.letterDescription =  "'Б'  Shift + Правая - 2-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_b:
                    wrapper.letterDescription = " Буква 'бэ', правой средним вниз";
                    //wrapper.letterDescription =  "'б'  Правая - 2-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_W:
                    wrapper.letterDescription = " Заглавная буква 'вэ', шифт-правой мизинцем направо вниз,  левой средним на месте";
                    //wrapper.letterDescription =  "'В'  Shift + Левая - 2-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_w:
                    wrapper.letterDescription = " Буква 'вэ', левой средним на месте";
                    //wrapper.letterDescription =  "'в'  Левая - 2-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_G:
                    wrapper.letterDescription = " Заглавная буква 'гэ', шифт-левой мизинцем налево вниз,  правой указательным вверх";
                    //wrapper.letterDescription =  "'Г'  Shift + Правая - 1-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_g:
                    wrapper.letterDescription = " Буква 'гэ', правой указательным вверх";
                    //wrapper.letterDescription =  "'г'  Правая - 1-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_D:
                    wrapper.letterDescription = " Заглавная буква 'дэ', шифт-левой мизинцем налево вниз,  правой безымянным на месте";
                    //wrapper.letterDescription = "'Д'  Shift + Правая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_d:
                    wrapper.letterDescription = " Буква 'дэ', правой безымянным на месте";
                    //wrapper.letterDescription =  "'д'  Правая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_E:
                    wrapper.letterDescription = " Заглавная буква 'йэ', шифт-правой мизинцем направо вниз,  левой указательным направо вверх";
                    //wrapper.letterDescription = "'Е'  Shift +  Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_e:
                    wrapper.letterDescription = " Буква 'йэ'; левой указательным направо вверх";
                    //wrapper.letterDescription = "'е' Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_JO:
                    wrapper.letterDescription = " Заглавная буква 'йо', шифт-правой мизинцем направо вниз,  левой мизинцем вершина в угол";
                    //wrapper.letterDescription = "'Ё'  Shift +  Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_jo:
                    wrapper.letterDescription = " Буква 'йо', левой мизинцем вершина в угол";
                    //wrapper.letterDescription = "'ё' Левая - 1-м направо вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ZG:
                    wrapper.letterDescription = " Заглавная буква 'жэ', шифт-левой мизинцем налево вниз,  правой мизинцем на месте";
                    //wrapper.letterDescription = "'Ж' Шифт + Правая - 4-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_zg:
                    wrapper.letterDescription = " Буква 'жэ', правой мизинцем на месте";
                    //wrapper.letterDescription = "'ж'  Правая - 4-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Z:
                    wrapper.letterDescription = " Заглавная буква 'зэ', шифт-левой мизинцем налево вниз,  правой мизинцем вверх";
                    //wrapper.letterDescription = "'З'  Шифт + Правая - 4-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_z:
                    wrapper.letterDescription = " Буква 'зэ', правой мизинцем вверх";
                    //wrapper.letterDescription = "'з'  Правая - 4-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_I:
                    wrapper.letterDescription = " Заглавная буква 'и', шифт-правой мизинцем направо вниз,  левой указательным направо вниз";
                    //wrapper.letterDescription = "'И'  Шифт + Левая - 1-м направо вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_i:
                    wrapper.letterDescription = " Буква 'и', левой указательным направо вниз";
                    //wrapper.letterDescription = "'и'  Левая - 1-м направо вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_II:
                    wrapper.letterDescription = " Заглавная буква 'ий', шифт-правой мизинцем направо вниз,  левой мизинцем вверх";
                    //wrapper.letterDescription = "'Й'  Шифт + Левая - 4-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ii:
                    wrapper.letterDescription = " Буква ий краткая, левой мизинцем вверх";
                    //wrapper.letterDescription = "'й'  Левая - 4-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_K:
                    wrapper.letterDescription = " Заглавная буква 'ка', шифт-правой мизинцем направо вниз,  левой указательным вверх";
                    //wrapper.letterDescription = "'К'  Шифт + Левая - 1-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_k:
                    wrapper.letterDescription = "к – Буква ка, левой указательным вверх";
                    //wrapper.letterDescription = "'к'  Левая - 1-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_L:
                    wrapper.letterDescription = " Заглавная буква 'эль', шифт-левой мизинцем налево вниз,  правой средним на месте";
                    //wrapper.letterDescription = "'Л'  Шифт + Правая - 2-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_l:
                    wrapper.letterDescription = " Буква 'эль', правой средним на месте";
                    //wrapper.letterDescription = "'л'  Правая - 2-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_M:
                    wrapper.letterDescription = " Заглавная буква 'эм', шифт-правой мизинцем направо вниз,  левой указательным вниз";
                    //wrapper.letterDescription = "'М'  Шифт + Левая - 1-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_m:
                    wrapper.letterDescription = " Буква 'эм', левой указательным вниз";
                    //wrapper.letterDescription = "'м'  Левая - 1-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_N:
                    wrapper.letterDescription = " Заглавная буква 'эн', шифт-левой мизинцем налево вниз,  правой указательным налево вверх";
                    //wrapper.letterDescription = "'Н'  Шифт + Правая - 1-м налево вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_n:
                    wrapper.letterDescription = " Буква 'эн', правой указательным налево вверх";
                    //wrapper.letterDescription = "'н'  Правая - 1-м налево вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_O:
                    wrapper.letterDescription = " Заглавная буква 'о', шифт-левой мизинцем налево вниз,  правой указательным на месте";
                    //wrapper.letterDescription = "'О'  Шифт + Правая - 1-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_o:
                    wrapper.letterDescription = " Буква 'о', правой указательным на месте";
                    //wrapper.letterDescription = "'о'  Правая - 1-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_P:
                    wrapper.letterDescription = " Заглавная буква 'пэ', шифт-правой мизинцем направо вниз,  левой указательным направо на месте";
                    //wrapper.letterDescription = "'П'  Шифт + Левая - 1-м направо на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_p:
                    wrapper.letterDescription = " Буква 'пэ', левой указательным направо на месте";
                    //wrapper.letterDescription = "'п'  Левая - 1-м направо на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_R:
                    wrapper.letterDescription = " Заглавная буква 'эр', шифт-левой мизинцем налево вниз,  правой указательным налево на месте";
                    //wrapper.letterDescription = "'Р'  Шифт + Правая - 1-м налево на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_r:
                    wrapper.letterDescription = " Буква 'эр', правой указательным налево на месте";
                    //wrapper.letterDescription = "'р'  Правая - 1-м налево на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_S:
                    wrapper.letterDescription = " Заглавная буква 'эс', шифт-правой мизинцем направо вниз,  левой средним вниз";
                    //wrapper.letterDescription = "'С'  Шифт + Левая - 2-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_s:
                    wrapper.letterDescription = " Буква 'эс', левой средним вниз";
                    //wrapper.letterDescription = "'с'  Левая - 2-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_T:
                    wrapper.letterDescription = " Заглавная буква 'тэ', шифт-левой мизинцем налево вниз,  правой указательным налево вниз";
                    //wrapper.letterDescription = "'Т'  Шифт + Правая - 1-м налево вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_t:
                    wrapper.letterDescription = " Буква 'тэ', правой указательным налево вниз";
                    //wrapper.letterDescription = "'т'  Правая - 1-м налево вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Y:
                    wrapper.letterDescription = " Заглавная буква 'у', шифт-правой мизинцем направо вниз,  левой средним вверх";
                    //wrapper.letterDescription = "'У'  Шифт + Левая - 2-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_y:
                    wrapper.letterDescription = " Буква 'у', левой средним вверх";
                    //wrapper.letterDescription = "'у'  Левая - 2-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_F:
                    wrapper.letterDescription = " Заглавная буква 'эф', шифт-правой мизинцем направо вниз,  левой мизинцем на месте";
                    //wrapper.letterDescription = "'Ф'  Шифт + Левая - 4-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_f:
                    wrapper.letterDescription = " Буква 'эф', левой мизинцем на месте";
                    //wrapper.letterDescription = "'ф'  Левая - 4-м на месте";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_X:
                    wrapper.letterDescription = " Заглавная буква 'ха', шифт-левой мизинцем налево вниз, правой мизинцем направо вверх";
                    //wrapper.letterDescription = "'Х'  Шифт + Правая - 4-м направо вверх";
                    wrapper.directionDescription = "LeftSpace";
                    return wrapper;
                case (char)alphabet.Letter_x:
                    wrapper.letterDescription = " Буква 'ха', правой мизинцем направо вверх";
                    //wrapper.letterDescription = "'х'  Правая - 4-м направо вверх";
                    wrapper.directionDescription = "LeftSpace";
                    return wrapper;
                case (char)alphabet.Letter_ZE:
                    wrapper.letterDescription = " Заглавная буква 'цэ', шифт-правой мизинцем направо вниз,  левой безымянным вверх";
                    //wrapper.letterDescription = "'Ц'  Шифт + Левая - 3-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ze:
                    wrapper.letterDescription = " Буква 'цэ', левой безымянным вверх";
                    //wrapper.letterDescription = "'ц'  Левая - 3-м вверх";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_CH:
                    wrapper.letterDescription = " Заглавная буква 'че', шифт-правой мизинцем направо вниз, левой безымянным вниз";
                    //wrapper.letterDescription = "'Ч'  Шифт + Левая - 3-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ch:
                    wrapper.letterDescription = " Буква 'че', левой безымянным вниз";
                    //wrapper.letterDescription = "'ч'  Левая - 3-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Sh:
                    wrapper.letterDescription = " Заглавная буква 'ша', шифт-правой мизинцем направо вниз,  левой безымянным вниз";
                    //wrapper.letterDescription = "'Ш'  Шифт + Правая - 2-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_sh:
                    wrapper.letterDescription = " Буква 'ша', левой безымянным вниз";
                    //wrapper.letterDescription = "'ш'  Правая - 2-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_SCHe:
                    wrapper.letterDescription = " Заглавная буква 'ща', шифт-левой мизинцем налево вниз,  правой безымянным вверх ";
                    //wrapper.letterDescription = "'Щ'  Шифт + Правая - 3-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_sche:
                    wrapper.letterDescription = " Буква 'ща', правой безымянным вверх";
                    //wrapper.letterDescription = "'щ'  Правая - 3-м вверх";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_HARD:
                    wrapper.letterDescription = " Буква 'твердый знак', правой мизинцем направо в угол";
                    //wrapper.letterDescription = "'ъ'  Правая - 4-м направо в угол";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_bl:
                    wrapper.letterDescription = " Буква 'ы', левой безымянным на месте";
                    //wrapper.letterDescription = "'ы'  Левая - 3-м на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Soft:
                    wrapper.letterDescription = " Буква 'мягкий знак', правой указательным вниз";
                    //wrapper.letterDescription = "'ь'  Правая - 1-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_EE:
                    wrapper.letterDescription = " Заглавная буква 'э', шифт-левой мизинцем налево вниз,  правой мизинцем направо на месте";
                    //wrapper.letterDescription = "'Э'  Шифт + Правая - 4-м направо на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_ee:
                    wrapper.letterDescription = " Буква 'э', правой мизинцем направо на месте";
                    //wrapper.letterDescription = "'э'  Правая - 4-м направо на месте";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_You:
                    wrapper.letterDescription = " Заглавная буква 'йу', шифт-левой мизинцем налево вниз,  правой безымянным вниз";
                    //wrapper.letterDescription = "'Ю'  Шифт + Правая - 3-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_you:
                    wrapper.letterDescription = " Буква 'йу', правой безымянным вниз";
                    //wrapper.letterDescription = "'ю'  Правая - 3-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_JA:
                    wrapper.letterDescription = " Заглавная буква 'йа', шифт-правой мизинцем направо вниз,  левой мизинцем вниз";
                    //wrapper.letterDescription = "'Я'  Шифт + Левая - 4-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_ja:
                    wrapper.letterDescription = " Буква 'йа', левой мизинцем вниз";
                    //wrapper.letterDescription = "'я'  Левая - 4-м вниз";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_1:
                    wrapper.letterDescription = " Цифра 'один', левой мизинцем вершина";
                    //wrapper.letterDescription = "'1'  Левая - 4-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_2:
                    wrapper.letterDescription = " Цифра 'два', левой безымянным вершина";
                    //wrapper.letterDescription = "'2'  Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_3:
                    wrapper.letterDescription = " Цифра 'три', левой средним вершина";
                    //wrapper.letterDescription = "'3'  Левая - 2-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_4:
                    wrapper.letterDescription = " Цифра 'четыре', левой указательным вершина";
                    //wrapper.letterDescription = "'4'  Левая - 1-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_5:
                    wrapper.letterDescription = " Цифра 'пять', левой указательным направо вершина";
                    //wrapper.letterDescription = "'5'  Левая - 1-м направо вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_6:
                    wrapper.letterDescription = " Цифра 'шесть', правой указательным налево вершина";
                    //wrapper.letterDescription = "'6'  Правая - 1-м налево вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_7:
                    wrapper.letterDescription = " Цифра 'семь', правой указательным вершина";
                    //wrapper.letterDescription = "'7'  Правая - 1-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_8:
                    wrapper.letterDescription = " Цифра 'восемь', правой средним вершина";
                    //wrapper.letterDescription = "'8'  Правая - 2-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_9:
                    wrapper.letterDescription = " Цифра 'девять', правой безымянным вершина";
                    //wrapper.letterDescription = "'9'  Правая - 3-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_0:
                    wrapper.letterDescription = " Цифра 'ноль', правой мизинцем вершина";
                    //wrapper.letterDescription = "'0'  Правая - 4-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Comma:
                    wrapper.letterDescription = "'Запятая' шифт-левой мизинцем налево вниз, правой мизинцем вниз";
                    //wrapper.letterDescription = "'Запятая'  Шифт + Правая - 4-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Punkt:
                    wrapper.letterDescription = "'Точка',  Правая - 4-м вниз";
                    //wrapper.letterDescription = "'Точка'  Правая - 4-м вниз";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Score:
                    wrapper.letterDescription = " - Дефис, правой мизинцем направо вершина";
                    //wrapper.letterDescription = "' Тире '  Правая - 4-м направо вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_UnderScore:
                    wrapper.letterDescription = " _ Нижнее подчёркивание, шифт-левой мизинцем налево вниз,  правой мизинцем направо вершина";
                    //wrapper.letterDescription = "'Подчеркивание'  Шифт + Правая - 4-м направо вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_ExclamationMark:
                    wrapper.letterDescription = " ! – Восклицательный знак, шифт- правой мизинцем направо вниз,  левой мизинцем вершина";
                    //wrapper.letterDescription = "'Восклицательный знак'  Шифт + Левая - 4-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_QuestionMark:
                    wrapper.letterDescription = " ? – Знак вопроса, шифт-левой мизинцем налево вниз,  правой указательным вершина";
                    //wrapper.letterDescription = "'Вопросителный знак'  Шифт + Правая - 1-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Semicolon:
                    wrapper.letterDescription = " ; – Точка с запятой, шифт-правой мизинцем направо вниз,  левой указательным вершина";
                    //wrapper.letterDescription = "';'  Шифт + Левая - 1-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Colon:
                    wrapper.letterDescription = " : – Двоеточие, шифт-левой мизинцем налево вниз,  правой указательным налево вершина";
                    //wrapper.letterDescription = "'Двоеточие'  Шифт + Правая - 1-м налево вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_BracketLeft:
                    wrapper.letterDescription = " ( – Скобка открывающаяся, шифт-левой мизинцем налево вниз,  правой безымянным вершина";
                    //wrapper.letterDescription = "'Левая скоба'  Шифт + Правая - 3-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_BrackertRight:
                    wrapper.letterDescription = " ) – Скобка закрывающаяся, шифт-левой мизинцем налево вниз,  правой мизинцем вершина";
                    //wrapper.letterDescription = "'Правая скоба'  Шифт + Правая - 4-м вершина";
                    wrapper.directionDescription = "LeftHand";
                    return wrapper;
                case (char)alphabet.Letter_Percent:
                    wrapper.letterDescription = " % – Знак процента, шифт-правой мизинцем направо вниз,  левой указательным направо вершина";
                    //wrapper.letterDescription = "'Знак процента'  Шифт + Левая - 1-м направо вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Stern:
                    wrapper.letterDescription = " * – Звездочка, шифт-левой мизинцем налево вниз,  правой средним вершина";
                    //wrapper.letterDescription = "'Звёздочка'  Шифт + Правая - 2-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Number:
                    wrapper.letterDescription = " № – Номер, шифт-правой мизинцем направо вниз,  левой средним вершина";
                    //wrapper.letterDescription = "'Номер'  Шифт + Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
                case (char)alphabet.Letter_Quotes:
                    wrapper.letterDescription = " \" – Кавычки, шифт-правой мизинцем направо вниз,  левой безымянным вершина";
                    //wrapper.letterDescription = "'Номер'  Шифт + Левая - 3-м вершина";
                    wrapper.directionDescription = "RightHand";
                    return wrapper;
            }
            return new NextLetterWrapper();
        }


        private NextLetterWrapper getLetterVariantThree(char letter)
        {
            throw new NotImplementedException();
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

        public class NextLetterWrapper{
            public string letterDescription;
            public string directionDescription;
        }
   }
}
