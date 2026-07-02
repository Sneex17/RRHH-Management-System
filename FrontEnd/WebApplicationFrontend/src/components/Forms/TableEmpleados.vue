<script setup lang="ts">
import { type empleados } from "../../Entities/Empleados";
/*interface empleados {
    id: string;
    nombre: string;
    apellido: string;
    estadoCivil: string;
    departamento: string;
    cargo: string;
    sexo: string;
    estado: boolean;
}*/
defineProps<{
    dataTable: empleados[];
}>();

</script>
<template>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Id</th>
                <th scope="col">Nombre</th>
                <th scope="col">Apellido</th>
                <th scope="col">Sexo</th>
                <th scope="col">Estado Civil</th>
                <th scope="col">Departamento</th>
                <th scope="col">Cargo</th>
                <th scope="col">Estado</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="empleado in dataTable">
                <th scope="row">{{ empleado.id }}</th>
                <td>{{ empleado.nombre }}</td>
                <td>{{ empleado.apellido }}</td>
                <td>{{ empleado.sexo }}</td>
                <td>{{ empleado.estadoCivil }}</td>
                <td>{{ empleado.departamento }}</td>
                <td>{{ empleado.cargo }}</td>
                <td>{{ empleado.estado }}</td>
            </tr>
        </tbody>
    </table>
</template>
<style scoped></style>