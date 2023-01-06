# 1. Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
# Пример:
# - Для N = 5: 1, -3, 9, -27, 81

# number = int(input('Введите целое число: '))
# for degree in range(number):
#     print((-3)**degree)

# number = int(input('Введите целое число: '))
# for i in range(0, number,1): # ноль и единицу можно не  включать
#     print((-3)**i)
#

# Напишите программу, которая будет на вход принимать число N и выводить числа от -N до N.
# при 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

# number = int(input('Введите целое число: '))
# for i in range(-number, number+1):
#     if i == number:
#         print(i)
#     else:
#         print(i, end = ', ')

# 2. Напишите программу, которая будет принимать на вход дробь и показывать первую цифру дробной части числа.
# *Примеры:*
# - 6,78 -> 7
# - 5 -> нет
# - 0,34 -> 3

# number = float(input('Введите дробное число: '))
# if number < 1:
#     num1 = (number *10) % 10
#     value = round(num1)
#     print(value)
# elif (number * 10) % 10 == 0:
#     print('Нет')
# else:
#     value = round(number)
#     print(value)


# n = float(input('Введите дробное число: '))
# if (int(n) == n):
#     print('Нет')
# else:
#     print(int(abs(n) * 10) % 10)

# number = float(input('Введите вещественное число: '))
# if number != int(number):
#     print(f'Первая цифра дробной части числа {number} -> {int(abs(number)*10)%10}')
# else:
#     print(f'У числа {int(number)} нет дробной части')

# number = input('Введите вещественное число: ')
# number = number.split('.')
# if len(number) > 1:
#     print(number[1][0])
# else:
#     print('Число целое')


# from decimal import Decimal
# numberD = Decimal('0.567899')
# number = 0.567899
# print(number * 10)
# print(numberD * 100)


# import random
# print(random.randint(0.100))

# from random import randint
# print(randint(0.100))

# from random import randint as RI
# print(RI(0.100))
