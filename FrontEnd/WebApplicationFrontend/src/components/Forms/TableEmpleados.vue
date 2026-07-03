<script setup lang="ts">
import { type empleados } from "../../Entities/Empleados";
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

defineProps<{
    dataTable: empleados[];
}>();

</script>
<template>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Id</th>
                <th scope="col">Empleado</th>
                <th scope="col">Sexo</th>
                <th scope="col">Estado Civil</th>
                <th scope="col">Departamento</th>
                <th scope="col">Cargo</th>
                <th scope="col">Estado</th>
                <th scope="col">Acciones</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="empleado in dataTable">
                <th scope="row">{{ empleado.id }}</th>
                <td>{{ empleado.nombre + " " + empleado.apellido }}</td>
                <td>{{ empleado.sexo }}</td>
                <td>{{ empleado.estadoCivil }}</td>
                <td>{{ empleado.departamento }}</td>
                <td>{{ empleado.cargo }}</td>
                <td>{{ empleado.estado }}</td>
                <td>
                    <button type="button" class="btn btn-primary">
                        <font-awesome-icon icon="fa-solid fa-pen-to-square" class="icon-user"
                            style="color: aliceblue; font-size: 20px;" />
                    </button>
                    <button type="button" class="btn btn-danger">
                        <font-awesome-icon icon="fa-solid fa-trash-can" class="icon-user"
                            style="color: aliceblue; font-size: 20px;" />
                    </button>
                </td>
            </tr>
        </tbody>
    </table>
</template>
<style scoped></style>