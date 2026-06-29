import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
      path: "/about",
      name: "about",
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import("../views/AboutView.vue"),
    },
    {
      path: "/login",
      name: "login",
      component: () => import("../views/LoginView.vue"),
    },
    {
      path: "/MenuPrincipal",
      name: "MenuPrincipal",
      component: () => import("../views/ViewsSystem/MenuPrincipal.vue"),

      children: [
        {
          path: "",
          name: "MenuHome",
          component: () => import("../views/ViewsSystem/ViewHomeMenu.vue"),
        },
        {
          path: "empleados",
          name: "ViewEmpleados",
          component: () => import("../views/ViewsSystem/ViewEmpleados.vue"),
        },
      ],
    },
  ],
});

export default router;
