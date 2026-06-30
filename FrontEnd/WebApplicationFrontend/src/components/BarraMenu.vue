<script setup>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { RouterLink } from 'vue-router';
</script>

<template>
    <div class="container-main">
        <div class="user-info">
            <font-awesome-icon icon="fa-solid fa-user" class="icon-user" style="color: aliceblue; font-size: 30px;" />
            <h3 class="text-user">Username</h3>
        </div>

        <div class="container-submenu">
            <RouterLink to="/MenuPrincipal" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-house" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Home</h3>
            </RouterLink>

            <RouterLink to="/MenuPrincipal/empleados" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-clipboard-user" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Empleados</h3>
            </RouterLink>

            <RouterLink to="/MenuPrincipal/nomina" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-money-check-dollar" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Nomina</h3>
            </RouterLink>

            <RouterLink to="/MenuPrincipal/departamentos" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-people-roof" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Departamentos</h3>
            </RouterLink>

            <RouterLink to="/MenuPrincipal/cargos" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-id-card" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Cargos</h3>
            </RouterLink>

            <RouterLink to="/MenuPrincipal/reportes" class="container-btn">
                <font-awesome-icon icon="fa-solid fa-file" class="icon-user"
                    style="color: aliceblue; font-size: 30px;" />
                <h3 class="text-user" style="font-size: 20px;">Reportes</h3>
            </RouterLink>
        </div>
    </div>
</template>

<style scoped>
* {
    box-sizing: border-box;
    /* Crucial para que el padding no rompa los anchos de 60px */
}

.container-main {
    display: flex;
    flex-direction: column;
    width: 67px;
    /* Ajustado ligeramente para dar espacio al icono + padding */
    min-width: 67px;
    /* Evita que Flexbox destruya o aplaste la barra */
    max-width: 67px;
    height: 100vh;
    padding: 17px 15px;
    background-color: rgb(6, 33, 98);
    border-radius: 0 17px 17px 0;
    gap: 25px;
    transition: 0.4s ease-in-out;
    overflow: hidden;
    white-space: nowrap;
}

.container-main:hover {
    width: 290px;
    min-width: 290px;
    max-width: 290px;
}

.user-info {
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 24px;
}

.user-info .text-user {
    color: aliceblue;
    font-size: 23px;
    margin: 0;
}

.container-submenu {
    display: flex;
    flex-direction: column;
    gap: 12px;
}

.container-btn {
    padding: 10px 0;
    display: flex;
    flex-direction: row;
    align-items: center;
    text-decoration: none;
    color: rgb(255, 255, 255);
    gap: 37px;
    cursor: pointer;
    border-radius: 17px;
    transition: background-color 0.2s;
}

.container-btn:hover {
    padding: 10px;
    background-color: rgba(255, 255, 255, 0.15);
}

.text-user {
    margin: 0;
}
</style>