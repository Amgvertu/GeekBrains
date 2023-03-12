# Задача 26:  Напишите программу, которая на вход принимает два числа A и B, 
#             и возводит число А в целую степень B с помощью рекурсии.

# *Пример:*

# A = 3; B = 5 -> 243 (3⁵)
#     A = 2; B = 3 -> 8 

def degree(a, an, i, b):
    if (i>=b): return an
    else: 
        an *= a  
        i += 1
        return degree(a,an, i,b)
# Основная программа    
print("Введите число a:", end="")
a = int(input())
print("Введите число b:", end="")
b = int(input())
if b == 0: a = 1
else: print(degree(a,a,1,b))
    