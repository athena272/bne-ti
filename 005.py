from math import sqrt

ARESTA = 29#cm

altura = float(input("Informe a altura da piramede: "))

#Apotema
apotema = sqrt((ARESTA/2) ** 2 - altura ** 2) 

#area faces laterais, sao 4
areaFaces = 4 * (apotema * ARESTA)

#area da base, ela eh quadrada
areaBase = ARESTA ** 2

