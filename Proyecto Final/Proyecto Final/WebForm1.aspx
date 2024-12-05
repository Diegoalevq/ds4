<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto_Final.WebForm1" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Memorama</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
    <style>
        :root {
            --w: calc(70vw / 6);
            --h: calc(70vh / 4);
        }

        * {
            transition: all 0.5s;
        }

        body {
            padding: 0;
            margin: 0;
            background-color: #2a9d8f;
            min-height: 100vh;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            text-align: center;
            font-family: Calibri;
        }

        div {
            display: inline-block;
        }

        .area-tarjeta,
        .tarjeta,
        .cara {
            cursor: pointer;
            width: var(--w);
            min-width: 100px;
            height: var(--h);
        }

        .tarjeta {
            position: relative;
            transform-style: preserve-3d;
            animation: iniciar 5s;
        }

        .cara {
            position: absolute;
            backface-visibility: hidden;
            box-shadow: inset 0 0 0 5px white;
            font-size: 500%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .trasera {
            background-color: #fcf6bd;
            transform: rotateY(180deg);
        }

        .superior {
            background-color: #e4c1f9;
        }

        .nuevo-juego {
            cursor: pointer;
            background-color: #e4c1f9;
            padding: 20px;
            border-radius: 50px;
            border: white 5px solid;
            margin-top: 20px;
            color: white;
        }

        .info-juego {
            margin-top: 20px;
            padding: 10px;
            background-color: #e4c1f9;
            border: 5px solid white;
            border-radius: 20px;
            color: white;
            font-size: 1.2rem;
        }

        .modal {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.8);
            display: flex;
            justify-content: center;
            align-items: center;
            color: white;
            z-index: 1000;
            display: none;
            flex-direction: column;
            text-align: center;
            font-size: 1.5rem;
        }

        .modal input {
            padding: 10px;
            margin-top: 10px;
            border-radius: 5px;
            border: none;
        }

        .modal button {
            cursor: pointer;
            background-color: #2a9d8f;
            color: white;
            padding: 10px 20px;
            border-radius: 5px;
            border: none;
            margin-top: 10px;
        }

        @keyframes iniciar {
            20%, 90% {
                transform: rotateY(180deg);
            }
            0%, 100% {
                transform: rotateY(0deg);
            }
        }
    </style>
