# Задача 4: Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов. 
#           Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали 
#           одинаковое количество журавликов, а Катя сделала в два раза больше журавликов, 
#           чем Петя и Сережа вместе?

# *Пример:*

# 6 -> 1  4  1
# 24 -> 4  16  4
#     60 -> 10  40  10

x=0
while (x%6>0)or(x<6):
    print("Введите количество журавликов:", sep=' ', end='')
    x=int(input())
    if (x%6>0)or(x<6):
        print("По условиям задачи Катя, Петя и Сережа не могли сделать столько журавликов...")
one = int(x/6);        
print(f"{x} -> {one} {one*4} {one}")