Основное задание  
1. Класс Phone.  
Создайте класс Phone, который содержит переменные number, model и  weight.  
Создайте три экземпляра этого класса.  
 Выведите на консоль значения их переменных.  
 Добавить в класс Phone методы: receiveCall, имеет один параметр – имя  звонящего. Выводит на консоль сообщение “Звонит {name}”. 
								getNumber –  возвращает номер телефона. Вызвать эти методы для каждого из  объектов.  
Добавить конструктор в класс Phone, который принимает на вход три  параметра для инициализации переменных класса - number, model и  weight.  
Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.  
Добавить конструктор без параметров.  
Вызвать из конструктора с тремя параметрами конструктор с двумя. 
Добавьте перегруженный метод receiveCall, который принимает два  параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.  
Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено  сообщение. Метод выводит на консоль номера этих телефонов.  


2. Создать класс CreditCard c полями номер счета, текущая сумма на счету.
Добавьте метод, который позволяет начислять сумму на кредитную
карточку.
Добавьте метод, который позволяет снимать с карточки некоторую
сумму.
Добавьте метод, который выводит текущую информацию о карточке.
Напишите программу, которая создает три объекта класса CreditCard у
которых заданы номер счета и начальная сумма
Тестовый сценарий для проверки:
Положите деньги на первые две карточки и снимите с третьей.
Выведите на экран текущее состояние всех трех карточек.

Дополнительное задание  
3. Создать класс, описывающий банкомат.
Набор купюр, находящихся в банкомате, должен задаваться тремя
свойствами:
количеством купюр номиналом 20, 50 и 100.
Сделать метод для добавления денег в банкомат.
Сделать метод, снимающуий деньги, который принимает сумму денег,
а возвращает булевое значение - успешность выполнения операции.
При снятии денег метод должен распечатывать каким количеством
купюр какого номинала выдаётся сумма.
Создать конструктор с тремя параметрами - количеством купюр каждого
номинала.

4. Создать программу для имитации работы клиники.  
Пусть в клинике будет три врача: хирург, терапевт и дантист.  
Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.  Так же предусмотреть класс «Пациент» и класс «План лечения».  Создать объект класса «Пациент» и добавить пациенту план лечения.  Так же создать метод, который будет назначать врача пациенту согласно  плану лечения.  
Если план лечения имеет код 1 – назначить хирурга и выполнить метод  лечить.  
Если план лечения имеет код 2 – назначить дантиста и выполнить метод  лечить.  
Если план лечения имеет любой другой код – назначить терапевта и  выполнить метод лечить. 
