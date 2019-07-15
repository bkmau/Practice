def double(arg):
    print("{}({}):{}".format("Before", id(arg),arg))
    arg = arg * 2
    print("{}({}):{}".format("After ", id(arg), arg))

def change(arg):
    print("{}({}):{}".format("Before", id(arg), arg))
    arg.append("More data")
    print("{}({}):{}".format("After ", id(arg), arg))

num = 10
double(num)
print("{}({}):{}\r\n".format("After ", id(num), num))

saying = "hello "
double(saying)
print("{}({}):{}\r\n".format("After ", id(saying), saying))


numbers = [42, 256, 16]
double(numbers)
print("{}({}):{}\r\n".format("After ", id(numbers), numbers))

numbers2 = [42, 256, 16]
change(numbers2)
print("{}({}):{}\r\n".format("After ", id(numbers2), numbers2))