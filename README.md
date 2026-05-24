# RanchMaster - Sistema de Gestión Ganadera

Aplicación web para la gestión integral de fincas y operaciones ganaderas, desarrollada con **ASP.NET Core**, **Blazor** y **Entity Framework Core** siguiendo una arquitectura en capas limpia y escalable.

---

# Descripción

RanchMaster permite administrar de manera eficiente diferentes procesos relacionados con la producción ganadera, facilitando el control de:

- Animales
- Alimentación
- Salud veterinaria
- Reproducción
- Compras y ventas
- Ubicaciones
- Clientes y compradores
- Registros productivos

El sistema fue diseñado bajo principios de separación de responsabilidades y arquitectura modular, permitiendo un mantenimiento más sencillo y una mejor escalabilidad.

---

# Arquitectura del Proyecto

El proyecto sigue una arquitectura multicapa (Layered Architecture).

## Capa de Presentación (`Presentation`)

Aplicación web desarrollada con **ASP.NET Core Blazor**.

### Responsabilidades:
- Interfaz de usuario
- Componentes Razor
- Navegación
- Formularios y vistas
- Interacción con el usuario

### Características:
- Renderizado interactivo con Blazor Server
- Componentes organizados por módulos
- Diseño modular y reutilizable

---

## Capa de Lógica (`Logic`)

Contiene toda la lógica de negocio del sistema.

### Responsabilidades:
- Validaciones
- Reglas de negocio
- Procesamiento de datos
- Servicios por entidad

### Ejemplos:
- Gestión de animales
- Control de ventas
- Validaciones sanitarias
- Gestión reproductiva

---

## Capa de Modelos (`Model`)

Define las entidades principales del sistema.

### Responsabilidades:
- Clases de entidades
- Representación de tablas
- Modelos de dominio

### Características:
- Clases POCO
- Sin dependencias externas
- Compatibles con Entity Framework Core

---

## Capa de Datos (`Data`)

Encargada del acceso a datos mediante Entity Framework Core.

### Responsabilidades:
- Configuración de base de datos
- DbContext
- Relaciones entre entidades
- Migraciones

### Componentes principales:
- `RanchMasterContext`
- Configuraciones EF Core
- Mapeo de entidades

---

# Tecnologías Utilizadas

| Tecnología | Descripción |
|---|---|
| .NET 9 | Framework principal |
| ASP.NET Core | Desarrollo backend |
| Blazor Server | Frontend interactivo |
| Entity Framework Core 9 | ORM y acceso a datos |
| SQL Server | Base de datos |
| C# 12 | Lenguaje de programación |
| Razor Components | Componentes UI |

---

# Estructura del Proyecto

```bash
RanchMasterWebApp/
│
├── Presentation/          # Interfaz de usuario (Blazor)
├── Logic/                 # Lógica de negocio
├── Model/                 # Entidades y modelos
├── Data/                  # Acceso a datos
│
├── RanchMasterWebApp.sln  # Solución principal
└── .gitignore             # Archivos ignorados por Git