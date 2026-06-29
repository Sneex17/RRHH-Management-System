<script setup lang="ts">

import { ref } from 'vue'
import { useRouter } from 'vue-router'
import { Usuarios } from '../Entities/Usuarios';


const nombre = ref()   // v-model lo llena automáticamente
const pass = ref()

const router = useRouter()

async function login() {
    try {

        let Usuario = new Usuarios();
        Usuario.Username = nombre.value;
        Usuario.Passwords = pass.value;

        const UsuarioJson: string = JSON.stringify(Usuario);
        console.log(UsuarioJson);

        const res = await fetch('https://localhost:7001/apirrhh/usuarios/validar-user', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: UsuarioJson
        });

        const data = await res.json();
        //console.log(data);
        Object.assign(Usuario, data);
        console.log(Usuario);

        if (Usuario.UserId > 0) {
            console.log(data)
            router.push('/MenuPrincipal');
            alert('Usuario encontrado');
        } else {
            alert('Usuario o contraseña incorrectos');
        }
    } catch (error) {
        console.error(error);
        alert('No se pudo conectar con el servidor');
    }
}


</script>

<template>
    <div class="container">
        <div class="conatainer-items">
            <div class="container-info">
                <h2>Welcome</h2>
                <h3>To Larizel System</h3>
            </div>

            <div class="conatainer-login">
                <h2>Iniciar Seccion</h2>

                <input type="text" id="username" v-model="nombre" class="input-login" placeholder="Usuario">

                <input type="password" id="password" v-model="pass" class="input-login" placeholder="Contraseña">

                <div @click="login" class="btn">Sing In</div>
            </div>
        </div>
    </div>
</template>

<style>
body {
    background-color: aliceblue;
    justify-content: center;
    justify-items: center;
    align-content: center;
}

.container {
    display: flex;
    justify-content: center;
    padding: 10px;
    width: auto;
    height: auto;
}

.conatainer-items {
    display: flex;
    justify-content: center;
    border-radius: 18px;
    padding: 7px;
    box-shadow: 0 0 5px 5px rgba(0, 0, 0, 0.3);
}

.btn {
    width: 250px;
    height: 45px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: rgb(7, 149, 235);
    color: white;
    border-radius: 11px;
    font-size: 1.3rem;
}

.input-login {
    background-color: rgb(232, 230, 230);
    border: none;
    outline: none;
    width: 250px;
    height: 45px;
    border-radius: 11px;
    color: rgb(84, 83, 83);
}

.container-info {
    padding: 10px;
    width: 450px;
    height: auto;
    background-image: url('../assets/Imgs/Fondo-Login.svg');
    background-repeat: no-repeat;
    background-size: cover;
    color: whitesmoke;
    border-radius: 11px 0 0 11px;
}

.conatainer-login {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding: 10px;
    background-color: white;
    border-radius: 0 11px 11px 0;
    gap: 1rem;
}

.conatainer-login h2 {
    color: black;
    font-size: 1.7rem;
    font-family: 'Montserrat', sans-seri;
}

@media screen and (max-width: 900px) {
    .conatainer-items {
        display: flex;
        flex-direction: column;

    }

    .container-info {
        height: 40vh;
        border-radius: 11px 11px 0 0;
    }
}
</style>