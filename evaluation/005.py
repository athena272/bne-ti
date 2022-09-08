#Link repositorio: https://github.com/athena272/BNE_TI

ARESTA = 29#cm

altura = float(input("Informe a altura da piramede: "))

#Apotema
apotema = (ARESTA/2) ** 2 + altura ** 2
apotema = (apotema) ** (1/2)

#area faces laterais, sao 4
areaFaces = (apotema * ARESTA) / 2
areaFaces = 4 * areaFaces

#area da base, ela eh quadrada
areaBase = ARESTA ** 2

#area total de total
areaTotal = areaFaces + areaBase
print(areaTotal)

#Link repositorio: https://github.com/athena272/BNE_TI
