# Sistema de Inventario de Vehículos en C# y Windows Forms

Este repositorio contiene una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms**. Su propósito principal es demostrar la aplicación práctica de la Programación Orientada a Objetos (POO), el manejo de colecciones dinámicas en memoria y la interacción interactiva con controles de interfaz gráfica.

## 🚀 Tecnologías Utilizadas
* C#
* .NET (Windows Forms)
* Visual Studio

## 📋 Conceptos Aplicados
El proyecto está compuesto por una interfaz gráfica y clases interconectadas que dan solución al registro y visualización de datos mediante los siguientes puntos:

1. **Programación Orientada a Objetos (POO):** Diseño e implementación de la clase `vehiculo` para instanciar objetos con propiedades específicas (Placa, Chasis, Marca, Energía, Color y Descripción).
2. **Estructuras de Datos Dinámicas:** Uso de listas genéricas (`List<string>`) a través de la clase personalizada `lista` para poblar dinámicamente los menús desplegables (`ComboBox`).
3. **Manejo de Eventos (Event-Driven):** Captura de interacciones del usuario mediante botones de guardado y limpieza (`Click`), así como la actualización de información en tiempo real basada en selecciones del usuario (`SelectedIndexChanged`).
4. **Validación y Conversión de Tipos:** Manejo de datos de entrada mediante la conversión explícita de cadenas de texto a enteros (`Convert.ToInt32`) para los campos de placa y chasis.
5. **Gestión de Estados UI:** Lógica para limpiar, reiniciar y alternar el estado de los componentes visuales en la pantalla una vez que los datos han sido procesados.

## 💻 Cómo ejecutar el proyecto
1. Clona este repositorio en tu entorno local.
2. Abre el archivo de la solución (`.sln`) utilizando **Visual Studio**.
3. Presiona el botón de **Iniciar** (o la tecla `F5`) para compilar y ejecutar la interfaz gráfica.
4. Interactúa con el formulario para registrar hasta tres vehículos y visualiza su resumen en el panel lateral.

---
*Proyecto de práctica desarrollado para evaluar fundamentos de Programación Orientada a Objetos.*
