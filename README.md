<div align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0%3A7C2D12%2C50%3AF97316%2C100%3AFED7AA&height=200&section=header&text=Tri-Blaster&fontSize=60&fontColor=fff&fontAlignY=38&desc=Un+shooter+arcade+2D+de+supervivencia&descAlignY=62&descSize=18" width="100%"/>
</div>

<div align="center">
  <a href="https://github.com/evagr11/Tri-Blaster" target="_blank">
    <img src="https://img.shields.io/badge/Ver_Código-7C2D12?style=for-the-badge&logo=github&logoColor=white" alt="Ver Código">
  </a>
  <a href="https://evagr11.github.io/Tri-Blaster/" target="_blank">
    <img src="https://img.shields.io/badge/Documentación_(Doxygen)-7C2D12?style=for-the-badge&logo=doxygen&logoColor=white" alt="Documentación del código">
  <a href="docs/Documentacion_Tri-Blaster.pdf" target="_blank"><img src="https://img.shields.io/badge/Documentación-7C2D12?style=for-the-badge&logo=latex&logoColor=white" alt="Documentación"></a>
  </a>
  <a href="https://evagr11.github.io/Curriculum/proyectos/tri-blaster.html" target="_blank">
    <img src="https://img.shields.io/badge/Ver_Web-F97316?style=for-the-badge&logo=googlechrome&logoColor=white" alt="Ver Web">
  </a>
  <a href="https://evagr.itch.io/tri-blaster" target="_blank">
    <img src="https://img.shields.io/badge/Ver_en_itch.io-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white" alt="Ver en itch.io">
  </a>
</div>

<br>

<div align="center">
  <a href="https://git.io/typing-svg"><img src="https://readme-typing-svg.demolab.com/?font=JetBrains+Mono&size=18&duration=3500&pause=800&color=F97316&center=true&vCenter=true&width=600&lines=Desarrollado+con+Unity+y+C%23%3BSistema+de+habilidades+y+cooldowns%3BMec%C3%A1nica+de+apuntado+con+rat%C3%B3n%3BFeedback+visual+con+gradientes" alt="Typing SVG" /></a>
</div>

# Sobre el Proyecto

**Tri-Blaster** es un shooter arcade en 2D donde la supervivencia es clave. En este juego, controlas un triángulo central que **gira automáticamente para apuntar hacia el cursor del ratón**, creando una mecánica de juego fluida y muy intuitiva. El objetivo es simple: sobrevivir el mayor tiempo posible eliminando las hordas de enemigos que se acercan desde los bordes.

Para defenderte, cuentas con un **arsenal estratégico de 5 habilidades**, cada una con su propio tiempo de recarga. La gestión de estos cooldowns, visualizados en la interfaz, es fundamental para dominar la partida y alcanzar una alta puntuación.

<div align="center">
  <img src="https://github.com/user-attachments/assets/62d2d937-66e2-4fa7-ad14-9a07a2d22204" alt="Mockup del juego" width="70%"/>
  <p><em>Mockup del juego</em></p>
</div>

### Características principales:

*   **Apuntado Intuitivo**: Controla la dirección de tus disparos moviendo el ratón. El jugador rota automáticamente para que solo te preocupes de apuntar y disparar.
*   **Hordas de Enemigos**: Círculos enemigos aparecen sin parar (uno cada 0,2 s) desde cualquier punto de un anillo alrededor del jugador y van directos hacia ti.
*   **Sistema de Habilidades**: 5 habilidades para atacar, curarte o potenciarte, seleccionables con las teclas `1`-`5`. Cada una tiene un icono que se va rellenando mientras se recarga.
*   **Arquitectura extensible**: Todas las habilidades heredan de la clase abstracta `Director` e implementan `Trigger()`, y `AbilityHolder` solo guarda una lista de ellas. Añadir una habilidad nueva es crear un script y arrastrarlo a la lista.
*   **Feedback Visual Dinámico**: La vida, tanto del jugador como de los enemigos, se representa con gradientes de color que cambian en tiempo real según el daño, ofreciendo una lectura clara del estado del combate.
*   **Puntuación y Rejugabilidad**: Un punto por cada enemigo derrotado y resumen al morir. Con `R` empiezas otra partida al instante.

### Controles

<div align="center">

| Tecla | Acción |
| :---: | :----- |
| `Espacio` | Empezar la partida |
| Ratón | Apuntar (el triángulo gira hacia el cursor) |
| Clic izquierdo | Usar la habilidad seleccionada |
| `1` - `5` | Elegir habilidad |
| `R` | Reiniciar |

</div>

### Habilidades

<div align="center">

