# coding=UTF-8
import cmath
import math
import sys

# 解決windows 支援uncode的問題
# 檢查encoding，若不是uncode就停止程式
if sys.stdin.encoding != 'UTF-8':
    print("encoding: ", sys.stdin.encoding)
    sys.exit(0)
# 用其他的字符取代
# SQUARED = "\N{SUPERSCRIPT TWO}"
# ARROW = "\N{RIGHTWARDS ARROW}"
# if not sys.platform.startswith("linux"):
#     SQUARED = "^2"
#     ARROW = "->"

def getFloat(msg, allow_zero):
    x = None
    while x is None:
        try:
            x = float(input(msg))
            if (not allow_zero) and  (abs(x) < sys.float_info.epsilon):
                print("zero is not allowed")
                x = None
        except ValueError as err:
            print(err)
    return x

def discriminate(a, b, c):
    ans = None
    if a != 0 :
        discriminant = (b ** 2) - (4 * a * c)
        if discriminant == 0:
            ans = -b / (2 * a)
        else:
            if discriminant > 0:
                root = math.sqrt(discriminant)
            else:
                root = cmath.sqrt(discriminant)
            ans = (((-b + root) / (2 * a)), ((b + root) / (2 * a)))
    elif b != 0:
        ans = -c / b
            
    return ans
    
a = getFloat("enter a : ", True)
b = getFloat("enter b: ", True)
c = getFloat("enter c: ", True)
ans = discriminate(a, b, c)
equation = ""
if a != 0:
    equation = ("{0:+}x\N{SUPERSCRIPT TWO}").format(a)
    
if b != 0:
    equation = equation + "  {0:+}x".format(b)
    
if c != 0:
    equation = equation + " {0:+} = 0".format(c)
    
if ans is None:
    equation = "No Solution..."
elif type(ans) == tuple:
    equation =  equation + " \N{RIGHTWARDS ARROW} x = {0} or x = {1}".format(ans[0], ans[1])
else:
    if a == 0 and b ==0 and c == 0:
        equation = "obviously, x is 0"
    else:
        equation = equation + "\N{RIGHTWARDS ARROW} x = {0}".format(ans)

print(equation)