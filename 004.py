listaNum = input("informe os numeros do primeiro vetor separado por espaco: ").split()
listaNum2 = input("informe os numeros do segundo vetor separado por espaco: ").split()

listaVector = []
for i, j in zip(listaNum, listaNum2):
  listaVector.append(int(i))
  listaVector.append(int(j))

print(listaVector)

