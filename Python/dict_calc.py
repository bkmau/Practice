PRICE = {
    "ACME": 45.23,
    "AAPL": 612.78,
    "IBM": 205.55,
    "HPQ": 37.2,
    "FB": 10.75,
    "CC": 10.75
}

print("Find min price in dict PRICE: {}".format(min(zip(PRICE.values(), PRICE.keys()))))

print("Find max price in dict PRICE: {}".format(max(zip(PRICE.values(), PRICE.keys()))))

print("Find max price in dict PRICE: {}".format(sorted(zip(PRICE.values(), PRICE.keys()))))

a = {
    "x": 1, "y": 2, "z": 3
}

b = {
    "w": 1, "x": 2, "y": 2
}

print("Find same keys between a and b: {}".format(a.keys() & b.keys()))

print("Find keys in a but b: {}".format(a.keys() - b.keys()))

print("Find same (key, value) pair between a and b: {}".format(a.items() & b.items()))

c = {key: a[key] for key in a.keys() - {"z", "w"}}
print(c)

