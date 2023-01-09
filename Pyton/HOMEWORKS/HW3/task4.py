# 4.Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# 45 -> 101101
# 3 -> 11
# 2 -> 10

number = int(input('Введите число: '))
n = number
my_list = []
while n > 0:
    num = n % 2
    my_list.append(str(num))
    n = n // 2
my_list.reverse()
num = int(''.join(my_list))
print(f'десятичное число "{number}" в двоичной системе = "{num}"')
