import { ref, computed } from 'vue'
import { defineStore } from 'pinia'

export const useCounterStore = defineStore('counter', {
  state: () => ({
    buttonClicked: false,
  }),
  actions: {
    setButtonClicked() {
      this.buttonClicked = true;
      this.$emit('run-event-triggered');
    },
  },
});
