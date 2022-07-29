#Link repositorio: https://github.com/athena272/BNE_TI

#classic bubbleSort
def bubbleSort(list):
    for passNum in range(len(list)-1,0,-1):
        for i in range(passNum):
            if list[i]>list[i+1]:
                temp = list[i]
                list[i] = list[i+1]
                list[i+1] = temp
    
    return list

#reverse bubbleSort
def inverseBubbleSort(list):
    for passnum in range(len(list)-1,0,-1):
        for i in range(passnum):
            if list[i]<list[i+1]:
                temp = list[i]
                list[i] = list[i+1]
                list[i+1] = temp

    return list

#main code
list = [5, 1, 4, 2, 8]
print(bubbleSort(list))
print(inverseBubbleSort(list))

#Link repositorio: https://github.com/athena272/BNE_TI
