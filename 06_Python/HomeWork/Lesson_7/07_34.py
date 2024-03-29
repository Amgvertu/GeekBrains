# Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. Поскольку разобраться в его 
#             кричалках не настолько просто, насколько легко он их придумывает, Вам стоит написать программу. 
#             Винни-Пух считает, что ритм есть, если число слогов (т.е. число гласных букв) в каждой фразе 
#             стихотворения одинаковое. Фраза может состоять из одного слова, если во фразе несколько слов, 
#             то они разделяются дефисами. Фразы отделяются друг от друга пробелами. Стихотворение  Винни-Пух 
#             вбивает в программу с клавиатуры. В ответе напишите “Парам пам-пам”, если с ритмом все в порядке и 
#             “Пам парам”, если с ритмом все не в порядке.

# *Пример:*

# **Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да    
# **Вывод:** Парам пам-пам  

def glasnum(str):
    mark_gl = ['А', 'Е', 'И', 'О', 'У', 'Ё', 'Я', 'Ы', 'Э', 'Ю']
    sumglas = 0
    for i in range(len(str)):
        for j in range(len(mark_gl)):
            if str[i].upper() == mark_gl[j]:
                sumglas +=1
    return sumglas
# Основная программа
text = "пара-ра-рам рам-пам-папам па-ра-па-да"
#text = "пп пп пп"
print(text,"\n")
text = text.replace("-","")
textspl = text.split()
glas=list(map(glasnum,textspl))
if (glas[0]!=0):
    bl=list(filter(lambda x: x!=glas[0],glas ))
    if (len(bl)==0): print("Парам пам-пам")
    else: print("Пам парам")
else: print("Пам парам")