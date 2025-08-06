\# Rick y Morty - Juego por Turnos



Este es un juego por turnos en Windows Forms inspirado en el universo de \*\*Rick y Morty\*\*, donde el jugador puede elegir entre Rick o Morty como personaje principal y luchar contra una serie de monstruos únicos.



\## 🧪 Características



\- Juego gráfico con imágenes, botones y etiquetas dinámicas.

\- Selección inicial de personaje (Rick o Morty).

\- Jugabilidad por turnos: atacar, curar, defender y usar ataque especial "Berserker".

\- Acompañante automático (paje) que asiste en el combate.

\- Monstruos con nombres, imágenes, vida y ataques únicos.

\- Barra de vida y colores dinámicos para jugador, paje y monstruo.

\- Mecánicas de defensa, daño y curación con variación aleatoria.

\- Finalización automática al derrotar a todos los enemigos o ser derrotado.



\## 🖼️ Interfaz



\- Fondos e imágenes personalizadas (`/images`)

\- Cambios visuales dinámicos según estado del personaje.

\- Efectos visuales como colores en HP, visibilidad de imágenes y estilo de botones.



\## 📁 Estructura de Archivos



📁 images/ → Contiene las imágenes de los personajes y monstruos

📁 monsters/ → Contiene el archivo monstruos.txt con los datos de los enemigos

📝 Form1.cs → Lógica principal del juego (este archivo)

📝 Player.cs → Clase para el jugador principal

📝 Second.cs → Clase para el paje o acompañante

📝 Monstruo.cs → Clase que define enemigos





\## 💡 Instrucciones



1\. Abre el proyecto en \*\*Visual Studio\*\*.

2\. Asegúrate de tener las carpetas `/images/` y `/monsters/` dentro del directorio raíz del proyecto.

3\. El archivo `monstruos.txt` debe contener enemigos con el siguiente formato por línea:



vida,nombre,ataqueMin,ataqueMax



Ejemplo:

100,Evil Morty,10,20

120,Rick Prime,15,25





4\. Ejecuta el programa y elige entre Rick o Morty para comenzar la aventura.



\## 🛠️ Requisitos



\- .NET Framework compatible con Windows Forms (por ejemplo, .NET Framework 4.7.2 o superior).

\- Visual Studio 2019 o 2022.



\## 🚀 Controles del Jugador



| Acción       | Descripción                                 |

|--------------|---------------------------------------------|

| \*\*Golpe\*\*    | Ataque normal contra el monstruo.           |

| \*\*Suero\*\*    | Cura al jugador y al paje (si no está noqueado). |

| \*\*Berserker\*\*| Ataque fuerte que hace más daño, pero te deja vulnerable. |

| \*\*Burla\*\*    | Defiende el siguiente turno, reduciendo el daño recibido. |



\## 🧠 Lógica del Juego



\- El jugador y el paje atacan por turnos.

\- El monstruo ataca aleatoriamente al jugador o al paje.

\- Si el paje cae, ya no ataca ni puede curarse.

\- Si el jugador cae, el juego termina.

\- Si todos los monstruos son derrotados, ¡ganas!



