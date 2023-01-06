# 1. Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# 6782 -> 23
# 0,56 -> 11

number = float(input('Введите вещественное число: '))
if (int(number) == number):
    a = abs(number) // 10000
    b = abs(number) // 1000 % 10
    c = abs(number) // 100 % 10
    d = abs(number) % 100 // 10
    e = abs(number) % 10
    sum = a + b + c + d + e
    print (round(sum))

else:
    a = int(abs(number) * 10) % 10
    b = int(abs(number) * 100) % 10
    c = int(abs(number) * 1000) % 10
    d = int(abs(number) * 10000) % 10
    sum = a + b + c + d
    print (sum)
