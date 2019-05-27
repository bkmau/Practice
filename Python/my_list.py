class MyList(list):
    def __sub__(self, b):
        # print("self is {},\r\nb is {}".format(self, b))
        while len(b) > 0:
            item = b.pop()

            if item in self:
                self.remove(item)
                
        # print("self is gonna to be {}".format(self))
        return self
    
    def __add__(self, b): 
        # print("self is {},\r\nb is {}".format(self, b))
        while len(b) > 0:
            self.append(b.pop())
                
        # print("self is gonna to be {}".format(self))
        return self

print("MyList addistion: {0} + {1} = {2}\r\nMyList substraction: {0} - {1} = {3}".format(
    MyList(["a", 15, 1.2, ("a", "b")]), MyList([15, ("a", "b")]),
        (MyList(["a", 15, 1.2, ("a", "b")]) + MyList([15, ("a", "b")])),
        (MyList(["a", 15, 1.2, ("a", "b")]) - MyList([15, ("a", "b")]))
))
