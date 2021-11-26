<template >
  <v-app>
    <v-toolbar
      app
      src="..\img\2.jpg"
      height="220"
    >
    <v-col class="font-weight-bold white--text ">
        <v-app-bar-title class="d-flex align-center">Степанова Виктория</v-app-bar-title>
      </v-col>
    </v-toolbar>
    

    <v-main class="cyan darken-4">
      <v-container >
        <v-col class="white--text">
            <h1>Расписание дня</h1>
        </v-col >
        <Cafe></Cafe>
      </v-container>
    </v-main>

  </v-app>
</template>

<script>
import Cafe from './components/Cafe.vue';
export default {
  name: 'App',

  components: {
    Cafe
  },

  data: () => ({
    //
  }),
};
</script>
