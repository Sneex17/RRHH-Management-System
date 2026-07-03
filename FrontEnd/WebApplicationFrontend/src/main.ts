import "./assets/main.css";

import { createApp } from "vue";
import { createPinia } from "pinia";

import { library } from "@fortawesome/fontawesome-svg-core";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import {
  faUser,
  faClipboardUser,
  faMoneyCheckDollar,
  faPeopleRoof,
  faIdCard,
  faFile,
  faHome,
  faAnglesRight,
  faPenToSquare,
  faTrashCan,
} from "@fortawesome/free-solid-svg-icons";

import App from "./App.vue";
import router from "./router";

import "./assets/main.scss";
import "bootstrap";

library.add(
  faUser,
  faClipboardUser,
  faMoneyCheckDollar,
  faPeopleRoof,
  faIdCard,
  faFile,
  faHome,
  faAnglesRight,
  faPenToSquare,
  faTrashCan,
);

const app = createApp(App);
app.component("font-awesome-icon", FontAwesomeIcon as any);
app.use(createPinia());
app.use(router);

app.mount("#app");
