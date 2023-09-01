<template>
  <div>
    <HeaderView></HeaderView>
    <body>
      <div class="content">
        <img src="404.png" />
        <div class="right-content">
          <h1>4<span>0</span>4</h1>
          <p>Opps..</p>
          <p>The is not web page your looking for</p>
          <button
            class="text-white bg-green-400 hover:bg-green-500 focus:ring-4 focus:outline-none focus:ring-green-300 dark:focus:ring-green-800 rounded-lg text-sm px-5 py-2.5 text-center mr-2 mb-2"
          >
            Back Home
          </button>
        </div>
      </div>
    </body>
    <FooterView></FooterView>
  </div>
</template>
<script>
import HeaderView from "../components/HeaderView.vue";
import FooterView from "../components/FooterView.vue";
export default {
  components: {
    HeaderView,
    FooterView,
  },
};
</script>

<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
body {
  width: 100%;
  height: 100vh;
  display: grid;
  place-items: center;
}
.content {
  display: flex;
  justify-content: center;
  align-items: center;
}
img,
video {
  max-width: 100%;
  height: 350px;
}
h1 {
  font-size: 8em;
  color: #1a5b34e0;
}
h1 span {
  color: #d4e8ff;
}
.right-content {
  text-align: center;
}
p {
  letter-spacing: 0.4em;
  color: #222;
  margin-bottom: 15px;
}
button {
  padding: 8px 15px;
  border: none;
  background-color: #1a5b34e0;
  color: skyblue;
  border-radius: 3px;
  cursor: pointer;
  transition: all 0.2s ease-in;
  box-shadow: 0px 10px 15px -3px rgba(0, 0, 0, 0.1 green, blue, alpha);
}
button:hover {
  transform: scale(1.05);
}
</style>
