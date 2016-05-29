import sys
try:
	for arg in sys.argv:
		if arg == 'sys_argv.py':
			print('hello, sys_argv.py')
		else:
			print(arg)
except IndexError:
	print("usage: cmdAndArgv.py <number>")