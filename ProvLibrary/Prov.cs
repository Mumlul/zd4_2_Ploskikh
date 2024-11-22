using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvLibrary
{
    public static class Prov
    {
        //Проверка первого входного данного и количество чисел на эквивалентность
        public static bool TrueLength(int fstLine, int massLength)
        {
            return Equals(fstLine, massLength);
        }

        //Проверка первого входного, что оно больше 0
        public static bool IsRightNumber(int fstLine)
        {
            if (fstLine <= 0)
            {
                return false;
            }
            else
                return true;
        }

      


        //Проверка входных данных на пустое значение или значение null
        public static bool IsEmptyLine(string line)
        {
            if (line == "" || line == null)
                return false;
            else
                return true;
        }

        //Проверка первого входного на то, что это формат int
        public static bool IsNumericValue(string fstLine)
        {
            return Int32.TryParse(fstLine, out int result);
        }

            //Проверка массива времени на то, что все элементы имеют формат int
            public static bool IsNumericValue(string[] mass)
            {

                for (int i = 0; i < mass.Length; i++)
                {
                    if (Int32.TryParse(mass[i], out int result) == false)
                    {
                        return false;
                    }
                }
                return true;
            }

        //Проверка кратности количества элементов list на 3
        public static bool MultipleOfThree(List<int> list)
        {
            if (list.Count % 3 == 0)
                return true;
            else
                return false;
        }
    }
}
