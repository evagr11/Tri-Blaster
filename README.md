<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7C2D12%2C50%3AF97316%2C100%3AFED7AA&height=200&section=header&text=Tri-Blaster&fontSize=60&fontColor=fff&fontAlignY=38&desc=Un+shooter+arcade+2D+de+supervivencia&descAlignY=62&descSize=18" width="100%"/>
</div>

<div align="center">
  <a href="https://github.com/evagr11/Tri-Blaster">
    <img src="https://img.shields.io/badge/Ver_Código-informational?style=for-the-badge&logo=github&logoColor=white&color=555" alt="Ver Código">
  </a>
  <a href="https://evagr11.github.io/Curriculum/proyectos/tri-blaster.html">
    <img src="https://img.shields.io/badge/Ver_Web-orange?style=for-the-badge&logo=googlechrome&logoColor=white&color=F97316" alt="Ver Web">
  </a>
  <a href="https://evagr.itch.io/tri-blaster">
    <img src="https://img.shields.io/badge/Ver_en_itch.io-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white" alt="Ver en itch.io">
  </a>
</div>

  <br>
  
<div align="center">
  <a href="https://git.io/typing-svg"><img src="https://readme-typing-svg.demolab.com/?font=JetBrains+Mono&size=18&duration=3500&pause=800&color=F97316&center=true&vCenter=true&width=600&lines=Desarrollado+con+Unity+y+C%23%3BSistema+de+habilidades+y+cooldowns%3BMec%C3%A1nica+de+apuntado+con+rat%C3%B3n%3BFeedback+visual+con+gradientes" alt="Typing SVG" /></a>
</div>

# 🚀 Sobre el Proyecto

**Tri-Blaster** es un shooter arcade en 2D donde la supervivencia es clave. En este juego, controlas un triángulo central que **gira automáticamente para apuntar hacia el cursor del ratón**, creando una mecánica de juego fluida y muy intuitiva. El objetivo es simple: sobrevivir el mayor tiempo posible eliminando las hordas de enemigos que se acercan desde los bordes.

Para defenderte, cuentas con un **arsenal estratégico de 4 habilidades**, cada una con su propio tiempo de recarga. La gestión de estos cooldowns, visualizados en la interfaz, es fundamental para dominar la partida y alcanzar una alta puntuación.

<div align="center">
  <img src="https://github.com/user-attachments/assets/62d2d937-66e2-4fa7-ad14-9a07a2d22204" alt="Mockup del juego" width="70%"/>
  <p><em>Mockup del juego</em></p>
</div>

### ✨ Características principales:

*   🎮 **Apuntado Intuitivo**: Controla la dirección de tus disparos moviendo el ratón. El jugador rota automáticamente para que solo te preocupes de apuntar y disparar.
*   🤖 **Hordas de Enemigos**: Círculos enemigos aparecen constantemente desde los bordes de la pantalla y se dirigen hacia ti. ¡No dejes que te alcancen!
*   💥 **Sistema de Habilidades**: Domina 4 habilidades únicas para atacar, defenderte o potenciarte. Cada una tiene un cooldown visual que deberás gestionar con estrategia.
*   🎨 **Feedback Visual Dinámico**: La vida, tanto del jugador como de los enemigos, se representa con gradientes de color que cambian en tiempo real según el daño, ofreciendo una lectura clara del estado del combate.
*   🏆 **Puntuación y Rejugabilidad**: Acumula puntos por cada enemigo derrotado y compite por superar tu propio récord en cada partida.

| En plena batalla | Fin de la partida |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/b8f1ff13-52e9-430b-8b6d-beeac2a0934c" alt="Partida en transcurso" width="100%"/> | <img src="https://github.com/user-attachments/assets/1173fdd7-59ee-465e-90ce-d650e53c5b1d" alt="Partida finalizada con resumen de estadisticas de puntos" width="100%"/> |
| *Partida en transcurso.* | *Partida finalizada con resumen de estadísticas.* |

# 🧠 Contexto del Proyecto

Este proyecto fue desarrollado como parte de la asignatura de **Programación** durante el primer año del Ciclo Formativo de Grado Superior en **Desarrollo de Aplicaciones Multiplataforma (DAM)**. Sirvió para aplicar conceptos fundamentales de programación orientada a objetos, gestión de estados y diseño de mecánicas de juego en un entorno práctico como Unity.

# 🛠️ Stack Tecnológico
<div align="center">
  <img src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/Status-Stable-brightgreen?style=for-the-badge" alt="Status Stable"/>
</div>

*   **Motor de Videojuego:** Unity
*   **Lenguaje de Programación:** C#
*   **Interfaz de Usuario (UI):** Unity UI (UGUI) y TextMeshPro
*   **Control de Versiones:** Git y GitHub

# 📂 Estructura del Proyecto

La estructura del proyecto sigue las convenciones estándar de Unity para organizar los assets y scripts de manera lógica y escalable.

```bash
Tri-Blaster/
├── Assets/
│   ├── Prefabs/          # Prefabs para enemigos, proyectiles, etc.
│   ├── Scenes/           # Escena principal del juego (SampleScene.unity)
│   ├── scripts/          # Lógica principal (Player, Enemy, Spawner, etc.)
│   │   ├── Player.cs
│   │   ├── Enemy.cs
│   │   ├── HealthPlayer.cs
│   │   ├── Spawner.cs
│   │   └── Proyectil.cs
│   ├── Habilidades/      # Scripts para las 4 habilidades del jugador
│   │   ├── Habilidad1.cs
│   │   ├── Habilidad2.cs
│   │   ├── Habilidad3.cs
│   │   └── Habilidad4.cs
│   └── TextMesh Pro/     # Recursos para la UI de texto
├── Packages/
│   └── manifest.json     # Dependencias del proyecto Unity
└── ProjectSettings/      # Configuración del proyecto
```

# 🚀 Cómo Utilizar el Proyecto

Para ejecutar este proyecto en tu entorno local, necesitarás tener instalado **Unity Hub** y una versión compatible de **Unity Editor**.

1.  **Clona el repositorio:**
    ```bash
    git clone https://github.com/evagr11/Tri-Blaster.git
    ```

2.  **Abre el proyecto en Unity Hub:**
    *   Inicia Unity Hub.
    *   Haz clic en `Open` o `Abrir`.
    *   Navega hasta la carpeta del repositorio recién clonado y selecciónala.

3.  **Abre el Editor de Unity:**
    *   Unity Hub podría pedirte que instales la versión del editor con la que se creó el proyecto. Se recomienda usar **Unity 2022.3 LTS** o una versión superior para asegurar la compatibilidad de los paquetes.
    *   Una vez que el proyecto esté en tu lista, haz clic sobre él para abrirlo en el Editor de Unity.

4.  **Ejecuta el juego:**
    *   En la ventana `Project`, navega a la carpeta `Assets/Scenes/`.
    *   Haz doble clic sobre el archivo `SampleScene.unity` para abrir la escena principal.
    *   Presiona el botón **Play** ▶ en la parte superior del editor para iniciar el juego.

<div align="center">
  <p>Creado por <strong>Eva Gallardo</strong></p>
  <a href="https://github.com/evagr11" target="_blank">
    <img src="https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">
  </a>
  <a href="https://www.linkedin.com/in/eva-gallardo-romero-830362349/" target="_blank">
    <img src="https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn">
  </a>
</div>

<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7C2D12%2C50%3AF97316%2C100%3AFED7AA&height=120&section=footer" width="100%"/>
</div>
