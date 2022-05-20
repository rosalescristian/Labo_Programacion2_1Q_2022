
#Test Unitarios:

##Software Testing:

###Tipos de test(UNA PIRAMIDE):

E2E Tests : 10% 		--> Pruebas funcionales (simulan a un usuario y hacen el Punta a Punta desde la logica, la vista, las conexiones, etc) - Las hacen los QA
Integration Test 20% 	--> Pruebas Integrales (Probar q distintas partes ensambladas funcionen bien juntas) - Las hacen Developers o QA
Unit Test 70% 			--> Pruebas Unitarias ( Prueben una unidad, enfocadas en 1 parte del codigo q ayudan a verificar q esa pieza de codigo este correcta) - La hacen los desarrolladores

Al acercarnos a la base de la piramide, las pruebas son mas rapidas y mas economicas.
Debrìamos tener en nuestro sistema mayor cantidad de pruebas unitarias que las demas.

Standard de nomenclatura para la Catedra:
GIVEN / WHEN / THEN

Metodo que se prueba:
	Dividir
Escenario:
	CuandoDivisorEsCero
Resultado
	DeberiaRetonarDoubleMinValue
	
el nombre del test queda:
		Dividir_CuandoDivisorEsCero_DeberiaRetonarDoubleMinValue

Hay un patron de diseño para los test:
AAA

Arrange:
	Preparacion del metodo que se va a probar (variables con valores, etc)
Act:
	Invocacion de los metodos a probar
Assert:
	Evaluacion de resultados


###Buenas practicas segun Robert Martin:
F.I.R.S.T
Fast (Rapidas)
	Ejecutarse de forma rapida
Isolates (Independientes o Aisladas)
	No deben depender de otras
Repeatable (Repetibles)
	Deben poder repetirse en cualquier entorno
Self-Validating (Auto Validsantes)
	No requieren validacion manual, no requieren validar el resultado, tiene q ser siempre verde
Timely (Oportunas)
	Se escriben antes del codigo que vamos a probar

##Hay distintas metodologias de trabajo:
CF 	=> Code First
TDD => Test Driven Development:
	Primero escribimos el test y despues el metodo

	1) Test Fails (xq el codigo del metodo esta vacio)
	2) Test Passes (escribimos lo minimo para que el test se pase)
	3) Refactorizar

**TAREA PARA HACER EJERCICIO DE TEST UNITARIOS GUARDADOS EN EL CANAL DE SLACK**