</head>
<body>

    <div id="tablero"></div>
    <div class="nuevo-juego" onclick="iniciarJuego()">
        Nuevo Juego
    </div>
    <div class="info-juego">
        <p>Tiempo: <span id="tiempo">0</span> segundos</p>
        <p>Movimientos: <span id="movimientos">0</span></p>
    </div>

    <div class="modal" id="modalFin">
        <p>¡Felicidades, completaste el juego!</p>
        <p>Registra tu nombre:</p>
        <input type="text" id="nombre" placeholder="Tu nombre">
        <button onclick="guardarNombre()">Guardar</button>
    </div>

    <script>
        let iconos = [];
        let selecciones = [];
        let timer;
        let tiempo = 0;
        let movimientos = 0;
        let parejasEncontradas = 0;

        function cargarIconos() {
            iconos = [
                '<img src="https://i.ibb.co/pK31kwZ/00.png" width="70%">',
                '<img src="https://i.ibb.co/4SG5shk/580b57fbd9996e24bc43c02c.png" width="70%">',
                '<img src="https://i.ibb.co/GVLFSxH/00.png" width="70%">',
                '<img src="https://i.ibb.co/SmVF5vB/00.png" width="70%">',
                '<img src="https://i.ibb.co/y6z683V/00.png" width="70%">',
                '<img src="https://i.ibb.co/85r8z0f/9978a389246e31ed58bf4ebfc0cbe7ec.png" width="70%">',
                '<img src="https://i.ibb.co/mC2pqc5/00.jpg" width="70%">',
                '<img src="https://i.ibb.co/JQBmBXN/00.png" width="70%">',
                '<img src="https://i.ibb.co/z5ZgQwN/00.png" width="70%">',
                '<img src="https://i.ibb.co/dJZgXW2/image-snorlaxpng-pokemon-shuffle-wiki-fandom-powered-by-wikia-snorlax-png-256-256.png" width="70%">',
                '<img src="https://i.ibb.co/LJTbjXd/00.gif" width="70%">',
                '<img src="https://i.ibb.co/JHLQTz8/00.gif" width="70%">',
            ];
        }

        function iniciarJuego() {
            tiempo = 0;
            movimientos = 0;
            parejasEncontradas = 0;
            document.getElementById("tiempo").innerText = tiempo;
            document.getElementById("movimientos").innerText = movimientos;

            clearInterval(timer);

            timer = setInterval(() => {
                tiempo++;
                document.getElementById("tiempo").innerText = tiempo;
            }, 1000);

            generarTablero();
        }

        function generarTablero() {
            cargarIconos();

            // Duplicar los iconos para generar pares y mezclarlos
            const pares = [...iconos, ...iconos].sort(() => Math.random() - 0.5);

            let tablero = document.getElementById("tablero");
            let tarjetas = pares.map((icono, i) => `
                <div class="area-tarjeta" onclick="seleccionarTarjeta(${i})">
                    <div class="tarjeta" id="tarjeta${i}">
                        <div class="cara trasera" id="trasera${i}">
                            ${icono}
                        </div>
                        <div class="cara superior">
                            <i class="far fa-question-circle"></i>
                        </div>
                    </div>
                </div>
            `);

            tablero.innerHTML = tarjetas.join("");
        }

        function seleccionarTarjeta(i) {
            let tarjeta = document.getElementById("tarjeta" + i);
            if (tarjeta.style.transform !== "rotateY(180deg)") {
                tarjeta.style.transform = "rotateY(180deg)";
                selecciones.push(i);

                // Incrementar movimientos
                movimientos++;
                document.getElementById("movimientos").innerText = movimientos;
            }
            if (selecciones.length === 2) {
                deseleccionar(selecciones);
                selecciones = [];
            }
        }

        function deseleccionar(selecciones) {
            setTimeout(() => {
                let trasera1 = document.getElementById("trasera" + selecciones[0]);
                let trasera2 = document.getElementById("trasera" + selecciones[1]);
                if (trasera1.innerHTML !== trasera2.innerHTML) {
                    let tarjeta1 = document.getElementById("tarjeta" + selecciones[0]);
                    let tarjeta2 = document.getElementById("tarjeta" + selecciones[1]);
                    tarjeta1.style.transform = "rotateY(0deg)";
                    tarjeta2.style.transform = "rotateY(0deg)";
                } else {
                    trasera1.style.background = "plum";
                    trasera2.style.background = "plum";
                    parejasEncontradas++;

                    // Verificar si se completaron todas las parejas
                    if (parejasEncontradas === iconos.length) {
                        terminarJuego();
                    }
                }
            }, 1000);
        }

        function terminarJuego() {
          
            clearInterval(timer);

            document.getElementById("modalFin").style.display = "flex";
        }

        function guardarNombre() {
            const nombre = document.getElementById("nombre").value;

            // Llamada AJAX para enviar los datos al backend
            fetch('WebForm1.aspx/GuardarPuntaje', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    nombre: nombre,
                    tiempo: tiempo,
                    movimientos: movimientos
                })
            })
                .then(response => response.json())
                .then(data => {
                    alert(`¡Gracias, ${nombre}! Tu tiempo fue de ${tiempo} segundos con ${movimientos} movimientos.`);
                    document.getElementById("modalFin").style.display = "none";
                    iniciarJuego(); 
                })
                .catch(error => console.error('Error al guardar el puntaje:', error));
        }
    </script>

</body>
</html>
