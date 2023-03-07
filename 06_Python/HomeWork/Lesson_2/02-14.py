# Задача 14: Требуется вывести все целые степени двойки 
#            (т.е. числа вида 2k), не превосходящие числа N.

n=0
print('Введите n:',sep="", end="")
n = int(input())
sq = 1
if n == 1: print(f"{sq} ")
else:
    while (sq<=n):
        print(f"{sq} ", sep="",end="" )
        sq = sq*2