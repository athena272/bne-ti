#Link repositorio: https://github.com/athena272/BNE_TI

#classic bubbleSort
def bubbleSort(list):
    for passNum in range(len(list)-1,0,-1):
        for i in range(passNum):
            if list[i]>list[i+1]:
                temp = list[i]
                list[i] = list[i+1]
                list[i+1] = temp

list = [5, 1, 4, 2, 8]
bubbleSort(list)
print(list)

#reverse bubbleSort


#Link repositorio: https://github.com/athena272/BNE_TI
