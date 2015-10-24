import sys
try:
	for arg in sys.argv:
		print(arg)
except IndexError:
	print("usage: cmdAndArgv.py <number>")