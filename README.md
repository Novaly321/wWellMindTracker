# 🧠 **WellMind Tracker**

> Aplicación educativa enfocada en el bienestar emocional de los usuarios, desarrollada con **C# y Windows Forms**, implementando el **patrón Factory** y simulando un modelo de base de datos.

---

## 🌟 **Descripción del Proyecto**

**WellMind Tracker** es una aplicación que permite a los usuarios **registrar sus emociones diarias**, recibir mensajes motivadores y visualizar su progreso emocional.  
El sistema aplica el **patrón de diseño Factory** para manejar los diferentes tipos de emociones y utiliza una interfaz gráfica simple.

---

## 🎯 **Objetivo General**

Fomentar la reflexión personal y el bienestar emocional mediante un pequeño registro diario de emociones positivas, neutras o negativas, mostrando mensajes personalizados y un nivel de bienestar acumulado.

---

## 👥 **Integrantes del Proyecto**

- **Jorge Cabrera**  
- **Juan Esteban Guzmán**

---

## 💡 **Características Principales**

- Interfaz amigable con tres formularios conectados entre sí.  
- Implementación del **patrón Factory** para crear objetos de tipo emoción.  
- Validaciones básicas de usuario y registro.  
- Simulación del modelo de base de datos con listas.  
- Código modular para facilitar futuras ampliaciones.

---

## 🖥️ **Interfaz de Usuario**

### 🏠 `frmInicio`
Formulario de bienvenida.  
El usuario ingresa su nombre y accede al registro de emociones.

**Controles:**
- `Label` → título y texto de bienvenida  
- `TextBox` → ingreso del nombre  
- `Button` → continuar  

---

### 😊 `frmRegistroEmocion`
Formulario principal del juego.  
Permite seleccionar cómo se siente el usuario y guardar el registro.

**Controles:**
- `Label` → saludo personalizado  
- `ComboBox` → opciones: *Positiva*, *Neutra*, *Negativa*  
- `Button` → registrar emoción  
- `Button` → ver progreso  
- `Label` → muestra el mensaje generado por la emoción  

---

### 📊 `frmProgreso`
Muestra el historial de emociones y un nivel de bienestar acumulado.

**Controles:**
- `Label` → título  
- `ListBox` → historial de emociones  
- `Label` → nivel de bienestar  
- `Button` → volver al registro  

---

🧠 Reglas de Negocio

- El usuario debe registrarse con un nombre.
- Solo puede registrar una emoción por día.
- Las emociones se clasifican como positiva, neutra o negativa.
- Cada registro aumenta o disminuye el nivel de bienestar.
- Si la emoción es negativa, se muestra un mensaje motivador.
- Si la emoción es positiva, se muestra un mensaje de felicitación.
- El historial guarda todas las emociones registradas.
- Los datos se almacenan temporalmente en listas.
- El usuario puede ver su progreso general.
- El sistema muestra el nivel de bienestar actual.

---

▶️ Instrucciones para Ejecutar

- Abrir el proyecto WellMindTracker en Visual Studio.
- Asegurar que el formulario de inicio sea frmInicio.
- Presionar Ctrl + F5 para ejecutar.
- Ingresar el nombre → seleccionar emoción → registrar → ver progreso.

📦 Tecnologías Utilizadas

- Lenguaje: C# 
- Interfaz: Windows Forms
- Patrón de diseño: Factory
