<script setup lang="ts">
import Inputs from '@/components/Forms/Inputs.vue';
import ComboBox from '@/components/Forms/ComboBox.vue';
import TableEmpleados from "@/components/Forms/TableEmpleados.vue";
import { ref } from 'vue';



const sexos = ref([
    { id: 1, nombre: 'Masculido' }, { id: 2, nombre: 'Femenino' }]);

const departamentos = ref([
    { id: 1, nombre: 'Informatica TI' }, { id: 2, nombre: 'Contabilidad' }]);

const estadosCiviles = ref([
    { id: 1, nombre: 'Estudiante' }, { id: 2, nombre: 'Casado' }]);

const cargos = ref([
    { id: 1, nombre: 'Secretaria' }, { id: 2, nombre: 'Gerente' }]);
const estados = ref([
    { id: 1, nombre: 'Activo' }, { id: 2, nombre: 'Inactivo' }]);


const listaEmpleado = ref([
    { id: 'LM-0002', nombre: 'Juan', apellido: 'Perez', sexo: 'M', estadoCivil: 'Soltero', departamento: 'Contabilidad', cargo: 'Contable', estado: true },
    { id: 'LM-0003', nombre: 'Jose', apellido: 'Miguel', sexo: 'M', estadoCivil: 'Estudiante', departamento: 'Contabilidad', cargo: 'Contable', estado: false },
    { id: 'LM-0004', nombre: 'Maria', apellido: 'Liz', sexo: 'F', estadoCivil: 'Soltero', departamento: 'Informatica TI', cargo: 'Especialista', estado: true },
    { id: 'LM-0005', nombre: 'Alex', apellido: 'Roberto', sexo: 'M', estadoCivil: 'Casado', departamento: 'Informatica TI', cargo: 'Desarrollo', estado: false },

]);

</script>
<template>
    <h2>Vista</h2>
    <form class="container-form">
        <div class="contanier-input">
            <label for="InputName">Id Empleado</label>
            <Inputs TextPlaceholder="Ej: LM-0001" />
        </div>
        <div class="contanier-input">
            <label for="InputName">Nombre</label>
            <Inputs TextPlaceholder="Ej: Lucero" />
        </div>
        <div class="contanier-input">
            <label for="InputName">Apellido</label>
            <Inputs TextPlaceholder="Ej: Lazar" />
        </div>
        <div class="container-input">
            <label for="SelectSexo">Sexo</label>
            <ComboBox textSelected="Selecione un sexo" :comboValue="sexos" />
        </div>
        <div class="container-input">
            <label for="SelectSexo">Estado Civil</label>
            <ComboBox textSelected="Selecione un estado civil" :comboValue="estadosCiviles" />
        </div>
        <div class="container-input">
            <label for="SelectSexo">Departamentos</label>
            <ComboBox textSelected="Selecione un departamento" :comboValue="departamentos" />
        </div>
        <div class="container-input">
            <label for="SelectSexo">Cargo</label>
            <ComboBox textSelected="Selecione un cargo" :comboValue="cargos" />
        </div>
        <div class="container-input">
            <label for="SelectSexo">Estado</label>
            <ComboBox textSelected="Selecione un estado" :comboValue="estados" id="comboEstado" />
        </div>
    </form>
    <div class="container-table">
        <h3 class="table-text">Lista de empleados</h3>
        <TableEmpleados :dataTable="listaEmpleado" />
    </div>

</template>
<style>
.container-form {
    padding: 7px;
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 10px;
    background-color: rgba(0, 0, 0, 0.324);
    border-radius: 11px;
}

@media screen and (max-width: 700px) {
    .container-form {
        display: flex;
        flex-direction: column;
        gap: 5px;
    }
}

@media screen and (max-width: 1200px) {
    .container-form {
        grid-template-columns: repeat(3, 1fr);
    }
}
</style>