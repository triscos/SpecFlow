### TEST DESARROLLO DE SOFTWARE


#### 2. METODOLOGÍAS DE TEST


##### 2.1 TDD (Test Driven Development)

Es una metodología de desarrollo de software que implica escribir primero las pruebas y luego el código. A menudo, las pruebas escritas en TDD son pruebas unitarias.
En TDD, el proceso generalmente sigue estos pasos:
1.	Escribe una prueba unitaria que describa una función o mejora deseada.
2.	Ejecuta la prueba, que debería fallar porque aún no has implementado la función.
3.	Escribe el código mínimo necesario para pasar la prueba.
4.	Ejecuta la prueba nuevamente. Si pasa, puedes considerar la función completa.
5.	Refactoriza el código, asegurándote de que las pruebas aún pasen después de la refactorización.

##### 2.2 BDD (Behavior Driven Development):

Similar a TDD, pero se centra en el comportamiento del sistema.
Las pruebas se escriben en un lenguaje natural, y se centran en el comportamiento del sistema.

``` specflow
Característica: Inicio de sesión
  Como usuario
  Quiero poder iniciar sesión en la aplicación
  Para acceder a mis funciones personalizadas

  Escenario: Inicio de sesión exitoso
    Dado que estoy en la página de inicio de sesión
    Cuando ingreso mi nombre de usuario y contraseña correctos
    Entonces debería ver la página de inicio

  Escenario: Inicio de sesión fallido
    Dado que estoy en la página de inicio de sesión
    Cuando ingreso un nombre de usuario o contraseña incorrectos
    Entonces debería ver un mensaje de error
```