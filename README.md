# Concesionario

Aplicación web desarrollada con ASP.NET Core MVC, Entity Framework Core, SQL Server e Identity para gestionar el inventario de vehículos de un concesionario, aplicando autenticación, autorización por roles y una relación uno a muchos entre las entidades del sistema. 【1-f60ab7】

---

## Tema asignado

**Problema:** Un concesionario necesita administrar su inventario de vehículos mediante una aplicación web segura con control de acceso y validación de datos. 【1-f60ab7】

### Entidad principal
**Marca**
- Nombre
- PaisOrigen (opcional)

### Entidad dependiente
**Vehiculo**
- Modelo
- Anio
- Precio
- MarcaId

### Roles del sistema
- Vendedor (rol de gestión)
- Comprador (rol de consulta)

---

## Integrantes y turnos

| Turno | Integrante | Fase asignada |
|---------|---------|---------|
| 1 | Nathaly Cuasapaz | Fase 1 · Proyecto y entidad dependiente |
| 2 | Pablo Loya | Fase 2 · Validaciones |
| 3 | Marlon Loya | Fase 3 · Relación uno a muchos |
| 4 | Henry Borja | Fase 4 · Identity |
| 5 | Henry Borja | Fase 5 · Roles y usuarios |

---

## Usuarios GitHub del equipo

| Integrante | Usuario GitHub |
|------------|------------|
| Nathaly Cuasapaz | NathoC31 |
| Pablo Loya | xobroccoli |
| Marlon Loya | marlonsantiago212002-cmyk |
| Henry Borja | HenryBorja99 |

---

## Aporte de cada integrante

### Nathaly Cuasapaz (NathoC31)
- Creación del proyecto ASP.NET Core MVC.
- Configuración inicial del repositorio GitHub.
- Creación de la entidad Vehiculo.
- CRUD de Vehiculo mediante scaffolding.
- Migración InitialCreate.
- Elaboración inicial del README.

### Pablo Loya (xobroccoli)
- Implementación de validaciones mediante DataAnnotations.
- Configuración de atributos Required, StringLength, Range y Display.
- Mejora de la legibilidad del modelo Vehiculo.
- Actualización de documentación del proyecto.

### Marlon Loya (marlonsantiago212002-cmyk)
- Creación de la entidad Marca.
- CRUD de Marca.
- Implementación de la relación uno a muchos Marca-Vehiculo.
- Corrección de las vistas eliminando propiedades de navegación innecesarias.
- Actualización de la documentación correspondiente a la Fase 3.

### Henry Borja (HenryBorja99)
- Implementación de ASP.NET Core Identity.
- Configuración de autenticación de usuarios.
- Integración de _LoginPartial.
- Configuración de roles.
- Creación de usuarios de prueba.
- Restricción de acceso mediante autorización por roles.
- Actualización del README.

---

## Funcionalidades implementadas

- CRUD completo de Marcas.
- CRUD completo de Vehiculos.
- Relación uno a muchos entre Marca y Vehiculo.
- Validaciones con DataAnnotations.
- Base de datos SQL Server mediante Entity Framework Core.
- Registro de usuarios.
- Inicio de sesión.
- Cierre de sesión.
- Gestión de roles.
- Restricción de acceso según rol.
- Visualización pública de información.

---

## Roles del sistema

### Vendedor
Puede:
- Crear marcas.
- Editar marcas.
- Eliminar marcas.
- Crear vehículos.
- Editar vehículos.
- Eliminar vehículos.

### Comprador
Puede:
- Consultar marcas.
- Consultar vehículos.
- Acceder a las vistas públicas del sistema.

---

## Usuarios de prueba

### Usuario Vendedor

**Correo**

```text
vendedor@hbtechworks.com
```

**Contraseña**

```text
Vendedor123!
```

**Rol**

```text
Vendedor
```

---

### Usuario Comprador

**Correo**

```text
comprador@hbtechworks.com
```

**Contraseña**

```text
Comprador123!
```

**Rol**

```text
Comprador
```

---

## Migraciones

Las migraciones generadas durante el desarrollo son:

```text
InitialCreate
ValidacionesVehiculo
AgregarRelacionMarcaVehiculo
AgregarIdentity
```

---

## Reglas de trabajo colaborativo

- Extraer cambios del repositorio antes de comenzar a trabajar.
- Ejecutar Update-Database cuando existan nuevas migraciones.
- Crear migraciones por turnos.
- No subir carpetas bin ni obj.
- Mantener la aplicación compilando correctamente.
- Realizar commits descriptivos.
- Registrar las contribuciones de cada integrante.

### Ejemplos de mensajes de commit

```text
Agregar entidad Vehiculo con CRUD y migración InitialCreate
Agregar validaciones al modelo Vehiculo
Implementar relación Marca-Vehiculo
Implementar autenticación y gestión de usuarios con Identity
Crear roles Vendedor y Comprador con usuarios de prueba
```

---

## Pasos para ejecutar el proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/NathoC31/Concesionario.git
```

### 2. Abrir la solución

Abrir:

```text
Concesionario.sln
```

### 3. Configurar la cadena de conexión

Editar el archivo:

```text
appsettings.json
```

Ejemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=ConcesionarioDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4. Aplicar migraciones

Ejecutar en la Consola del Administrador de Paquetes:

```powershell
Update-Database
```

### 5. Ejecutar la aplicación

```text
F5
```

o

```text
Ctrl + F5
```

---

## Tecnologías utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- Bootstrap
- Git
- GitHub

---

## Repositorio del proyecto

```text
https://github.com/NathoC31/Concesionario
```

Historial de commits:

```text
https://github.com/NathoC31/Concesionario/commits/master/
```

---


## Evidencias requeridas para el informe PDF

- Captura de Insights > Contributors de GitHub.
- Diagrama entidad-relación.
- Evidencias de las tablas Marca y Vehiculo en SQL Server.
- Evidencias de AspNetUsers, AspNetRoles y AspNetUserRoles.
- Evidencias de autenticación y autorización por roles.
- Explicación del componente autónomo implementado.

---

## Estado actual del proyecto

✅ CRUD de Vehiculo implementado  
✅ Validaciones implementadas  
✅ CRUD de Marca implementado  
✅ Relación uno a muchos implementada  
✅ Identity configurado  
✅ Roles configurados  
✅ Usuarios de prueba configurados  
✅ Control de acceso por roles implementado  