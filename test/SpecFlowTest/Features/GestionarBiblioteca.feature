@GestionarBiblioteca
Feature: Gestionar Biblioteca

	Como un usuario de la aplicación
    Quiero poder crear, leer, actualizar y eliminar libros
    Para que pueda gestionar mi biblioteca de libros

@tag1
Scenario: Crear y leer un libro
	Given que el usuario ha introducido los detalles del libro
		| Titulo    | Autor   | ISBN |
		| El hereje | Delibes | 456  |
	When el usuario pulsa el boton de guardar
	Then los detalles del libro con isbn "456"  se muestran en pantalla

Scenario: Crear y eliminar un libro
	Given que el usuario ha introducido los detalles del libro
		| Titulo    | Autor   | ISBN |
		| El camino | Delibes | 123  |
	When el usuario pulsa el boton de guardar
	And el usuario pulsa el boton de eliminar el libro con isbn "123"
	Then el libro con isbn "123" no se muestra en pantalla
