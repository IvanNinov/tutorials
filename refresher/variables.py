from gettext import find
import math


x = 5
y,z = (1,2)
a,b,c,d = 10, 20, 30, 40
e = 4.755644545

print(f"The value of x is: {x}")
print(f"The values of y and z are: {y}, {z}")
print(f"{math.floor(e*100)/100:.2f}")
print(f"{e:.2f}")


array_of_strings = ['Coding', 'For' , 'All'] # array of example string
all_string = " ".join(array_of_strings)     #join the array into string with elements separated by " "
print(all_string)
print(all_string[ :all_string.find(" ")])   # find the firrst word
print(all_string[ all_string.rfind(" ") + 1:]) # find last word
print(all_string.split(" ")) # split string by space
challange = "Facebook, Google, Microsoft, Apple, IBM, Oracle, Amazon"
print(challange.split(", ")) # split string by ", "
print(all_string[0]) # character in the first index
print(len(all_string) - 1) # last index of Coding For All
countries = ['Germany', 'France','Belgium','Sweden','Denmark','Finland','Norway','Iceland','Estonia']

gr,fr,bg,sw,*scandic,es = countries

print(scandic)
