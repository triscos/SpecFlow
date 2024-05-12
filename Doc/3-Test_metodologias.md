### TEST DESARROLLO DE SOFTWARE


#### 2. METODOLOG�AS DE TEST


##### 2.1 TDD (Test Driven Development)

Es una metodolog�a de desarrollo de software que implica escribir primero las pruebas y luego el c�digo. A menudo, las pruebas escritas en TDD son pruebas unitarias.
En TDD, el proceso generalmente sigue estos pasos:
1.	Escribe una prueba unitaria que describa una funci�n o mejora deseada.
2.	Ejecuta la prueba, que deber�a fallar porque a�n no has implementado la funci�n.
3.	Escribe el c�digo m�nimo necesario para pasar la prueba.
4.	Ejecuta la prueba nuevamente. Si pasa, puedes considerar la funci�n completa.
5.	Refactoriza el c�digo, asegur�ndote de que las pruebas a�n pasen despu�s de la refactorizaci�n.

##### 2.2 BDD (Behavior Driven Development):

Similar a TDD, pero se centra en el comportamiento del sistema.
Las pruebas se escriben en un lenguaje natural, y se centran en el comportamiento del sistema.

``` specflow
Caracter�stica: Inicio de sesi�n
  Como usuario
  Quiero poder iniciar sesi�n en la aplicaci�n
  Para acceder a mis funciones personalizadas

  Escenario: Inicio de sesi�n exitoso
    Dado que estoy en la p�gina de inicio de sesi�n
    Cuando ingreso mi nombre de usuario y contrase�a correctos
    Entonces deber�a ver la p�gina de inicio

  Escenario: Inicio de sesi�n fallido
    Dado que estoy en la p�gina de inicio de sesi�n
    Cuando ingreso un nombre de usuario o contrase�a incorrectos
    Entonces deber�a ver un mensaje de error
```