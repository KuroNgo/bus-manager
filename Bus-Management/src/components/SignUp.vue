<template>
   <div>
    <HeaderView/>   
    <center>
        <img class="logo" src="../assets/buslogo.png">
    </center>
   
    <div class="register">
      <input type="text" v-model="name" placeholder="Enter Name">
      <input type="text" v-model="email" placeholder="Enter Email">
      <input type="password" v-model="password" placeholder="Enter Password">
      <button v-on:click="signUp">Sign Up</button>
    </div>    
<FooterView/>
</div>

</template>

<script>
import FooterView from './FooterView.vue';
import HeaderView from './HeaderView.vue';
// import axios from 'axios'
// import { onMounted } from 'vue';
export default {
name :'SignUp',
components:{HeaderView,FooterView},
// data(){
//     return {
//         name:'',
//         email:'',
//         password:''
//     }
// },
// methods:{
//  async signUp()
// {
//     let result=  await axios.post("http://localhost:3000/user",{
//         email:this.email,
//         password:this.password,
//         name:this.name

//     });

//     console.warn(result);
//     if(result.status==201)
//     {
//         const message = "Hello, world!";
// console.log(message); 
//          alert("sign-up done");
//         localStorage.setItem("user-info",JSON.stringify((result).data))
//         this.$router.push({name:'Home'})

//     }
// },


// }

}
</script>

<style>
.logo{
  width: 100px;  
}
.register input {
   width: 300px;
   height: 40px;
   padding-left: 20px;
   display: block;
   margin-bottom: 30px;
   margin-right: auto;
   margin-left: auto;
   border: 1px solid skyblue;
}
 .register button {
    width:320px ;
    height: 40px;
    border: 1px solid skyblue;
    background: skyblue;
    color: #fff;
    cursor: pointer;
 }
</style>