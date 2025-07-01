from collections import deque
numbers = deque(input().split())

#solution 1
# for _ in range(len(numbers)):
#     print(numbers.pop(), end=" ")

#solution 2
#print(' '.join([numbers.pop() for x in range(len(numbers))]))

#solution 3
numbers.reverse()
print(' '.join(numbers))