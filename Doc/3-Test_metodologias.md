### PRUEBAS DE SOFTWARE


#### 2. METODOLOG�AS DE TEST


##### 2.1 TDD (Test Driven Development)

Es una metodolog�a de desarrollo de software que implica escribir primero las pruebas y luego el c�digo. 

A menudo, las pruebas escritas en TDD son pruebas unitarias.

En TDD, el proceso generalmente sigue estos pasos:
1.	Escribe una prueba unitaria que describa una funci�n o mejora deseada.
2.	Ejecuta la prueba, que deber�a fallar porque a�n no has implementado la funci�n.
3.	Escribe el c�digo m�nimo necesario para pasar la prueba.
4.	Ejecuta la prueba nuevamente. Si pasa, puedes considerar la funci�n completa.
5.	Refactoriza el c�digo, asegur�ndote de que las pruebas a�n pasen despu�s de la refactorizaci�n.

###### Ciclo de vida

<!--![Drag Racing](./Images/How-TDD-Works.png)-->

<img src="./Images/How-TDD-Works.png"
     alt="ciclo de vida TDD"
     style="width:65%; heigth=65%" />

##### 2.2 BDD (Behavior Driven Development):

Similar a TDD, pero se centra en el comportamiento del sistema.

Las pruebas se escriben en un lenguaje natural.

Evita usar palabras t�cnicas, para que lo entiendan tanto los desarrolladores como usuarios.

Por ejemplo, en BDD, un escenario de prueba podr�a verse as�:
``` specflow
Feature: Inicio de sesi�n
  Como usuario quiero poder iniciar sesi�n en la aplicaci�n 

  Escenario: Inicio de sesi�n exitoso
    Given -> Dado que estoy en la p�gina de inicio de sesi�n
    When -> Cuando ingreso mi nombre de usuario y contrase�a correctos
    Then -> Entonces deber�a ver la p�gina de inicio  
```

###### Pasos para realiazar test en BDD

1. Se discuten los requisitos entre desarrolladores, probadores y partes interesadas
2. Define el comportamiento en lenguaje Gherkin
3. Se implementan los test.
  
<img src="./Images/BDD_test.png"
     alt="ciclo de vida TDD"
     style="width:65%; heigth=65%" />