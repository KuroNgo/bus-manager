<template>
    <footer>
        <div class="footer">
            <div class="about-us relative">
                <div class="context context-left">
                    <h1>BUS MANAGEMENT</h1>
                    <p>Địa chỉ: 217/24/12 Ngô Quyền, Phường 6, Tp Đà Lạt </p>
                    <p>Hotline: <a href="tel:+0908747742"  style="color: #fff;"> 0908747742 (Mr Tâm)</a>
                    </p>
                    <p>Email: <a href="mailto:tamproduction102@gmail.com"
                            style="color: #fff;">tamproduction102@gmail.com</a>
                    </p>
                    <p>Chụp ảnh Đà Lạt, quay phim Đà Lạt</p>
                    <div class="line"></div>
                    <div class="icon flex justify-center items-center">
                        <a href="https://www.facebook.com/ngothanhtam.photodalat" target="_blank">
                            <font-awesome-icon icon="fa-brands fa-facebook"
                                style="font-size: 20px; margin-top: 10px; --fa-animation-duration: 2s; --fa-animation-iteration-count: 5" />
                        </a>
                        <a href="https://www.youtube.com/@quayphimdalat102" target="_blank">
                            <font-awesome-icon icon="fa-brands fa-youtube" 
                                style=" font-size: 20px; margin-top: 10px; margin-left: 10px; --fa-animation-duration: 2s; --fa-animation-iteration-count: 5" />

                        </a>
                        <a href="https://www.tiktok.com/@ngothanhtam.dalat" target="_blank">
                            <font-awesome-icon icon="fa-brands fa-tiktok" 
                                style=" font-size: 20px; margin-top: 10px; margin-left: 10px; --fa-animation-duration: 2s; --fa-animation-iteration-count: 5" />
                        </a>
                        <a href="https://tamproduction.com/" target="_blank">
                            <font-awesome-icon icon="earth-americas"  style=" font-size: 20px; margin-top: 5px; margin-left: 10px; --fa-animation-duration: 2s; --fa-animation-iteration-count: 5" />
                        </a>
                    </div>

                </div>
            </div>
        </div>
    </footer>
</template>

<style scoped>
.footer {
    position: relative;
    bottom: 0;
    overflow: hidden;
    width: 100%;
    color: #fff;
}

.about-us {
    background: url('../assets/img/pngkey.com-world-map-black-and-1707126.png'), #1a5b34e0;
    background-repeat: no-repeat;
    background-position: center;
    width: 100%;
    height: 450px;
    border-top: 2px solid #fff;
}

.about-us p {
    font-size: 15px;
    text-align: center;
    margin-bottom: 10px;
}

.about-us h1 {
    font-size: 3.5em;
    font-weight: bold;
    text-align: center;
}

.context-left {
    transform: translateY(35%);
}

.line {
    width: 45%;
    border-bottom: 1px solid #fff;
    margin: auto;
}

</style>