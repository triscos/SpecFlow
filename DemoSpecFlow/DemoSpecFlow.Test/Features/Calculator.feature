Feature: CRUD LIBROS
Insertar, borrar, listar y eliminar un libro

@mytag
Scenario: Añado un nuevo libro a la biblioteca
	Given El libro con el siguiente titulo "El principito", autor "Antoine de Saint-Exupéry" y isbn "1943"
	When Inserto el libro a la biblioteca
	Then El libro con el titulo "1943" debería ser añadido correctamente

Scenario: Modifico un nuevo libro a la biblioteca
	Given El libro con el siguiente con el isbn "1943"
	When Modifico el autor del libro a "A. Saint-Exupéry"
	Then El libro con el autor "A. Saint-Exupéry" debería ser modificado correctamente