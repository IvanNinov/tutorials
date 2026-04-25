from gettext import find
from functools import reduce
import math


x = 5
y,z = (1,2)
a,b,c,d = 10, 20, 30, 40
e = 4.755644545
print(f"The value of x is: {x}")
print(f"The values of y and z are: {y}, {z}")
print(f"{math.floor(e*100)/100:.2f}")
print(f"{e:.2f}")

x, y = True, False
print((x or y) == True)
print((x and y) == False)
print((not y) == True)
print(x and not y)
print(not x and y or x)
print(str(5*10+5) == '55')

#strings

y = "   This is lazy\t\n    "
print(y)
print(y.strip())
print(y)
print("DrDre".lower())
print("attention".upper())
print("smartphone".startswith("smart"))
print("smartphone".endswith("phone"))
print("another".find("other"))
print("another"["another"
                .find("other"):]
                .upper()
                .lower())
print(reduce(lambda str, func: func(str),
       [lambda s: s[s.find("other"):],
       str.upper,
       str.lower],
         "another"))
print("".join([c for c in "another"["another".find("other"):].upper().lower()]))
print("cheat".replace("ch","m"))
print(",".join(["F","B", "I"]))
print(len("Rumpelstiltskin"))
print("ear" in "earth")

def f() -> None:
    x = 2

print(f() is None)
print("" == None)
print(0 == None)
print([3] is [3])

hero = "Harry"
guide = "Dumbledore"
enemy = "Lord V."

characters = {hero, guide, enemy}
print(characters)
clone_army = {hero, hero, hero, hero, enemy}
print(clone_army)

calories = {"apple" : 52, "banana" : 89, "choco" : 546}
print(calories["apple"] < calories["choco"])
calories["cappu"] = 74
print(calories["banana"] < calories["cappu"])
print("apple" in calories.keys())
print(52 in calories.values())

for key,value in calories.items():
    print(key) if value > 500 else None

print(42 in [2, 39, 42])
print("21" in {"2", "39", "42"})
print("list" in {"list" : [1, 2, 3], "set" : {1,2,3}})

customers = [("John", 240000),
             ("Alice", 120000),
             ("Ann", 1100000),
             ("Zach", 44000)]

customers_dict = {"John" :240000,
                  "Alice" :120000,
                  "Ann" :1100000,
                  "Zach" :44000}
whales = [x for x,y in customers_dict.items() if y>1000000]
print(whales)