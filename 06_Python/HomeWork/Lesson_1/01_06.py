# Задача 6: Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером. 
#           Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме 
#           последних трех. Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать программу, 
#           которая проверяет счастливость билета.

# *Пример:*

# 385916 -> yes
# 123456 -> no

x=385916
s1=0
s2=0
while (x<99999)or(x>999999):
    print("Введите шестизначное число:", sep=' ', end='')
    x=int(input())
    if (x<99999)or(x>999999):
        print("Вы ввели не шестизначное число!!! Попробуйте еще раз...")
count= 1
while (count<100001):
    if count<101:
        s1 = s1+int(x/count%10)
    else:
        s2 = s2+int(x/count%10)
    count =count*10
    
if s1 == s2:
    print(f"{x} -> yes")
else:
    print(f"{x} -> no")