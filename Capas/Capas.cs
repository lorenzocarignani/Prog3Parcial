//Arquitecturas por capas
//Una capa es un conjunto de “cosas” que tienen cierta responsabilidad.
//Primera regla
//Cada capa debe tener una responsabilidad única. Es decir que las capas deben estar
//perfectamente delimitadas de que se ocupa cada una de ellas,
//Segunda regla
//Las capas deben respetar una estructura jerárquica estricta. Quiere decir que cada capa
//puede comunicarse sólo con la que está debajo suyo, pero NO al revés.
//Ventajas
//Entre sus ventajas se encuentran las siguientes:
//- Es fácil testear cada capa por separado debido a la separación clara de
//responsabilidades que existe entre ellas.
//Desventajas
//- Si se implementaron demasiadas capas el rendimiento de la aplicación puede verse
//afectado
//-Ciertas operaciones al ser modificadas pueden afectar a todas las capas, haciendo
//visible que no existe un 100% de desacople entre estas.
//Presentación
//Atiende los eventos del cliente y representa los datos para el mismo. Teniendo en cuenta
//que el cliente puede ser un humano u otro sistema, esta capa será encargada en caso del
//humano
//Lógica de negocio
//En esta capa se encuentra todo lo que refiere a las reglas que se encuentran en el negocio,
//o sea los requerimientos funcionales de nuestro sistema.
//Acceso a datos
//Mediante esta capa podremos obtener o guardar los datos que utilizará nuestra aplicación.
//Beneficio
//Si logramos realizar esta separación de responsabilidades podemos notar como a una capa
//no le interesa cómo está implementada la otra. Así yo puedo reemplazar las
//implementaciones de las capas, pero esto no afectaría a las demás.
//Un HTTP request se compone de:
//- Método: GET, POST, PUT, etc. Indica que tipo de request es.
//- Path: la URL que se solicita, donde se encuentra el resource.
//- Protocolo: contiene HTTP y su versión, actualmente 1.1.
//-Headers. Son esquemas de key: value que contienen información sobre el HTTP
//request y el navegador. Aquí también se encuentran los datos de las cookies. La
//mayoría de los headers son opcionales.
//- Body. Si se envía información al servidor a través de POST o PUT, ésta va en el
//body.
//HTTP Response Structure from Web Server
//Una vez que el navegador envía el HTTP request, el servidor responde con un HTTP
//response, compuesto por:
//- Protocolo.Contiene HTTP y su versión, actualmente 1.1.
//- Status code. El código de respuesta, por ejemplo: 200 OK, que significa que el GET
//request ha sido satisfactorio y el servidor devolverá los contenidos del documento
//solicitado. Otro ejemplo es 404 Not Found, el servidor no ha encontrado el resource
//solicitado.
//- Headers. Contienen información sobre el software del servidor, cuando se modificó
//por última vez el resource solicitado, el mime type, etc. De nuevo la mayoría son
//opcionales.
//- Body. Si el servidor devuelve información que no sean headers ésta va en el body.