# Geometría del taxista (Manhattan Distance)

 La [Geometría del taxista](https://es.wikipedia.org/wiki/Geometr%C3%ADa_del_taxista) es la  distancia entre 2 puntos en un grid calculando tan solo el camino horizontal y/o vertical 

#### Escribe una aplicacion de consola que llame a una funcion manhattanDistance(Point, Point) en un servicio externo que devuelve la distancia entre dos puntos


## Reglas
* La clase point es inmuntable (una vez creada no puede ser cambiada)
* La clase point no tiene Gets
* La clase point no tiene propiedades public  (i.e. el estado interno de no se puede leer desde fuera de la clase)



manhattanDistance 1,1 1,1 // => returns 0

manhattanDistance 5,4 3,2 // => returns 4

manhattanDistance 1,1 0,3 // => returns 3



## Para poder hacer este ejercicio teneis 
Crear un objeto tipo Point, 
Crear un servicio Meassurement, que tenga dicho método.
Investigar si los metodos privados pueden ser accedido desde fuera de una clase (pista sí que se puede siempre y cuando sea una clase del mismo tipo).
Investigar que es inmutabilidad (ctor(x,y), readonly, private). 
Usar una libreria que te devuelva valores absolutos (System.Maths).
