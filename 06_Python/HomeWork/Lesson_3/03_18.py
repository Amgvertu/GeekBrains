# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. 
#            Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
#            В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

# *Пример:*

# 5
#     1 2 3 4 5
#     6
#     -> 5


list_d = [int(input()) for _ in range(int(input()))]
print(list_d)
x = int(input())
mindiff = abs(list_d[0]-x)
min = list_d[0]
for el in list_d:
    if (abs(el-x))<mindiff:
        print(f"{abs(el-x)}  :  {mindiff}")
        print (el)
        mindiff = (abs(el-x))
        min = el
print(f"Минимальный элемент: {min}")
        