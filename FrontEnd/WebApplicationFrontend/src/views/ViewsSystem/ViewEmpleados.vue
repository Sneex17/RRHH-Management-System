<script setup lang="ts">
import Inputs from '@/components/Forms/Inputs.vue';
import ComboBox from '@/components/Forms/ComboBox.vue';
import TableEmpleados from "@/components/Forms/TableEmpleados.vue";
import { onMounted, ref } from 'vue';
import { type cuerpoData } from "@/Controllers/Apis";
import * as SexoController from "@/Controllers/SexoController"
import * as EstadoController from "@/Controllers/EstadoController"
import * as EstadoCivilController from "@/Controllers/EstadoCivilController"
import * as DepartamentoController from "@/Controllers/DepartamentoController"




const sexos = ref<cuerpoData[]>([]);
onMounted(async () => {
    try {

        sexos.value = await SexoController.ListaSexos();
    } catch (error) {
        console.error("Error cargando sexos:", error);
    }
});

const estados = ref<cuerpoData[]>([]);
onMounted(async () => {
    try {
        estados.value = await EstadoController.ListaEstados();
    } catch (error) {
        console.log("Error cargando estados:", error);
    }
})

const estadosCiviles = ref<cuerpoData[]>([])
onMounted(async () => {
    try {
        estadosCiviles.value = await EstadoCivilController.ListaEstadosCiviles();
    } catch (error) {
        console.log("Error cargando estados civiles:", error);
    }
})

const departamentos = ref<cuerpoData[]>([]);
onMounted(async () => {
    try {
        departamentos.value = await DepartamentoController.ListaDepartamento();
    } catch (error) {
        console.log("Error cargando departamentos:", error);
    }
})


const cargos = ref([
    { id: 1, nombre: 'Secretaria' }, { id: 2, nombre: 'Gerente' }]);



const listaEmpleado = ref([
    { id: 'LM-0002', nombre: 'Juan', apellido: 'Perez', sexo: 'M', estadoCivil: 'Soltero', departamento: 'Contabilidad', cargo: 'Contable', estado: true },
    { id: 'LM-0003', nombre: 'Jose', apellido: 'Miguel', sexo: 'M', estadoCivil: 'Estudiante', departamento: 'Contabilidad', cargo: 'Contable', estado: false },
    { id: 'LM-0004', nombre: 'Maria', apellido: 'Liz', sexo: 'F', estadoCivil: 'Soltero', departamento: 'Informatica TI', cargo: 'Especialista', estado: true },
    { id: 'LM-0005', nombre: 'Alex', apellido: 'Roberto', sexo: 'M', estadoCivil: 'Casado', departamento: 'Informatica TI', cargo: 'Desarrollo', estado: false },

]);

</script>
<template>
    <h3>Gestión de empleados</h3>
    <form class="container-form">
        <div class="container-info-personal">
            <h5>Datos personales</h5>
            <div class="info-personal">
                <div class="preview-img">
                    <img src="../../assets/Imgs/Perfil-empleado.png" alt="Imagen de perfil del empleado"
                        class="preview-perfil">
                    <input type="file" accept="image/*">
                </div>

                <div class="contanier-input">
                    <label for="InputName">Nombre</label>
                    <Inputs TextPlaceholder="Ej: Lucero" />
                </div>
                <div class="contanier-input">
                    <label for="InputName">Apellido</label>
                    <Inputs TextPlaceholder="Ej: Lazar" />
                </div>
                <div class="contanier-input">
                    <label for="InputName">Cedula</label>
                    <Inputs TextPlaceholder="Ej: 402-0000000-1" />
                </div>
                <div class="container-input">
                    <label for="SelectSexo">Sexo</label>
                    <ComboBox textSelected="Selecione un sexo" :comboValue="sexos" />
                </div>
                <div class="container-input">
                    <label for="SelectSexo">Estado Civil</label>
                    <ComboBox textSelected="Selecione un estado civil" :comboValue="estadosCiviles" />
                </div>
            </div>

        </div>
        <div class="container-info-empleado">
            <h5>Datos empresariales</h5>
            <div class="info-empleado">
                <div class="contanier-input">
                    <label for="InputName">Id Empleado</label>
                    <Inputs TextPlaceholder="Ej: LM-0001" />
                </div>
                <div class="container-input">
                    <label for="SelectSexo">Departamentos</label>
                    <ComboBox textSelected="Selecione un departamento" :comboValue="departamentos" />
                </div>
                <div class="container-input">
                    <label for="SelectSexo">Cargo</label>
                    <ComboBox textSelected="Selecione un cargo" :comboValue="cargos" />
                </div>
                <div class="contanier-input">
                    <label for="InputName">Salario</label>
                    <Inputs TextPlaceholder="Ej: RD$95,000.00" />
                </div>
                <div class="container-input">
                    <label for="SelectSexo">Estado</label>
                    <ComboBox textSelected="Selecione un estado" :comboValue="estados" id="comboEstado" />
                </div>
            </div>

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
    grid-template-columns: repeat(2, 1fr);
    gap: 10px;
    background-color: rgba(0, 0, 0, 0.324);
    border-radius: 11px;
}

.info-personal,
.info-empleado {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 0 10px;
}

.preview-img {
    background-color: rgb(255, 255, 255);
    width: auto;
    height: 170px;
    border-radius: 19px;
}

.preview-img .preview-perfil {
    width: 130px;
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