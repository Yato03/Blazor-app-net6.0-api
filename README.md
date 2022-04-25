# Blazor-app-net6.0-api
App de listado de tareas full stack

## Descripción del proyecto

Es un proyecto CRUD de un listado de tareas en el que el ```Frontend``` y el ```Backend``` están totalmente separados en Blazor
y una api de .net framework.

## Descripcion del Frontend

Es un frontend simple con lo implementado por defecto de Blazor.

_En esta página se pueden ver todas las tareas_
<img src="https://i.ibb.co/c3cC4NP/index.png" alt="index" border="0">

_En esta página se puede crear una tarea_
<img src="https://i.ibb.co/mJ1CyJ7/formulario-Crear.png" alt="formulario-Crear" border="0">

_También le he añadido una opción para cuando borres las tareas salte el siguiente aviso_
<img src="https://i.ibb.co/y6s156G/eliminar.png" alt="eliminar" border="0">

Y por último, la opción de editar. Es la misma url de crear una tarea pero añadiendo en la url el id de la tarea(se hace 
automáticamente cuando le das al botón de editar). Al hacerlo con el identificador el titulo y la descripción se rellenan 
con la información.

## Descripción de la api

Como es un CRUD, la api tiene las funcionalidades de crear, devolver, editar y borrar la información de la base de datos.

<img src="https://i.ibb.co/Mfk5nnV/api.png" alt="api" border="0">

## Descripción de la base de datos

La base de datos es sencilla. Solo cuenta con una tabla en la que guarda el nombre y el titulo de la tarea.

<img src="https://i.ibb.co/K99qz4t/base-De-Datos.png" alt="base-De-Datos" border="0">
