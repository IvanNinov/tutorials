from collections import deque
quantity_of_food = int(input())
sequence = deque([int(x) for x in input().split()])
print(f"{max(sequence)}")

total_sum = 0
while sequence:
    if (total_sum + sequence[0]) >= quantity_of_food:
        print("Orders left: ", end="")
        print(*sequence, sep=" ")
        break
    total_sum += sequence.popleft()
else:
    print("Orders complete")

