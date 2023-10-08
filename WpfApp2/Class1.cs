﻿using System;
using System.Data;

namespace Libx
{
    public class MathFunctions
    {
        public static double SquareRoot(double x)
        {
            if (x > 0)                                                          //Если значение переменной x больше нуля, то выполняется следующий блок кода. 
            {                                                                   //В этом блоке кода выполняется вычисление квадратного корня числа x с помощью метода Sqrt класса Math. Результат этого вычисления возвращается из метода. 
                return Math.Sqrt(x);                                            //Если значение переменной x меньше или равно нулю, то выполняется блок кода после ключевого слова else. 
            }
            else                                                                //В этом блоке кода создается новый объект исключения типа ArgumentException с заданным сообщением "Число должно быть больше нуля!". 
            {                                                                   //Далее, это исключение выбрасывается с помощью ключевого слова throw. 
                throw new ArgumentException("Число должно быть больше нуля!");  //Таким образом, если число меньше или равно нулю, то будет выброшено исключение с указанным сообщением
            }
        }
    }
}