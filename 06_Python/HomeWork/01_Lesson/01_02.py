x = 0
while (x<99)or(x>999):
    print("Введите трехзначное число:",sep="; ", end="")
    x = int(input())
    if (x<99)or(x>999): print('Вы ввели не трехзначное число')
x1 = int(x/100)
x2 = int(x/10%10)
x3 =  int(x%10)
sum = x1 + x2 + x3
print("Сумма цифр равна ", sum, " (", x1, "+", x2, "+", x3, ")")


