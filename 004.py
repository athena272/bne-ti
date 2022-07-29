#Link repositorio: https://github.com/athena272/BNE_TI

listaNum1 = input("informe os numeros do primeiro vetor separado por espaco: ").split()
listaNum2 = input("informe os numeros do segundo vetor separado por espaco: ").split()

#Gera a lista intercaldada
listaVector = []
for i, j in zip(listaNum1, listaNum2):
  listaVector.append(int(i))
  listaVector.append(int(j))

print(listaVector)

#Link repositorio: https://github.com/athena272/BNE_TI
