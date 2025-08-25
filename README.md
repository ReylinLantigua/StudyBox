

# StudyBox

**StudyBox** es un proyecto académico desarrollado como parte de la asignatura **Programación III** en el **Instituto Tecnológico de Las Américas (ITLA)**.  
La aplicación fue construida con **C# y Blazor (ASP.NET Core)** y reúne diversas utilidades interactivas orientadas al aprendizaje y práctica de programación.

---

## Objetivo del Proyecto

El propósito de **StudyBox** es integrar en una sola aplicación diferentes ejercicios de lógica y programación, permitiendo a los estudiantes poner en práctica conceptos vistos en clase, como:

- Manejo de componentes en Blazor.
- Enlaces de datos y formularios.
- Estructuras condicionales y ciclos.
- Creación de modelos de datos.
- Buenas prácticas en desarrollo de aplicaciones web.

---

## Funcionalidades

- **Acerca de…** → Información básica del estudiante.  
- **Analizar Frase** → Procesa texto ingresado.  
- **Random User** → Genera usuarios aleatorios para pruebas.  
- **Medidor de Triángulos** → Calcula propiedades de triángulos.  
- **Convertir Número en Letras** → Convierte valores numéricos a texto.  
- **Imágenes en URL** → Visualiza imágenes desde enlaces.  
- **Calcular Calificaciones** → Calcula notas de estudiantes.  
- **Promedio de Números** → Calcula promedios de conjuntos numéricos.  
- **Número a Romano** → Convierte números arábigos a romanos.  
- **Construir Silla** → Ejemplo interactivo de lógica y dibujo con caracteres.  

---

## 💻 Tecnologías Utilizadas

- **Lenguaje:** C#  
- **Framework:** ASP.NET Core 5.0 (Blazor Server)  
- **Frontend:** Razor Components + Bootstrap  
- **IDE:** Visual Studio 2019

---

## 📂 Estructura del proyecto

```

StudyBox/
│
├─ StudyBox.sln
├─ StudyBox/              # Proyecto principal
│  ├─ Pages/              # Páginas Blazor (componentes principales)
│  ├─ Shared/             # Layout y NavMenu
│  ├─ Models/             # Modelos de datos
│  ├─ Data/               # Datos
│  ├─ wwwroot/            # Archivos estáticos (CSS, JS, imágenes)
│  └─ Program.cs
└─ README.md

````

---

## Ejecución

1. Clonar el repositorio:

```bash
git clone https://github.com/ReylinLantigua/StudyBox.git
````

2. Abrir la solución en **Visual Studio 2019**.
3. Restaurar los paquetes NuGet:

```bash
dotnet restore
```

4. Ejecutar con **F5** o:

```bash
dotnet run
```

5. Abrir en el navegador: `https://localhost:5001`

---

## Licencia

Proyecto académico – **Instituto Tecnológico de las Américas (ITLA)** – 2024.
Uso libre con fines educativos.

