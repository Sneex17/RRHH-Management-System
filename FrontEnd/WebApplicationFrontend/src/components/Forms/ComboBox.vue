<script setup lang="ts">
interface dataComboBox {
    id: number;
    nombre: string;
}

defineProps<{
    textSelected: string,
    comboValue: dataComboBox[]
}>();


</script>
<template>
    <select class="form-select" aria-label="Default select example">
        <option selected>{{ textSelected }}</option>
        <option v-for="data in comboValue" :key="data.id" value="{{ sexo.id }}">{{ data.nombre }}</option>
    </select>
</template>
<style></style>