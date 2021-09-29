using System;
using System.Collections.Generic;
using System.Text;

namespace PeregruzMetpoiskanaib
{
    class metodPoiska
    {

        public int MetodPoiska(int a, int b, int c)
        {
            int[] abc = new int[] { a, b, c };
            int result = abc[0];

            for (int i = 0; i < abc.Length; i++)
            {
                if (result < abc[i])
                {
                    result = abc[i];
                }
            }
            return result;
        }
        // Метод для поиска найбольшего значения из трех данных значений. При 2 или 4 значениях работать не будет.
        // Метод лохов так сказать
        // но если потребуется на 4 числа или пять. просто дописывай в первую строку еще одно значение инт.
        // И добавляй в массиве их {} но все это, опять же для лохов
        // Ибо чмошники не знают ключевого слова " params "
        // оно позволяет зделать перегрузку метода с неограниченым числом параметров ОДНОГО типа
        public int MetodBogooW(params int[] aboba)
        {
            int result = aboba[0];

            for (int i = 0; i < aboba.Length; i++)
            {
                if (result < aboba[i])
                {
                    result = aboba[i];
                }
            }
            return result;
        }
        /// видишь как нехуйски упрощает всё. МОжешь  пихать сколько угодно элементов. И массив тут нужен именно для этого.
        /// потому что мы не знаем сколько элементов будет вводить человек. 
        /// но они будут автоматом вписываться. 5-массив из 5 и 10 массив из 10. 
        public string MetodBogooS(params string[] aboba)
        {
            string result = aboba[0];

            for (int i = 0; i < aboba.Length; i++)
            {
                if (result.Length < aboba[i].Length)
                {
                    result = aboba[i];
                }
            }
            return result;
        }
    }
}
