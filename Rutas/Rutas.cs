//Ruta com�n al crear una API con todas sus carpetas: Al crear una API en ASP.NET Core, una estructura de carpetas com�n puede ser la siguiente:

//Controllers: Carpeta que contiene los controladores de la API.
//Models: Carpeta que contiene las clases de modelo utilizadas por la API.
//Services: Carpeta que contiene los servicios o l�gica de negocio utilizados por los controladores.
//Data: Carpeta que contiene clases relacionadas con el acceso a datos, como entidades de base de datos, contextos de base de datos, etc.
//DTOs (Data Transfer Objects): Carpeta que contiene las clases utilizadas para transferir datos entre la API y los clientes.
//Extensions: Carpeta que contiene clases de extensi�n para agregar funcionalidad adicional.
//Helpers: Carpeta que contiene clases de ayuda o utilidades.
//Startup.cs: Archivo de configuraci�n donde se configuran los servicios y la configuraci�n de la aplicaci�n.
//Controladores y verbos HTTP: Los controladores son componentes clave en ASP.NET para procesar solicitudes y generar respuestas.
//    Los verbos HTTP (GET, POST, DELETE, etc.) indican la operaci�n que se debe realizar en un recurso espec�fico.
//    Por ejemplo, GET se utiliza para obtener datos, POST para enviar datos y crear un recurso, DELETE para eliminar un recurso, etc.

//Inyecci�n de dependencias: Es un patr�n de dise�o utilizado para resolver las dependencias entre los componentes de una aplicaci�n.
//    En .NET, puedes usar el mecanismo de inyecci�n de dependencias para proporcionar instancias de clases (a menudo implementadas mediante interfaces) a otras clases que las necesitan.
//    El uso de la inyecci�n de dependencias facilita la creaci�n de aplicaciones m�s flexibles y mantenibles.

//AddScoped: En el contexto de la inyecci�n de dependencias en ASP.NET Core, AddScoped es un m�todo que se utiliza para registrar una dependencia en el contenedor de servicios.
//    Cuando se resuelve esa dependencia, se crea una nueva instancia por solicitud HTTP y se reutiliza en el �mbito de esa solicitud.
//    Esto significa que todas las clases dentro del mismo �mbito (por ejemplo, una solicitud HTTP) obtendr�n la misma instancia de esa dependencia.