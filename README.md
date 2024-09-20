# Proyecto de Login con Bloqueo de Usuarios

**Descripción**

Este proyecto implementa un sistema de login que verifica usuarios y gestiona los intentos fallidos de acceso. Si un usuario introduce una contraseña incorrecta más de 3 veces, su cuenta se bloquea automáticamente. Un administrador tiene la capacidad de ver los usuarios bloqueados y desbloquearlos si es necesario.

El sistema está desarrollado utilizando C# .NET, ADO.NET en modo conectado y SQL Server, y sigue el modelo de capas para facilitar la escalabilidad y el mantenimiento.

**Características principales**

* Bloqueo de usuarios tras 3 intentos fallidos: Evita accesos no autorizados bloqueando la cuenta después de varios intentos fallidos.
* Desbloqueo de usuarios por administradores: Un administrador puede visualizar los usuarios bloqueados y desbloquearlos si es necesario.
* Modelo de capas: La estructura del código sigue el modelo de capas, mejorando la organización y la escalabilidad.

**Herramientas utilizadas**
* C# .NET
* ADO.NET (modo conectado)
* SQL Server
* Modelo de capas

¡Para mirar un poco más de la funcionalidad del proyecto poder verlo en [LinkedIn](https://www.linkedin.com/posts/gregory-sair-barreto-sosa_proyecto-de-login-con-bloqueo-de-usuarios-activity-7241979570403364864-GwZ_?utm_source=share&utm_medium=member_desktop)!

# Proyecto de Gestión de Productos, Categorías y Usuarios para Empresas con Login en C# .NET y SQL Server

**Descripción**

Este sistema completo permite a una empresa gestionar productos, categorías y cuentas de usuarios, todo bajo un entorno autenticado. Los usuarios autenticados pueden realizar operaciones de Altas, Bajas y Modificaciones (ABM) de productos y categorías, mientras que los administradores pueden gestionar las cuentas de usuarios, incluyendo dar de alta nuevas cuentas y desbloquear usuarios bloqueados.

El sistema está desarrollado utilizando C# .NET, ADO.NET en modo conectado y SQL Server. Además, utiliza el patrón de diseño Singleton para asegurar que ciertos formularios de administración sean únicos y no se creen múltiples instancias.

**Funcionalidades clave**
* Gestión de Productos y Categorías: Los usuarios pueden administrar productos y sus categorías.
* Gestión de Usuarios: Los administradores pueden dar de alta nuevas cuentas de usuarios y desbloquear usuarios bloqueados.
* Login con roles diferenciados: Los administradores tienen acceso a funcionalidades exclusivas, como la visualización de registros del sistema y la gestión de usuarios.
* Control de intentos fallidos: Las cuentas se bloquean tras 3 intentos fallidos de inicio de sesión.
* Patrón Singleton: Se implementa el patrón Singleton para los formularios de administración, garantizando que solo exista una instancia de cada uno.

**Herramientas utilizadas**
* C# .NET
* ADO.NET (modo conectado)
* SQL Server
* Modelo de capas
* Patrón Singleton para la gestión de formularios

¡Para mirar un poco más de la funcionalidad del proyecto poder verlo en [LinkedIn](https://www.linkedin.com/posts/gregory-sair-barreto-sosa_proyecto-de-gesti%C3%B3n-de-productos-categor%C3%ADas-activity-7242687617832546304-7tMD?utm_source=share&utm_medium=member_desktop)!
