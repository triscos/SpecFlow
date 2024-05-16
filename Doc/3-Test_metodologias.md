# DESARROLLO GUIADO POR PRUEBAS

## 1. QU� ES DESARROLLO GUIADO POR PRUEBAS

Es una metodolog�a de desarrollo cuyo objetivo es crear primero las pruebas y luego escribir el software.

<img src="./Images/tipos_metodologias.png"
     alt="ciclo de vida TDD"
     style="width:50%; heigth=50%" />

## 3. TIPOS DE METODOLOG�AS


### 3.1 TDD (Test Driven Development)

La idea es que los requisitos sean traducidos a pruebas, de este modo, cuando las pruebas pasen se garantizar� que el software cumple con los requisitos.

Para escribir las pruebas generalmente se utilizan las pruebas unitarias.

En TDD, el proceso generalmente sigue estos pasos:
1.	Escribe una prueba unitaria que describa una funci�n o mejora deseada.
2.	Ejecuta la prueba, que deber�a fallar porque a�n no has implementado la funci�n.
3.	Escribe el c�digo m�nimo necesario para pasar la prueba.
4.	Ejecuta la prueba nuevamente. Si pasa, puedes considerar la funci�n completa.
5.	Refactoriza el c�digo, asegur�ndote de que las pruebas a�n pasen despu�s de la refactorizaci�n.

#### Ciclo de vida

<!--![Drag Racing](./Images/How-TDD-Works.png)-->

<img src="./Images/LifeCycleTDD.png"
     alt="ciclo de vida TDD"
     style="width:20%; heigth=20%" />

### 3.2 BDD (Behavior Driven Development):

Similar a TDD, pero se centra en el comportamiento del sistema.

Las pruebas se escriben en **Gherkin**, un lenguaje muy cercano al natural, evitando usar palabras muy t�cnicas.


Un ejemplo de una prueba BDD podr�a verse as�:
``` specflow
Feature: Inicio de sesi�n
  Como usuario quiero poder iniciar sesi�n en la aplicaci�n 

  Scenario: Inicio de sesi�n exitoso
    Given -> Dado que estoy en la p�gina de inicio de sesi�n
    When -> Cuando ingreso mi nombre de usuario y contrase�a correctos
    Then -> Entonces deber�a ver la p�gina de inicio  
```


#### Pasos para realiazar test en BDD

1. Primero, se realiza un an�lisis de requisitos en el que se especifican las tareas, los objetivos y las funciones del software. 
2. Despues se describen en forma de escenarios predefinidos: (por ejemplo en lenguaje Gherkin)
3. Por �ltimo se implementan los test.
  
<img src="./Images/BDD_test.png"
     alt="ciclo de vida TDD"
     style="width:40%; heigth=40%" />

#### TDD vs BDD

TDD y BDD son complementarias, no alternativas.

- TDD se centra en las pruebas unitarias (bajo nivel), 

- BDD se centra en el comportamiento del sistema (alto nivel).

<img src="./Images/tdd_bdd.png"
     alt="ciclo de vida TDD"
     style="width:30%; heigth=30%" />