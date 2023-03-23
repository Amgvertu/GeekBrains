from os import path
import pathlib
from pathlib import Path

file_name = Path("06_Python","HomeWork","Lesson_8","phonebook.txt")
last_id = 0
table_header = ["id", "Фамилия", "Имя", "Отчество", "Телефон"]
table_header_eng = ["id", "surname", "name", "patronymic", "phone"]
contacts = list()

if not path.exists(file_name):
    with open(file_name, "w", encoding="utf-8") as _:
        pass

def main_menu():
    play = True
    read_all_contacts()
    while play:
        answer=input("\n Телефонная книга (меню)\n\n"
                     "1 Посмотреть все записи\n"
                     "2 Добавить контаакт\n"
                     "3 Поиск контакта\n"
                     "4 Изменить контакт\n"
                     "5 Удалить контакт\n"
                     "6 Экспорт контактов\n"
                     "7 Иимпорт контактов\n"
                     "8 Выход\n")
        match answer:
            case "1": print_contacts(contacts)
            case "2": add_contact()
            case "3": search()
            case "4": edit()
            case "5": delete()
            case "6": export()
            case "7": imp()
            
            case "8": play = False
            
#Вспомогательные методы


def unspace(value):
    return ''.join(value.splitlines())

def to_string(lst):
    if type(lst) == dict:
        lst = to_list_from_dict(lst)
    new_str=""
    for i in range(len(lst)):
        if i!=len(lst):
            new_str = new_str+str(lst[i])+" "
        else: new_str = new_str + lst[i]    
    return new_str 

def to_list_from_str(string):
    ls = string.split()
    return ls

def to_list_from_dict(dict):
    ls = list()
    for key in dict:
        ls.append(dict[key])
    return ls  

def to_dict(ls):
    contact = {}
    for i in range(len(table_header_eng)):
        contact[table_header_eng[i]] = ls[i]
    return contact    

def read_all_contacts():
    global last_id, contacts
    contacts = list()
    with open(file_name,encoding="utf8") as file:
       all_contacts = file.readlines()
    for i in range(len(all_contacts)):
        contacts.append(to_dict(to_list_from_str(all_contacts[i]))) 
    last_id = len(all_contacts)  

def print_list(ls):
    if type(ls) != list:
        ls = to_list_from_str(ls)
    print("|", end="")
    print(ls[0].center(5),"|", end="")
    print(ls[1].center(21),"|", end="")
    print(ls[2].center(21),"|", end="")
    print(ls[3].center(21),"|", end="")
    print(ls[4].center(15),"|")
 
# Методы работы меню   

#Вывести контакты
def print_contacts(contacts):
    print("\n")
    print_list(table_header)
    for i in range(95):
        if i==94: print("")
        else: print("-", end="")
    for i in range(len(contacts)):
        print_list(to_list_from_dict(contacts[i]))

#Добавить запись        
def add_contact():
    global last_id
    print("\n Введите информацию для добавления...")
    last_id +=1 
    contact = list()
    contact.append(str(last_id))
    for i in range(1,len(table_header)):
        print(f"{table_header[i]}:",end ="")
        contact.append(input())
       
    with open(file_name,'a', encoding = "utf-8") as data:
        data.write(to_string(contact))
        data.write("\n")
    contacts.append(to_dict(contact))
    print("\n Контакт успешно добавлен...") 

#Поиск записи    
def search():
    print("\n Строка поиска:", end="")
    flag=False
    searched_contacts=list()
    search_string = input()
    for i in range(len(contacts)):
        for key in contacts[i]:
            if search_string.upper() in contacts[i][key].upper():
                flag = True
                searched_contacts.append(contacts[i])
        flag=False
    print("\n Резултаты поиска:")  
    print_contacts(searched_contacts)

#Редактирование записи
def edit():
    ls_edit = list()
    print_contacts(contacts)
    print("Введите id записи, которую необходимо изменить:", end="")
    id = input()
    ls_edit.append(id)
    for i in range(1,len(table_header)):
        print(f"{table_header[i]}:",end ="")
        ls_edit.append(input())
    contacts[int(id)-1]=to_dict(ls_edit)
    new_str = ""
    for i in range(len(contacts)):
        new_str = new_str+to_string(contacts[i])+"\n"
    with open(file_name, 'w', encoding = "utf-8") as file:
        file.writelines(new_str)
    print_contacts(contacts)

#Удаление записи
def delete():
    ls_edit = list()
    print_contacts(contacts)
    print("Введите id записи, которую необходимо удалить:", end="")
    id = int(input())
    contacts.pop(id-1)
    new_str = ""
    for i in range(len(contacts)):
        contacts[i]['id'] = str(i+1)
        if i==len(contacts):
            new_str = new_str + to_string(contacts[i])
        else:
            new_str = new_str + to_string(contacts[i])+"\n"
    with open(file_name, 'w', encoding = "utf-8") as file:
        file.writelines(new_str)
    print_contacts(contacts)

#Экспорт
def export():
    print("Введите имя файла куда экспортировать записи: ", end="")
    file_name = Path("06_Python","HomeWork","Lesson_8",input())
    new_str = ""
    for i in range(len(contacts)):
        if i==len(contacts):
            new_str = new_str + to_string(contacts[i])
        else: new_str = new_str + to_string(contacts[i])+"\n"
    with open(fil,'a', encoding = "utf-8") as data:
        data.write(new_str)
    print("Контакты успешно экспортированы...")

#Импорт
def imp():
    print("Введите имя файла откуда импортировать записи: ", end="")
    path = Path("06_Python","HomeWork","Lesson_8",input())
    new_str = ""
    if not path.exists():
        print("Такого файла не существует...")
    else:
        with open(path,encoding="utf8") as file:
            all_contacts = file.readlines()
        for i in range(len(all_contacts)-1):
            new_str = new_str + all_contacts[i]
        with open(file_name, 'w', encoding = "utf-8") as file:
            file.writelines(new_str)
        read_all_contacts()
        print("Контакты успешно импортированы...")
    
    
main_menu()
