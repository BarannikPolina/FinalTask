Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Решение:
Объявляем два массива, один с заданными значениями строк, второй - количеством строк равный первому.
Объявляем счетчик ячеек для второго массива и счетчик ячеек для итогового массива.
С помощью цикла for и орператора if вычисляем какие стоки массива будут состоять менее чем из 3-х символов, либо будут равны 3-м символам; записываем найденное значение во второй массив (arr2).
Объявлям массив arr3 (длина массива равна количеству строк после применения условия)
С помощью цикла for и оператора if помещаем значения в третий массив (arr3) и отбрасываем значения, равные null.
Вывод на экран. 
