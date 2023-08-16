<template>
  <router-view > </router-view>
</template>

<style>
@import url('https://fonts.googleapis.com/css2?family=Odibee+Sans&family=Poppins&display=swap');

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'poppins', sans-serif;
  text-decoration: none;
}

#app {
  -webkit-user-select: none;
  /* Safari */
  -ms-user-select: none;
  /* IE 10 and IE 11 */
  user-select: none;
  /* Standard syntax */
  font-family: 'poppins', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}


/* Scroll bar stylings */
::-webkit-scrollbar {
  width: 15px;
  height: 15px;
}

/* Track */
::-webkit-scrollbar-track {
  background: #c5c5c576;
}

/* Handle */
::-webkit-scrollbar-thumb {
  background: #5175559a;
}

/* Handle on hover */
::-webkit-scrollbar-thumb:hover {
  background: #55555588;
}

.relative {
  position: relative;
}

svg {
  color: #fff;
}

svg:hover {
  cursor: pointer;
}


.fade-enter-from,
.fade-leave-active {
  opacity: 0.1;
}

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.2s ease;
}
</style>

