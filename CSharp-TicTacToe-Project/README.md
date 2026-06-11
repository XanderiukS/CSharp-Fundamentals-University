# Juego de Totito (Tres en Raya) en C#

Este repositorio contiene una aplicación de escritorio en **C#** (Windows Forms) desarrollada como práctica para implementar la lógica de un juego interactivo de dos jugadores y el manejo de interfaces gráficas.

## 🚀 Tecnologías Utilizadas
* C#
* .NET (Windows Forms)
* Visual Studio

## 📋 Descripción del Proyecto
El programa consiste en una interfaz visual que simula el clásico juego de Totito. Permite el registro de los nombres de dos participantes, asigna de forma aleatoria quién inicia la partida y automatiza el flujo del juego hasta declarar un ganador o un empate.

El código fuente destaca por la implementación de los siguientes conceptos:
* **Manejo de controles visuales:** Modificación dinámica de las propiedades de elementos como `Button`, `Label` y `Panel` (ej. cambiar texto, ocultar paneles y deshabilitar botones en tiempo de ejecución).
* **Lógica de validación (Métodos booleanos):** Creación de funciones como `ganador()` y `TableroLleno()` que evalúan constantemente el estado de los botones para detectar las 8 combinaciones posibles de victoria (filas, columnas, diagonales) o un empate.
* **Uso de la clase Random:** Generación de números aleatorios mediante `Random.Next()` para decidir equitativamente qué jugador toma el primer turno y qué figura ("X" u "O") se le asigna.

## 💻 Cómo ejecutar el proyecto
1. Clona este repositorio en tu computadora.
2. Abre la solución (`.sln`) en **Visual Studio**.
3. Presiona el botón de **Iniciar** (o la tecla `F5`) para compilar y probar la aplicación.
---
*Proyecto de práctica desarrollado para el curso de Programación 3.*
