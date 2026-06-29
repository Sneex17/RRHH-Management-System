<script lang="ts">
import { RouterLink } from 'vue-router'
</script>

<template>
  <nav class="navbar navbar-expand-lg navbar-personalizado w-100">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">
        <img src="../assets/logo.svg" alt="Bootstrap" width="30" height="24">
      </a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#">
              <RouterLink class="text-list" to="/">Home</RouterLink>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">
              <RouterLink class="text-list" to="/about">About</RouterLink>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">
              <RouterLink class="text-list" to="/login" custom v-slot="{ href, navigate }">
                <a :href="href" @click="navigate" target="_blank">Login</a>
              </RouterLink>
            </a>
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<style scoped>
.navbar-personalizado {
  background-color: rgba(4, 85, 171, 0.607);
}

.text-list {
  color: white;
  outline: none;
  text-decoration: none;
}


nav {
  width: 100%;
  font-size: 17px;
  text-align: center;
  margin-top: 2rem;
  background-color: rgb(4, 4, 4);
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}
</style>