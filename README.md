## Текстовое описание решения

1. Объявляем исходный массив со строками 
- string [] array
2. Объявляем необходимые нам переменные
- int count = 0 - счетчик
- int i = 0 - счетчик массива array
3. С помощью цикла __FOR__ проходим по всем элементам исходного массива __array__, с каждым шагом увеличивая значение счетка __i__ на __1__:
<br> внутри цикла делаем проверку оператором __IF__ длины элемента массива:

>>    *Если длина элемента массива  меньше либо равна __3__, то счетчик __count__ увеличиваем на __1__.* 


> На выходе из цикла получаем __count__ = количество элементов исходного массива __array__, длина которых __<= 3__
4. Объявляем необходимые переменные и результирующий массив __resArray__ (*в качестве количества элементов массива вводим полученное значение счетчика __count__*)
* int i = 0 - счетчик массива array
* int j = 0 - счетчик массива resArray
* string [] resArray = new string [count]
5. С помощью цикла __FOR__ проходим по всем элементам исходного массива __array__:
<br> внутри цикла делаем проверку оператором __IF__ длины элемента массива с каждым шагом увеличивая значение счетка __i__ на __1__: 

>>    *Если длина элемента массива меньше либо равна __3__, то:*
-  добавить элемент из массива __array__ в массив __resArray__
-  увеличить значение счетчика массива __resArray__ на __1__
> На выходе из цикла получаем искомый массив __resArray__ 