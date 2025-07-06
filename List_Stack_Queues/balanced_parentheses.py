from collections import deque

parentheses = deque(input())
open_parentheses = deque()

agenda = { "{": "}", "(":")", "[":"]"}

while parentheses:
    cur_parentheses = parentheses.popleft()
    if cur_parentheses in agenda.keys():
        open_parentheses.append(cur_parentheses)
    elif not open_parentheses:
        print("NO")
        break
    else:
        if not agenda[open_parentheses.pop()] == cur_parentheses:
            print("NO")
            break
else:
    print("YES")        
