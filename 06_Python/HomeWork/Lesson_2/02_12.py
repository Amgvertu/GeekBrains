# Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике. 
#            Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает 
#            две подсказки. Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.

flag = False
s=0
p=0
print("Введите сумму S двух натуральных чисел x, y и произведение этих чисел(X,Y≤1000)")
while (s<2)or(s>2000)or(p<2)or(p>1000000):
    print(f"S = ",sep="", end="")
    s = int(input())
    print(f"P = ",sep="", end="")
    p = int(input())
    if (s<2)or(s>2000)or(p<2)or(p>1000000): print("Введенные числа противоречат условию X,Y≤1000")
d = s*s-4*p
if d==0:
    x = s/2
    y=s-x
    flag = True
elif d>0:    
    x=(s+d**0.5)/2
    y = (s-d**0.5)/2
    flag = True
if (flag == True)and(x%1*100000000==0)and(y%1*100000000==0):
    print(f"x={x}; y={y}")
else:
    print("Условия задачи не выполняются")



