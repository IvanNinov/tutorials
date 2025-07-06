from collections import deque

petrol_data = deque([ [int(x) for x in input().split()] for _ in range(int(input()))])
petrol_data_copy = petrol_data.copy()
tank_gas = 0
index = 0
while petrol_data_copy:
    petrol_amount,distance_between_pump =petrol_data_copy.popleft()
    tank_gas += petrol_amount

    if tank_gas >= distance_between_pump:
        tank_gas -= distance_between_pump
    else:
        petrol_data.rotate(-1)
        petrol_data_copy = petrol_data.copy()
        index += 1
        tank_gas = 0
print(index)