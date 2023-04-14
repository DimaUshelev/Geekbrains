m, n, k = int(input()), int(input()), int(input())
if k % m == 0 or k % n == 0:
     print('можно разломить на 2 прямоугольника')
else:
     print('нельзя разломить на 2 прямоугольника')