# PRACTICA-GRUPAL

PROYECTO GRUPAL - GRUPO 5 - HADA

COMPONENTES DEL GRUPO:

- Rocío García Robles
- Francisco García Martinez
- Jose Clavel Pérez-Seoane
- Alejandro García Paterna
- Daniela Pedroche van Deurzen (Coordinadora) 

1. DESCRIPCIÓN

Wabi-Sabi es una empresa local ubicada en Alicante dedicada a la preparación y reparto de platos preparados basados en la dieta mediterránea y envasados al vacío. Esta empresa sabe que nuestro ritmo de vida muchas veces no nos permite dedicar mucho tiempo a hacer comidas caseras y eso hace que acabemos comiendo mal y a deshoras. Por eso, Wabi-Sabi ofrece tanto menús semanales como platos individuales a precios razonables, preparados con ingredientes naturales y de temporada para que comer de manera saludable esté al alcance de todos. Actualmente su radio de alcance es provincial, haciendo envíos gratuitos en la ciudad y exigiendo un pedido mínimo de 25 y 35 euros para pueblos adyacentes y Elche respectivamente. Está recibiendo muy buena acogida, recibiendo aproximadamente 100 pedidos diarios. Estos pedidos pueden ser tramitados a través del teléfono o acudiendo a la tienda física pero debido a la situación de incertidumbre provocada por el coronavirus, Wabi-Sabi quiere ampliar su alcance y facilitar la tarea de tramitar los pedidos a sus clientes integrándose en el sector online. El objetivo es crear una aplicacóin web que permita esto.


2. PARTE PÚBLICA

La vista de usuario PÚBLICA se realizará en Web Forms y estará encargada de los siguientes aspectos: 

- El usuario accederá a una página principal donde se podrá ver una descripción de lo que es la empresa Wabi-Sabi y un menú al que poder acceder para ver los diferentes platos, menús, etc. 

- El usuario buscar los productos y acceder al detalle de los mismos clickeando sobre ellos. Si le gustara un producto en concreto, podrá añadirlo al carrito sin haber tenido que registrarse. 

- Por último, el cliente usuario registrarse para acceder a la parte privada. Si es un nuevo usuario, se mostrará un formulario de registro con los datos personales, login y password. 


3. LISTADO EN PÚBLICA

- EN producto
- EN menú
- EN carrito
- EN oferta
- EN alérgenos
- EN orden

4. PARTE PRIVADA

Registrándose, el usuario podrá realizar las siguientes acciones. 

- El cliente tendrá acceso a ofertas especiales de usuarios socios. 

- El cliente podrá tramitar su pedido, comprando lo que haya en el carrito. 


5. LISTADO EN PRIVADA

- EN pedido
- EN usuario

6. POSIBLES MEJORAS

Como posibles mejoras, la empresa contempla las siguientes:

- Modo noche en la interfaz.

- Añadir una suscripción semanal en la que el cliente pague una cantidad fija de dinero y cada Lunes, le llegue una caja con todos los platos para la semana. 

- Una sección de reseñas en las que el cliente pueda puntuar los platos. Estas reserñas se harán públicas para el resto de usuarios. 

