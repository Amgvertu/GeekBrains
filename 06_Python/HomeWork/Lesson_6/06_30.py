# Задача 30:  Заполните массив элементами арифметической прогрессии. Её первый элемент, 
#             разность и количество элементов нужно ввести с клавиатуры. Формула для получения n-го 
#             члена прогрессии: an = a1 + (n-1) * d.
#             Каждое число вводится с новой строки.

a=list()
print("Первый элемент арифметической прогрессии:", end="")
a.append(int(input()))
print("Разность арифметической прогрессии:", end="")
d = int(input())
print("Количество элементов арифметической прогрессии:", end="")
n = int(input())
for i in range(1,n):
    a.append(a[0]+i*d)
print(a)  