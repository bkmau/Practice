import sys
import os

#path = sys.argv[0]
#prefix = sys.argv[1]
#extension = sys.argv[2]
files = os.listdir()
print("file\b\bextension")
for f in files:
	print(f, "\b\b", os.path.basename(f).extsep)
	#new_name = prefix + f
	#os.rename(f, new_name)
