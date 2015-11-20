import sys

import sys

Zero = ["  *****  ", " *     * ", "*       *", "*       *", "*       *", " *     * ",  "  *****  "]
One = ["   **    ", "  ***    ", " *  *    ", "*   *    ", "    *    ", "    *    ", "*********"]
Two = ["   ***** ", " *      *", "*      * ", "*    *   ", "   *     ", " *       ", "*********"]
Three = ["*********", "        *", "        *", "*********", "        *", "        *", "*********"]
Four = ["*     *  ", "*     *  ", "*     *  ", "*     *  ", "*********", "      *  ", "      *  "]
Five = ["*********", "*        ", "*        ", "*********", "        *", "        *", "*********"]
Six = ["*********", "*        ", "*        ", "*********", "*       *", "*       *", "*********"]
Seven = ["*********", "*       *", "*       *", "       * ", "      *  ", "     *   ", "    *    "]
Eight = ["*********", "*       *", "*       *", "*********", "*       *", "*       *", "*********"]
Nine = ["*********", "*       *", "*       *", "*********", "        *", "        *", "*********"]
Numbers = [Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine]

try:
	input_num = sys.argv[1]
	row = 0
	while row < 7:
		line = ""
		column = 0
		while column < len(input_num):
			number = Numbers[int(input_num[column])]
			for c in number[row]:
				if c == "*":
					c = str(input_num[column])
				line += c
			line += "   "
			column += 1
		print(line)
		row += 1
except IndexError:
	print("usage: bigdigits.py <number>")
except ValueError as err: 
	print(err, "in", input_num)