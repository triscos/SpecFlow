Feature: ValidacionDatosEntrada

A short summary of the feature

@ValidarEntrada
Scenario: Valido los datos de entrada de titulo
	Given Dado un libro con los datos de entrada
		| titulo | autor     | isbn |
		| a      | cervantes | 4587 |
	When Valido los datos de entrada
	Then El titulo no es valido

Scenario: Valido los datos de entrada de isbn
	Given Dado un libro con los datos de entrada
		| titulo      | autor     | isbn |
		| Don quijote | cervantes | xx   |
	When Valido los datos de entrada
	Then El isbn no es valido

Scenario: Valido los datos de entrada de autor
	Given Dado un libro con los datos de entrada
		| titulo      | autor | isbn |
		| Don quijote |       | 4587 |
	When Valido los datos de entrada
	Then El isbn no es valido

