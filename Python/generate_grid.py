import random
def get_int(msg, minium, default):
	while True:
		try:
			line = input(msg)
			if not line and default is not None:
				return default
			i = int(line)
			if i < minium:
				print("must be >= ", minium)
			else:
				return i
		except ValueError as err:
			print(err)

rows = get_int("row: ", 1, None)
columns = get_int("column: ", 1, None)

minium = get_int("minium(or Enter for 0)", -1000000, 0)

default = 1000
if default < minium:
	default = 2 * minium

maxium = get_int("maxium(or Enter for " + str(default) + "): ",
	minium, default)

row = 0
while row < rows:
	line = ""
	column = 0
	while column < columns:
		i = random.randint(minium, maxium)
		line += " " + str(i)
		column += 1
	print(line)
	row += 1