<script setup lang="ts">
import Inputs from '@/components/Forms/Inputs.vue';
import ComboBox from '@/components/Forms/ComboBox.vue';
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
            <ComboBox textSelected="Selecione un estado" :comboValue="estados" />
        </div>
    </form>

</template>
<style>
.container-form {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 10px;
}
</style>