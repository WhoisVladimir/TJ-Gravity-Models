# Gravity models
___

![](https://i.postimg.cc/Dz4cTZ02/2022-09-14-13-00-08.png)

Проект - результат тестового задания.
В проекте реализованы паттерны DI, MVVM. Фигуры рандомно генерируются на старте игры, в соответствии с заданными праметрами. 

### Текст задания:
1. Создайте Unity3d-приложение (2020.3 LTS) с единственной сценой. На сцене должны
присутствовать две произвольные конструкции, состоящие из нескольких элементов
(например, кубов). Обе конструкции должны притягиваться к некоторому объекту в сцене
таким образом, чтобы гарантированно сталкиваться друг с другом (но не с объектом). При
столкновении конструкции должны разлетаться на произвольное, но достаточно большое
расстояние. Также при столкновении требуется окрашивать соприкасающиеся элементы
конструкций.

2. Интерфейс пользователя состоит из таймера, счетчика столкновений и кнопки.
а) Таймер должен отсчитывать время от нуля, в секундах.
б) Счетчик столкновений должен учитывать только столкновения конструкций в целом, т.е.
если при столкновении соприкоснулось несколько элементов конструкций, счетчик должен
увеличиться на единицу.
в) Кнопка должна сбрасывать таймер и счетчик в исходное значение.

Будет оцениваться:
а) степень выполнения поставленных в задаче требований
б) надежность (по наличию сбоев)
в) производительность (в сравнении с образцом, по среднему времени кадра и динамике
потребления памяти)
г) качество кода (по наличию дублирования логики, избыточности операций и зависимостей и
т.д.)
д) читаемость кода (общая грамотность, соответствие названий переменных и членов
классов их назначению и т.д.)
