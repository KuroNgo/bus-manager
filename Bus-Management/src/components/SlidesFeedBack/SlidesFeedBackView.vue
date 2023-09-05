<template>
    <div class=" mx-80 bg-ThirdColor relative" style="border-radius: 32px;">
        <button @click="ClickChangeSlides(1)" id="left" class="btnleft"><font-awesome-icon class=" text-3xl"
                icon="fa-solid fa-circle-arrow-left" style="color: #4678ce;" /></button>
        <ul class="FeedBack scroll-smooth grid grid-flow-col mb-14 gap-4 overflow-hidden ">
            <FeedBackView class="card snap-start" v-for="x, i in Name" draggable="flase" :Comment="Comment" :Name="Name[i]"
                :Gmail="Gmail[i]" :Url="Url" />
        </ul>
        <button @click="ClickChangeSlides(-1)" id="right" class="btnright"><font-awesome-icon class="text-3xl"
                icon="fa-solid fa-circle-arrow-right" style="color: #316cd3;" /></button>
    </div>
</template>
<script>
import FeedBackView from './FeedBackView.vue'
export default {
    data() {
        return {
            Name: ['Đoàn Đình Hoàng', 'Ngô Hoài Phong', 'Nguyễn Ngọc Sơn', 'Mai Quang Định'],
            Gmail: ['2011384@dlu.edu.vn', '2011423@dlu.edu.vn', '2011432@dlu.edu.vn', '2011249@dlu.edu.vn'],
            Url: '../../../public/assets/img/buslogo.png',
            Comment: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce condimentum sapien ac leo cursus dignissim. In ac lectus vel orci accumsan ultricies at in libero accumsan Lorem Ipsum has been the industrys standard'
        }
    },
    components: {
        FeedBackView,
    },
    mounted() {
        this.MouseMoveChangeSlides()
    },
    methods: {
        ClickChangeSlides(x) {
            const FeedBack = document.querySelector('.FeedBack')
            const firstCardWidth = FeedBack.querySelector('.card').offsetWidth;
            if (x == 1) {
                FeedBack.scrollLeft += -firstCardWidth;
            }
            else if (x == -1) {
                FeedBack.scrollLeft += firstCardWidth;

            }

        },

        //Mouse Move Change Slides
        MouseMoveChangeSlides() {
            const FeedBack = document.querySelector('.FeedBack')
            let isDragging = false, startX, startScrollLeft;
            const dragStart = (e) => {
                isDragging = true;
                FeedBack.classList.add("dragging");
                startX = e.pageX;
                startScrollLeft = FeedBack.scrollLeft;
            }
            const dragStop = () => {
                isDragging = false;
                FeedBack.classList.remove("dragging");
            }
            const dragging = (e) => {
                if (!isDragging) return;
                FeedBack.scrollLeft = startScrollLeft - (e.pageX - startX);
            }
            FeedBack.addEventListener("mousemove", dragging);
            FeedBack.addEventListener("mousedown", dragStart);
            FeedBack.addEventListener("mouseup", dragStop);
        }
    }
}
</script>

<style scoped>
button {
    position: absolute;
    top: 85%;
}

.btnleft {
    left: 32px;
}

.btnright {
    left: 80px;
}

.FeedBack {
    grid-auto-columns: calc(100%);
    /* overflow-x: auto; */
    scroll-snap-type: x mandatory;
    scrollbar-width: 0;
}

.dragging {
    cursor: grab;
    user-select: none;
    scroll-behavior: auto;
    scroll-snap-type: none;
}</style>