7. FUNCIONALIDAD E IMPLEMENTACIÓN DE CLASES

    - Oferta: Las ofertas se visualizarán de 3 maneras:


           1. Un usuario invitado que no ha logeado verá las ofertas que están disponibles para todos los clientes que quieran aproximarse a nuestra empresa, las cuales serán menos en cantidad y en calidad respecto a los usuarios registrados los cuales obtendrán un mayor número de ofertas incluso ofertas personalizadas en un futuro. También se le invitará a registrarse para poder acceder a las ofertas de tipo 2. Esto le redirigirá a la página de registro.
           
           2. El usuario registrado verá las ofertas tanto para clientes sin registrar como para usuarios registrados y las suyas propias que haya generado la empresa para cierto sector de clientes (Funcionalidad por implementar) 
           
           3. El superusuario (Trabajador de WabiSabi o subcontratado encargado del mantenimiento de la base de datos Oferta que mediante un login especial (usuario: 50386822D, contraseña: root) podrá acceder a la gestión de la base de datos pudiendo así añadir ofertas, quitándolas, modificarlas o leerlas. 

    - Usuario: Manejamos 2 tipos de usuario: 
    
           1. Usuario no registrado: conocido también como invitado tendrá una funcionalidad limitada y siempre podrá registrarse pulsando el botón que aparece arriba a la derecha (Login/Register)
           
           3. Usuario registrado: Podrá obtener todas las ventajas de la página.
           
           NOTA: El formulario de registro es totalmente arcaico, sin ningún tipo de control de contraseñas, nombres etc. Tampoco se manejan excepciones, es una versión realmente temprana de lo que será o sería el funcionamiento final y el manejo de usuarios. Se ha dejado en esta fase tan temprana por decisión del desarrollador para centrarse en otras tareas de la página más importantes a nivel estructural, en el caso de publicar esta página web algún día el manejo de usuarios se realizaría de forma mucho más segura y profesional.
           
           4. Superusuario: Acceso mediante el NIF: 50386822D Contraseña: root Tendrá la funcionalidad de crear, borrar y actualizar para que un cliente habitual no pueda acceder a estas herramientas. Se ha implementado en las ofertas, el resto de secciones de la página se implementarán más adelante previo a la publicación de esta.
           
     - Diseño de la interfaz: La interfaz presenta un aspecto homogéneo en todas las páginas. Para la implemantazion de esta hemos empleado controles ASP.NET además de las hojas de estilo CSS. Para trabajar con estas y obtener el resultado final hemos navegado por multitud de foros, de los cuales hemos obtenido plantillas para la realizacion de la pagina inicial y su herencia a las demás. Finalmente mencionar que no se han utulizado ni AJAX, ni Silverlight.

8. CAMBIOS CON RESPECTO DEL PROYECTO ORIGINAL

En cuanto a los cambios, en un principio, nuestra idea en cuanto a mejoras era proponer una internacionalización (traducción) y un sistema de rastreo del pedido. Finalmente, decidimos que queríamos implementar reseñas y suscripciones en su lugar, lo cual supusieron 2 EN extra que llevaron más horas de trabajo. 

Además, nuestra idea era implementar las clases alérgenos y orden, pero conforme avanzó la asignatura, vimos que eran dos clases innecesarias para la interfaz en sí con lo cual el trabajo que había elaborado Francisco implementando esas clases lo mantuvimos pero en lugar de añadirlas en la interfaz, para la última entrega, el se encargó de crear la Master Site y del diseño de la porpia interfaz, lo cual nos fue de gran ayuda. 

8. TAREAS HECHAS POR CADA MIEMBRO DEL EQUIPO


| ALUMNO        | TAREAS IMPLEMENTADAS |
| ------------- | ------------- |
| Daniela Blanca Pedroche van Deurzen  | ENProducto, CADProducto, Producto.aspx, ENReseña, CADReseña, Reseña.aspx  |
| Rocío García Robles  | ENSuscripcion, CADSuscripcion, Suscripcion.aspx, ENMenu, CADMenu, Menu.aspx  |
| Francisco García Martínez  | ENOrden, CADOrden, ENAlergenos, CADAlergenos, SiteMaster y diseño de la interfaz |
| Alejandro García Paterna  | ENPedido, CADPedido, ENCarrito, CADCarrito, Carrito.aspx, Pedido.aspx |
| Jose Clavel Pérez-Seoane | ENUsuario, CADUsuario, ENOferta, CADOferta, Oferta.aspx, OfertaInvitado.aspx, OfertaROOT.aspx |


9. DIFICULTADES ENCONTRADAS

Como dificultades encontradas destacamos varias, en concreto las siguientes:

- La complejidad para trabajar con visual studio si no dispones de un ordneador con sistema operativo Windows, ya que trabajar con la máquina virtual, ha supuesto muchas horas extra de tiempo debido a la lenitud del procesamiento. 

- La carga de trabajo de otras asignaturas sumada con la de esta en plenas semanas previas a exámenes. 

- La falta de organización por nuestra parte, sobretodo durante las primeras entregas. 

- Las dificultades que nos ha supuesto el trabajar con GitHub como herramienta de control de versiones, ya que era una herramienta nueva para nosotros y la resolución de conflictos a la hora de hacer merges nos ha llevado algún que otro quebradero de cabeza. LLegamos a crear un nuevo repositorio desde cero para poder hacer la última entrega, por ello en este, solo hay 1 milestone. 

10. CONCLUSIÓN

Como conclusiones, sacamos varias y muy positivas. En primer lugar, lo mucho que hemos aprendido llevando a cabo este proyecto, trabajando con un lenguaje nuevo para nosotros (C#). En segundo lugar, hemos aprendido cómo trabajar con GitHub, una herramienta muy útil para trabajar de manera colaborativa y que seguro que nos va a servir de mucho en un futuro. Por último, hemos aprendido a organizarnos como equipo, algo que nos costó más con la primera entrega pero que, poco a poco, hemos mejorado notablemente, con la ayuda del reparto de tareas del tablón del proyecto. 

En definitiva, este proyecto, aunque complicado, ha hecho que aprendamos y mejoremos como profesionales todos los miembros del equipo. 

11. LINK A LA PRESENTACIÓN. 

https://drive.google.com/file/d/1k2zSEbxHXYcS8Zkf5l3QgOR6BFrQ-E3K/view


