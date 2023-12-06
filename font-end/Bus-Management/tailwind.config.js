/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.{vue,js,ts,jsx,tsx}",
  ],
  theme: {
    extend: {
      colors: {
        MainColor: '#FFFFFF',
        SecondColor: '#F5F6FA',
        ThirdColor: '#E1EFFE',
        FourColor: '#1A56DB',
        BlackColor :'#000',
      },
      
    },

  },
  plugins: [],
}