| Tecla | Habilidad | Recarga | Efecto |
| :---: | :-------- | :-----: | :----- |
| `1` | **Disparo rápido** | 0,5 s | Proyectil pequeño hacia donde apuntas |
| `2` | **Disparo potente** | 2 s | Proyectil más grande |
| `3` | **Curación instantánea** | 5 s | Recupera toda la vida |
| `4` | **Curación** | 3 s | Multiplica por 5 la regeneración de vida durante 10 s |
| `5` | **Aumento de fuerza** | 2 s | Duplica la fuerza durante 6 s: más daño y proyectiles más grandes |

</div>

| En plena batalla | Fin de la partida |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/b8f1ff13-52e9-430b-8b6d-beeac2a0934c" alt="Partida en transcurso" width="100%"/> | <img src="https://github.com/user-attachments/assets/1173fdd7-59ee-465e-90ce-d650e53c5b1d" alt="Partida finalizada con resumen de estadisticas de puntos" width="100%"/> |
| *Partida en transcurso.* | *Partida finalizada con resumen de estadísticas.* |

# Contexto del Proyecto

Este proyecto fue desarrollado como parte de la asignatura de **Programación** durante el primer año del Ciclo Formativo de Grado Superior en **Desarrollo de Aplicaciones Multiplataforma (DAM)**. Sirvió para aplicar conceptos fundamentales de programación orientada a objetos, gestión de estados y diseño de mecánicas de juego en un entorno práctico como Unity.

# Stack Tecnológico
<div align="center">
  <img src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/Status-Stable-brightgreen?style=for-the-badge" alt="Status Stable"/>
</div>

<br>

<div align="center">

| Área | Tecnología |
| :--- | :--------- |
| **Motor** | `Unity 2022.3 LTS` (2D) |
| **Lenguaje** | `C#` |
| **Arquitectura** | Clase abstracta `Director` para las habilidades, eventos (`GameEvents`) para inicio, muerte y puntuación |
| **Interfaz** | `Unity UI` (iconos de recarga) y `TextMesh Pro` |
| **Visual** | Gradientes de color para la vida y sistemas de partículas |
| **Control de versiones** | `Git` y `GitHub` |

</div>

# Estructura del Proyecto

La estructura del proyecto sigue las convenciones estándar de Unity para organizar los assets y scripts de manera lógica y escalable.

```bash
Tri-Blaster/
├── Assets/
│   ├── Prefabs/          # Prefabs para enemigos, proyectiles, etc.
│   ├── Scenes/           # Escena principal del juego (SampleScene.unity)
│   ├── scripts/
│   │   ├── Player.cs            # Gira el triángulo hacia el ratón
│   │   ├── AtributosJugador.cs  # Vida, fuerza y regeneración
│   │   ├── HealthPlayer.cs      # Color según la vida, derrota y reinicio
│   │   ├── Enemy.cs             # Movimiento hacia el jugador y daño
│   │   ├── HealthEnemy.cs       # Vida y color del enemigo
│   │   ├── Proyectil.cs         # Movimiento y daño del disparo
│   │   ├── Spawner.cs           # Aparición de enemigos
│   │   └── Score.cs             # Puntuación
│   ├── Habilidades/
│   │   ├── Habilidad1.cs        # Disparo (se usa dos veces con distinto tamaño y recarga)
│   │   ├── Habilidad2.cs        # Curación instantánea
│   │   ├── Habilidad3.cs        # Curación progresiva
│   │   └── Habilidad4.cs        # Aumento de fuerza
│   ├── Director.cs              # Clase base abstracta de las habilidades
│   ├── AbilityHolder.cs         # Lista de habilidades, selección y uso
│   ├── GameStart.cs             # Pantalla de inicio
│   ├── GameEvents.cs            # Eventos del juego
│   └── TextMesh Pro/     # Recursos para la UI de texto
├── Packages/
│   └── manifest.json     # Dependencias del proyecto Unity
└── ProjectSettings/      # Configuración del proyecto
```

# Cómo Utilizar el Proyecto

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
    *   Unity Hub podría pedirte que instales la versión del editor con la que se creó el proyecto. El proyecto se creó con **Unity 2022.3.50f1 (LTS)**; cualquier 2022.3 sirve. Si solo quieres jugar, está [en itch.io](https://evagr.itch.io/tri-blaster).
    *   Una vez que el proyecto esté en tu lista, haz clic sobre él para abrirlo en el Editor de Unity.

4.  **Ejecuta el juego:**
    *   En la ventana `Project`, navega a la carpeta `Assets/Scenes/`.
    *   Haz doble clic sobre el archivo `SampleScene.unity` para abrir la escena principal.
    *   Presiona el botón **Play** ▶ en la parte superior del editor y pulsa `Espacio` para empezar.

<br>

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
