# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат 
#            заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)
  
from random import randint
   
print("Введите количество элементов массива:", end="")
n = int(input())
mass = [randint(1,9) for _ in range(0,n)]
print(mass)
print("Введите минимальное число:", end="")
min = int(input())
print("Введите максимальное число:", end="")
max = int(input())

new_mass_ind = list()

for i in range(0,len(mass)):
    if (mass[i]>=min)and(mass[i]<=max):
        new_mass_ind.append(i)
if len(new_mass_ind)>0: print(new_mass_ind)
else: print("Нет элементов в этом диапазоне")
