# n = int(input())

# matrix = [[int(x) for x in input().split(", ")]  for _ in range(n)]
# primary  = [matrix[r][r] for r in range(n)]
# secondary = [matrix[r][n-r-1] for r in range(n)]
# print(f"Primary diagonal: {', '.join(str(x) for x in primary)}. Sum: {sum(primary)}")
# print(f"Secondary diagonal: {', '.join(str(x) for x in secondary)}. Sum: {sum(secondary)}")

n2 = int(input())
matrix2 = [[int(x) for x in input().split()]  for _ in range(n2)]

primary_sum, secondary_sum = 0,0

for row in range(n2):
    primary_sum += matrix2[row][row]
    secondary_sum += matrix2[row][n2-row-1]

print(abs(primary_sum - secondary_sum))
