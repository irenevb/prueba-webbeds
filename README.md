# Prueba para WebBeds. Irene Vera
Prueba técnica para Webbeds

The goal is to consume the API and return a list of hotels with one final price per Board Type, with response time under 1 second.
The response will contain a list of hotels with rates.
The rates have a Board Type, Value and Rate Type (Per Night or Stay).

• If rate type is Per Night, you must calculate the final price (Value x Number of nights).

• If rate type is Stay, value is already the final price.

# Anotaciones

## Realizado en .NET Core y C#.

Se ha creado la clase Offer para poder relacionar todas las tarifas que puede tener un hotel. 

Se pide al usuario el número de noches, el id del hotel y la clave:

![image](https://user-images.githubusercontent.com/44347390/127232487-fa8e759b-5a49-4dae-8037-e4308c537a50.png)

Una vez se da a "Ejecutar", podemos ver que devuelve una respuesta en el formato esperado:

![image](https://user-images.githubusercontent.com/44347390/127232561-c34c5793-f4de-422b-8fb1-a7b94d5533fa.png)

## Se ha hecho una prueba unitaria para comprobar que con unos parámetros cualquiera existentes, devuelve una respuesta:

![image](https://user-images.githubusercontent.com/44347390/127232645-a506faac-3e6f-416f-add6-121587371d59.png)



