# Instituto Tecnologico Superior de Cintalapa

## Presenta:

- Darwin Amaury Natarén Arellano
- Geovanna Belén Abarca Clemente
- Ezequiel Sarmiento Morales
- Gerardo de Lucio Rosales
- Karla Ramos Camera 

## Profesor:
Cadenas Ocaña Jose Luis

## Unidad 1
Periodo Enero-Junio 2024

# Descripción General del Funcionamiento del Programa

Este programa es una aplicación de escritorio desarrollada en Visual Basic utilizando Visual Studio 2022, con una base de datos SQL Server para la gestión de la información de los alumnos de una universidad. La aplicación permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los registros de los alumnos, garantizando la integridad y seguridad de los datos, así como la usabilidad de la interfaz. Además, la aplicación incluye una funcionalidad para actualizar automáticamente el `DataGridView` con los datos más recientes de la base de datos.

## Funcionalidades Principales

### Creación de Registros

El botón **"Crear"** permite al usuario ingresar nuevos datos de un alumno (nombre, apellidos, matrícula y carrera) y almacenarlos en la base de datos. Antes de guardar los datos, se valida que la matrícula sea un número válido para evitar errores de entrada.

### Búsqueda de Registros

El botón **"Buscar"** permite al usuario buscar registros de alumnos en la base de datos. La búsqueda se realiza utilizando un valor ingresado por el usuario, que puede coincidir parcial o totalmente con el nombre, apellido paterno, apellido materno, número de control (matrícula) o carrera del alumno. Si se encuentra un registro coincidente, los datos se muestran en los campos correspondientes.

### Actualización de Registros

El botón **"Actualizar"** permite al usuario modificar los datos de un alumno existente. El usuario ingresa la matrícula del alumno a actualizar y los nuevos datos en los campos correspondientes. Luego, la aplicación actualiza el registro en la base de datos y muestra un mensaje confirmando la actualización.

### Eliminación de Registros

El botón **"Eliminar"** permite al usuario eliminar un registro de alumno de la base de datos. El usuario ingresa la matrícula del alumno a eliminar y la aplicación elimina el registro correspondiente. Se muestra un mensaje confirmando la eliminación.

### Actualización Automática del DataGridView

La aplicación incluye un temporizador que actualiza automáticamente el contenido del `DataGridView` cada 2 segundos. Esto asegura que los datos mostrados estén siempre actualizados con los cambios más recientes en la base de datos.

