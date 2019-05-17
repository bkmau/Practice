import hashlib

method = hashlib.sha256()

method.update(b"Hello World")
print("binary: {}".format(method.digest()))
print("string: {}".format(method.hexdigest()))
print("len of string: {}".format(len(method.hexdigest())))
