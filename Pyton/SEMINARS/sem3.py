# file = open('text.txt', 'w', encoding='UTF-8')
# file.write('Записать эту строку')
# file.close()
#
# file = open('text.txt', 'r', encoding='UTF-8')
# data = file.readline()
# file.close()
#
# print(data)
# print(type(data))
#
# file = open('text.txt', 'a', encoding='UTF-8')
# file.write('\nеще одну строчку добавим')
# file.close()

# with open('text.txt', 'w', encoding='UTF-8')
#     data.write('sfagsfgah')
#     data.write('233223')
#
# print(data)


# 2. Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.

# text = ['Напишите программу', 'которая определит', 'присутствует ли в заданном списке', 'строк некое число']
# search = 'строк'

# for i in range(len(text)):
#     if search in text[i]:
#         print(f"В элементе с индексом: {i} -> 'Элемент найден'")
#
#     else:
#         print('Такого элемента нет')

# for item in text:
#     if item.find(str(search)) != -1:
#         print(f'В строке {item} есть подстрока {search}')


# 3. Напишите программу, которая определит позицию второго
# вхождения строки в списке либо сообщит, что её нет.
# *Пример:*
# - список: ["qwe", "asd", "zxc", "qwe", "ertqwe"], ищем: "qwe", ответ: 3
# - список: ["йцу", "фыв", "ячс", "цук", "йцукен", "йцу"], ищем: "йцу", ответ: 5
# - список: ["йцу", "фыв", "ячс", "цук", "йцукен"], ищем: "йцу", ответ: -1
# - список: ["123", "234", 123, "567"], ищем: "123", ответ: -1
# - список: [], ищем: "123", ответ: -1

# text = []
# search = '123'
# count = 0
#
# for i in range(len(text)):
#         if text[i] == search:
#             count +=1
#             if count == 2:
#                 print(f'ищем: "{search}" -> ответ: {i}')
#                 break
# else:
#     print(f'ищем: "{search}" -> ответ: -1')

# import random
# my_list = []
# for _ in range(10):
#     index = random.randint(0,3)
#     my_list.append(round(random.uniform(0, 10), index))
# print(my_list)



