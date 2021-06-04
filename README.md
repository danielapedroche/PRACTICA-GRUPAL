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

La vista de cliente PÚBLICA se realizará en Web Forms y estará encargada de los siguientes aspectos: 

- El cliente accede a una página principal donde se muestran los diferentes platos elaborados de manera individual a modo de carta. El cliente podrá filtrar por alérgenos e intoleracias, orden (entratntes, platos principales y postres), platos más vendidos y platos en oferta. También podrá ver los menús semanales propuestos por la empresa. 

- El cliente también podrá hacer uso de un buscador de platos, para buscar aluno en concreto. 

- El cliente podrá seleccionar tanto los platos como los menús propuestos y acceder al detalle de los mismos clickeando sobre ellos. Si le gustara el plato o el menú, podrá añadirlo al carrito sin haber tenido que registrarse. 

- Por último, el cliente podrá registrarse para acceder a la parte privada. Si es un nuevo usuario, se mostrará un formulario de registro con los datos personales, login y password. 


3. LISTADO EN PÚBLICA

- EN producto
- EN menú
- EN carrito
- EN oferta
- EN alérgenos
- EN orden

4. PARTE PRIVADA

Registrándose, el usuario podrá realizar las siguientes acciones. 

- El cliente podrá tramitar su pedido, indicando la dirección, el email y el número de tarjeta de crédito. Cuando se haya tramitado, recibirá una confirmación por parte de la empresa. 

- El cliente podrá consultar, modificar o cancelar su pedido. 

- El cliente podrá hacer un seguimiento del pedido. 

5. LISTADO EN PRIVADA

- EN pedido
- EN usuario

6. POSIBLES MEJORAS

Como posibles mejoras, la empresa contempla las siguientes:

- Modo noche en la interfaz.

- Añadir una suscripción semanal en la que el cliente pague una cantidad fija de dinero y cada Lunes, le llegue una caja con todos los platos para la semana. 

- Una sección de reseñas en las que el cliente pueda puntuar los platos. Estas reserñas se harán públicas para el resto de usuarios. 

7. CAMBIOS CON RESPECTO DEL PROYECTO ORIGINAL

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


