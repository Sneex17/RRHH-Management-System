<script setup lang="ts">


defineProps({
    TextPlaceholder: { type: String }
});

</script>
<template>
    <form>
        <div class="mb-3">
            <input type="email" :placeholder="TextPlaceholder" class="form-control" id="exampleInputEmail1"
                aria-describedby="emailHelp">
        </div>
    </form>
</template>
<style></style>