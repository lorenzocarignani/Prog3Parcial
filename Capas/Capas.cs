//Arquitecturas por capas
//Una capa es un conjunto de �cosas� que tienen cierta responsabilidad.
//Primera regla
//Cada capa debe tener una responsabilidad �nica. Es decir que las capas deben estar
//perfectamente delimitadas de que se ocupa cada una de ellas,
//Segunda regla
//Las capas deben respetar una estructura jer�rquica estricta. Quiere decir que cada capa
//puede comunicarse s�lo con la que est� debajo suyo, pero NO al rev�s.
//Ventajas
//Entre sus ventajas se encuentran las siguientes:
//- Es f�cil testear cada capa por separado debido a la separaci�n clara de
//responsabilidades que existe entre ellas.
//Desventajas
//- Si se implementaron demasiadas capas el rendimiento de la aplicaci�n puede verse
//afectado
//-Ciertas operaciones al ser modificadas pueden afectar a todas las capas, haciendo
//visible que no existe un 100% de desacople entre estas.
//Presentaci�n
//Atiende los eventos del cliente y representa los datos para el mismo. Teniendo en cuenta
//que el cliente puede ser un humano u otro sistema, esta capa ser� encargada en caso del
//humano
//L�gica de negocio
//En esta capa se encuentra todo lo que refiere a las reglas que se encuentran en el negocio,
//o sea los requerimientos funcionales de nuestro sistema.
//Acceso a datos
//Mediante esta capa podremos obtener o guardar los datos que utilizar� nuestra aplicaci�n.
//Beneficio
//Si logramos realizar esta separaci�n de responsabilidades podemos notar como a una capa
//no le interesa c�mo est� implementada la otra. As� yo puedo reemplazar las
//implementaciones de las capas, pero esto no afectar�a a las dem�s.
//Un HTTP request se compone de:
//- M�todo: GET, POST, PUT, etc. Indica que tipo de request es.
//- Path: la URL que se solicita, donde se encuentra el resource.
//- Protocolo: contiene HTTP y su versi�n, actualmente 1.1.
//-Headers. Son esquemas de key: value que contienen informaci�n sobre el HTTP
//request y el navegador. Aqu� tambi�n se encuentran los datos de las cookies. La
//mayor�a de los headers son opcionales.
//- Body. Si se env�a informaci�n al servidor a trav�s de POST o PUT, �sta va en el
//body.
//HTTP Response Structure from Web Server
//Una vez que el navegador env�a el HTTP request, el servidor responde con un HTTP
//response, compuesto por:
//- Protocolo.Contiene HTTP y su versi�n, actualmente 1.1.
//- Status code. El c�digo de respuesta, por ejemplo: 200 OK, que significa que el GET
//request ha sido satisfactorio y el servidor devolver� los contenidos del documento
//solicitado. Otro ejemplo es 404 Not Found, el servidor no ha encontrado el resource
//solicitado.
//- Headers. Contienen informaci�n sobre el software del servidor, cuando se modific�
//por �ltima vez el resource solicitado, el mime type, etc. De nuevo la mayor�a son
//opcionales.
//- Body. Si el servidor devuelve informaci�n que no sean headers �sta va en el body.