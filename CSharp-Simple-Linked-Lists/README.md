# Listas Simples Enlazadas en C#

Este repositorio contiene una aplicación de consola desarrollada en **C#**. Su propósito principal es demostrar la implementación manual de una estructura de datos de "Lista Simple Enlazada" (Singly Linked List), evidenciando el manejo de memoria y la manipulación de punteros sin depender de las listas preconstruidas del lenguaje.

## 🚀 Tecnologías Utilizadas
* C#
* .NET (Aplicación de Consola)
* Visual Studio

## 📋 Conceptos Aplicados
El proyecto está compuesto por clases interconectadas que dan solución a la creación y recorrido dinámico de la memoria a través de los siguientes puntos:

1. **Nodos y Punteros:** Creación de una clase `Nodo` que almacena un dato numérico y un puntero (`Siguiente`) hacia el próximo objeto en memoria.
2. **Control de Extremos:** Uso de punteros estructurales (`primero` y `ultimo`) para llevar el control del inicio y fin de la estructura de datos en la clase `Lista`.
3. **Inserción de Datos:** Lógica de evaluación condicional (`if/else`) para determinar si la lista está vacía o si se debe enlazar un nuevo nodo al final de la cadena existente.
4. **Recorrido Dinámico (Traversal):** Uso del ciclo `while` y nodos temporales (`actual`) para recorrer e imprimir la lista hasta encontrar el final de la cadena (`null`).
5. **Código Histórico:** El código conserva su estado original de aprendizaje, con comentarios detallados línea por línea que explican la lógica detrás de cada paso.

## 💻 Cómo ejecutar el proyecto
1. Clona este repositorio en tu entorno local.
2. Abre el archivo de la solución (`.sln`) utilizando **Visual Studio**.
3. Presiona el botón de **Iniciar** (o la tecla `F5`) para compilar y ejecutar la consola.
4. Ingresa los valores numéricos cuando la consola te lo solicite para ver cómo se enlazan dinámicamente.

---
*Proyecto de práctica desarrollado para el aprendizaje de Estructuras de Datos.*
