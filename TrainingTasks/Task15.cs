﻿using System;
using System.Collections.Generic;

namespace TrainingTasks
{

    /*
        Задача: Дана гистограмма (см. картинку в Ресурсах), она представлена числовым массивом: 
        [ 3, 6, 2, 4, 2, 3, 2, 10, 10, 4 ]
        Нужно посчитать объем воды (1 блок в гистограмме), ктр наберется внутри нее.
     
        Идея:   будем работать с локальными максимумами. Нам нужно найти все "высокие стенки" справа и слева, 
                где бы могла скопиться вода. Крайние точки мы не будем учитывать, т.к. очевидно, что там вода скопиться не может. 
                По сути нам нужно пройти по массиву два раза и найти локальные максимумы слева и справа, затем 
                найти минимальный максимум для каждой точки. Тогда разность локального максимума со значением гистограммы 
                в этой точке и будем объемом воды для этого блока.
     */

    class Task15
    {
        public static void DoTask15_v1(params int[] array)
        {

            int maxLeft, maxRigt;
            int max;

            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {

            }


        }
    }
}