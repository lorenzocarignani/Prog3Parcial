//Ruta común al crear una API con todas sus carpetas: Al crear una API en ASP.NET Core, una estructura de carpetas común puede ser la siguiente:

//Controllers: Carpeta que contiene los controladores de la API.
//Models: Carpeta que contiene las clases de modelo utilizadas por la API.
//Services: Carpeta que contiene los servicios o lógica de negocio utilizados por los controladores.
//Data: Carpeta que contiene clases relacionadas con el acceso a datos, como entidades de base de datos, contextos de base de datos, etc.
//DTOs (Data Transfer Objects): Carpeta que contiene las clases utilizadas para transferir datos entre la API y los clientes.
//Extensions: Carpeta que contiene clases de extensión para agregar funcionalidad adicional.
//Helpers: Carpeta que contiene clases de ayuda o utilidades.
//Startup.cs: Archivo de configuración donde se configuran los servicios y la configuración de la aplicación.
//Controladores y verbos HTTP: Los controladores son componentes clave en ASP.NET para procesar solicitudes y generar respuestas.
//    Los verbos HTTP (GET, POST, DELETE, etc.) indican la operación que se debe realizar en un recurso específico.
//    Por ejemplo, GET se utiliza para obtener datos, POST para enviar datos y crear un recurso, DELETE para eliminar un recurso, etc.

//Inyección de dependencias: Es un patrón de diseño utilizado para resolver las dependencias entre los componentes de una aplicación.
//    En .NET, puedes usar el mecanismo de inyección de dependencias para proporcionar instancias de clases (a menudo implementadas mediante interfaces) a otras clases que las necesitan.
//    El uso de la inyección de dependencias facilita la creación de aplicaciones más flexibles y mantenibles.

//AddScoped: En el contexto de la inyección de dependencias en ASP.NET Core, AddScoped es un método que se utiliza para registrar una dependencia en el contenedor de servicios.
//    Cuando se resuelve esa dependencia, se crea una nueva instancia por solicitud HTTP y se reutiliza en el ámbito de esa solicitud.
//    Esto significa que todas las clases dentro del mismo ámbito (por ejemplo, una solicitud HTTP) obtendrán la misma instancia de esa dependencia.