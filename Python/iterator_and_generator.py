splitter = "{:+<200}".format("")
print("Reference: Python Practice Book 5. Iterators & Generators "
      "http://anandology.com/python-practice-book/iterators.html")
print(splitter)

print("Iterators")
l = [1, "a", 5, "CDE"]
print("Print out all item of list, {} using for-loop".format(l))
for item in l:
    print(item)

d = {"name": "John", "gender": "male", "age": 45, "job": "postman"}
print("Print out all key of dictionary, {} using for-loop".format(d))
for item in d.items():
    print(item)

s = "Hello World!"
print("Print out all character of string, {} using for-loop".format(s))
for c in s:
    print(c)
print(splitter)
print("Build-in Function iter(), Python doc https://docs.python.org/3.5/library/functions.html#iter"
      " and https://docs.python.org/3.5/library/stdtypes.html#typeiter")

print(splitter)

print("Generator")

print("Iterate all item in list and square it then store in list...")
def square_nums(nums):
    result = []
    for n in nums:
        result.append(n * n)
    return result

print(square_nums([1, 2, 3, 4, 5]))

print("Using generator...")
def square_nums_using_generator(nums):
    for n in nums:
        yield n * n

my_num = square_nums_using_generator([1, 2, 3, 4, 5])
print(next(my_num))
print(next(my_num))
print(next(my_num))
print(next(my_num))
print(next(my_num))
# print(next(my_num))

print("Cast a generator to a list...")
my_num = list(square_nums_using_generator([1, 2, 3, 4, 5]))
print(my_num)
# print(next(my_num))

print("Using list comprehension...")
my_num = [n * n for n in [1, 2, 3, 4, 5]]
print(my_num)


print("Using list comprehension...")
my_num = [n * n for n in [1, 2, 3, 4, 5] if not (n % 2)]
print(my_num)

print("Using list comprehension...")
d = {n: n * n for n in [1, 2, 3, 4, 5] if not (n % 2)}
print(d)

print("Using list comprehension...")
s = {w for w in "hello world" if w in "low level" and w.strip()}
print(s)

from pprint import pprint

''' buzzers.csv
TIME,DESTINATION
09:35,FREEPORT
17:00,FREEPORT
09:55,WEST END
19:00,WEST END
10:45,TREASURE CAY
12:00,TREASURE CAY
11:45,ROCK SOUND
17:55,ROCK SOUND
'''
with open("buzzers.csv", "r") as f:
    ignore = f.readline()
    to_list = [line.strip().split(",") for line in f.readlines()]
    to_dict = {k: v for k, v in to_list}
    pivot_key_set = set([v for k, v in to_list])
    pprint(to_dict)

    pivot_dict = {item: [v for v, k in to_list if k == item] for item in pivot_key_set}
    pprint(pivot_dict)

