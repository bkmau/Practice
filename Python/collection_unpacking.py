p = (4, 5)
x, y = p
print("x = {}, y = {}".format(x, y))

data = ["ace", 50, 59.2, (2019, 5, 17)]
name, shares, price, date = data
print("name = {}, shares = {}, price = {}, date = {}".format(name, shares, price, date))

data = ["ace", 50, 59.2, (2019, 5, 17)]
_, shares, price, _ = data
print("shares = {}, price = {}, _ = {}".format(shares, price, _))

data = [1, 2, 3, 5, 6, 7, 8, 9, 0]
*head, tail = data
print("head = {}, tail = {}".format(head, tail))


records = [
    ("foo", 1, 2),
    ("bar", "lala"),
    ("foo", 3, 4)
]

def do_foo(x, y):
    print("foo", x, y)

def do_bar(s):
    print("bar", s)

for tag, *args in records:
    do_foo(*args) if tag == "foo" else do_bar(*args)
