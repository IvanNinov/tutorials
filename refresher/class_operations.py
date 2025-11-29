class A:
    def __init__(self): print("A init")
class B(A):
    def __init__(self):
        #super().__init__()  # calls A.__init__()
        print("B init")

class C(A):
    def __init__(self): super().__init__(); print("C")
class D(B, C):
    def __init__(self): super().__init__(); print("D")
class E(A):
    def __init__(self):
         super().__init__()
         print("E")

# b = B()
# print(B.__mro__)  # Method Resolution Order
#c = C()
#print(C.__mro__)  # Method Resolution Order
# d = D()
# print(D.__mro__)  # Method Resolution Order
e = E()
print(E.__mro__)  # Method Resolution Order