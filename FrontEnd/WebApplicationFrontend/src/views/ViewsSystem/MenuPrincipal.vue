<script setup lang="ts">
import BarraMenu from '../../components/BarraMenu.vue';
import { RouterView } from 'vue-router';
</script>

<template>
    <div class="container-principal">
        <BarraMenu />
        <div class="contenido-dinamico">
            <RouterView />
        </div>
    </div>
</template>

<style>
body,
html {
    margin: 0;
    padding: 0;
    width: 100%;
    height: 100%;
}

.container-principal {
    width: 100%;
    height: 100vh;
    margin: 0;
    padding: 0;
    background-color: aqua;
    /* Tu color aqua actual */
    display: flex;
    flex-direction: row;
    overflow: hidden;
}

.contenido-dinamico {
    flex-grow: 1;
    /* Esto obliga al div a absorber todo el ancho que deje libre la barra */
    height: 100vh;
    overflow-y: auto;
    /* Si el contenido de Empleados es muy largo, genera scroll solo ahí */
    padding: 25px;
}
</style>