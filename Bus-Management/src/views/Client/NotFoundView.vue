<template>
    <div id="container">
        <div class="content">
            <h2>404</h2>
            <h4>Opps! Page not found</h4>
            <p>
                The page you were looking for doesn't exist. 
                You may help mistyped the address or the page may help moved
            </p>
            <router-link to="/">Back to home</router-link>
        </div>
    </div>
</template>

<style scoped>
#container
{
    position: absolute;
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    background: url("./img/p404.png"),#1a5b34e0;
    box-shadow: 0 15px 30px rgba(0,0,0,0.5);
}
#container .content
{
    max-width: 600px;
    text-align: center;
}
#container .content h2
{
    font-weight: 500;
    font-size: 18vw;
    line-height: 1em;
    color: #fff;
}
#container .content h4
{
    position: relative;
    font-size: 1.5em;
    margin-bottom: 20px;
    color: #111;
    background: #fff;
    font-weight: 300;
    padding: 10px 20px;
    display: inline-block;
}
#container .content p
{
    color: #fff;
    font-size: 1.2em;
}
#container .content a
{
    position: relative;
    display: inline-block;
    padding: 10px 25px;
    background: #0f3219;
    color:#fff;
    text-decoration: none;
    margin-top: 25px;
    border-radius: 25px;
    border-bottom: 4px solid #759983;
}
</style>