# Задача 20: В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность. 
#            В случае с английским алфавитом очки распределяются так:A, E, I, O, U, L, N, S, T, R – 1 очко; 
#            D, G – 2 очка; B, C, M, P – 3 очка; F, H, V, W, Y – 4 очка; K – 5 очков; J, X – 8 очков; Q, Z – 10 очков. 
#            А русские буквы оцениваются так: А, В, Е, И, Н, О, Р, С, Т – 1 очко; Д, К, Л, М, П, У – 2 очка; 
#            Б, Г, Ё, Ь, Я – 3 очка; Й, Ы – 4 очка; Ж, З, Х, Ц, Ч – 5 очков; Ш, Э, Ю – 8 очков; Ф, Щ, Ъ – 10 очков. 
#            Напишите программу, которая вычисляет стоимость введенного пользователем слова. Будем считать, 
#            что на вход подается только одно слово, которое содержит либо только английские, либо только русские буквы.

# *Пример:*

# ноутбук
#     12

mark_1 = ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R','А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т']
mark_2 = ['D', 'G', 'Д', 'К', 'Л', 'М', 'П', 'У']
mark_3 = ['B', 'C', 'M', 'P', 'Б', 'Г', 'Ё', 'Ь', 'Я']
mark_4 = ['F', 'H', 'V', 'W', 'Y', 'Й', 'Ы']
mark_5 = ['K', 'Ж', 'З', 'Х', 'Ц', 'Ч']
mark_8 = ['J', 'X', 'Ш', 'Э', 'Ю']
mark_10 = ['Q', 'Z', 'Ф', 'Щ', 'Ъ']

dict_all = {1:mark_1, 2: mark_2, 3: mark_3, 4: mark_4, 5:mark_5, 8: mark_8, 10: mark_10}
sum = 0
print("Введите слово: ", sep="", end="")
word = input()
for i in range(0,len(word)):
    for key in dict_all:
        for j in range(0, len(dict_all[key])):
            if (dict_all[key][j] == word[i].upper()):
                sum +=int(key)

print(sum)
