from collections import deque
import random
import sys

quanity = 0
for i, arg in enumerate(sys.argv):
    print("argv[{}] = {}".format(i, arg))
    try:
        quanity = int(arg)
    except:
        quanity = 0

q = deque(maxlen=quanity)

data = [random.randint(0, 99) for i in range(100)]

print(data)


for item in data:
    q.append(item)

print(q)

