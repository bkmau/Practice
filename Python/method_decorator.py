class AObject:
    def __init__(self, identifier):
        self.__identifier = identifier

    def update_val_by_instance_method(self, value):
        print("{: <50}: {}".format("while method call, the reference is", id(self)))
        self.__identifier = value

    @classmethod
    def update_val_by_class_method(cls, value):
        print("{: <50}: {}".format("while method call, the reference is", id(cls)))
        cls.__identifier = value

    @staticmethod
    def update_val_by_static_method(obj, value):
        print("{: <50}: {}".format("while method call, the reference is", id(obj)))
        obj.__identifier = value


    def __str__(self):
        return "I am {}".format(self.__identifier)


john = AObject("John")

print("print obj...{}".format(john))
print("{: <50}: {}".format("before call instance method", id(john)))
john.update_val_by_instance_method("David")
print("{: <50}: {}".format("after call instance method", id(john)))
print("print obj...{}".format(john))
del john

print("")

john = AObject("John")
print("print obj...{}".format(john))
print("{: <50}: {}".format("before call class method", id(john)))
john.update_val_by_class_method("David")
print("{: <50}: {}".format("after call class method", id(john)))
print("print obj...{}".format(john))
del john

print("")
john = AObject("John")
print("print obj...{}".format(john))
print("{: <50}: {}".format("before call static method", id(john)))
john.update_val_by_static_method(john, "David")
print("{: <50}: {}".format("after call static method", id(john)))
print("print obj...{}".format(john))
del john