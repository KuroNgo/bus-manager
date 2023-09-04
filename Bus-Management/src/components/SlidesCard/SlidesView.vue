<template>
    <div class="slides-inner relative">
        <button @click="ClickChangeSlides(1)"><font-awesome-icon id="left" class="a font-awesome-icon-left"
                icon="fa-solid fa-circle-arrow-left" style="color: #4678ce;" /></button>
        <ul class="cardousel scroll-smooth grid grid-flow-col mb-14 gap-4 overflow-hidden ">
            <CardView class="card snap-start" v-for="(x, i) in dataBus" draggable="flase" :route="route[i]"
                :ten-tuyen="tenTuyen[i]" :thoi-gian-bat-dau="thoiGianBatDau[i]" :thoi-gian-ket-thuc="thoiGianKetThuc[i]"
                :thoi-gian-khoang-cach="thoiGianKhoangCach[i]" />
        </ul>
        <button @click="ClickChangeSlides(-1)"><font-awesome-icon id="right" class="a font-awesome-icon-right"
                icon="fa-solid fa-circle-arrow-right" style="color: #316cd3;" /></button>
    </div>
</template>

<script>
import CardView from './CardView.vue';
import { RepositoryFactory } from '../../API/RepositoryFactory';
const TuyenRepository = RepositoryFactory.get('tuyen')
export default {
    data() {
        return {
            dataBus: [],
            dataQLXe: [],
            // widthDefault: 0,
            widthNext: 0,
            widthDefault: 0,
            route: [],
            tenTuyen: [],
            thoiGianBatDau: [],
            thoiGianKetThuc: [],
            thoiGianKhoangCach: [],
        }
    },
    created() {
        this.fetch()
    },
    mounted() {
        this.MouseMoveChangeSlides()
    },

    components: {
        CardView,
    },

    methods: {
        //Call API
        async fetch() {
            const response = await TuyenRepository.getTuyen('1.0');
            this.dataBus = response.data.data
            for (let i = 0; i < this.dataBus.length; i++) {
                this.route.push(this.dataBus[i].loaiTuyen)
                this.tenTuyen.push(this.dataBus[i].tenTuyen)
                this.thoiGianBatDau.push(this.dataBus[i].thoiGianBatDau)
                this.thoiGianKetThuc.push(this.dataBus[i].thoiGianKetThuc)
                this.thoiGianKhoangCach.push(this.dataBus[i].thoiGianGianCach)
            }
        },     
        //Click Button Change Slides
        ClickChangeSlides(x) {
            const cardousel = document.querySelector('.cardousel')
            const firstCardWidth = cardousel.querySelector('.card').offsetWidth;
            if (x == 1) {
                cardousel.scrollLeft += -firstCardWidth;
                console.log("eee")
            }
            else if (x == -1) {
                cardousel.scrollLeft += firstCardWidth;
                
            }

        },

        //Mouse Move Change Slides
        MouseMoveChangeSlides() {
            const cardousel = document.querySelector('.cardousel')
            let isDragging = false, startX, startScrollLeft;
            const dragStart = (e) => {
                isDragging = true;
                cardousel.classList.add("dragging");
                startX = e.pageX;
                startScrollLeft = cardousel.scrollLeft;
            }
            const dragStop = () => {
                isDragging = false;
                cardousel.classList.remove("dragging");
            }
            const dragging = (e) => {
                if (!isDragging) return;
                cardousel.scrollLeft = startScrollLeft - (e.pageX - startX);
            }
            cardousel.addEventListener("mousemove", dragging);
            cardousel.addEventListener("mousedown", dragStart);
            cardousel.addEventListener("mouseup", dragStop);
        }
    },
}
</script>

<style scoped>
.cardousel {
    grid-auto-columns: calc((100% / 4) - 13px);
    /* overflow-x: auto; */
    scroll-snap-type: x mandatory;
    scrollbar-width: 0;
}

.dragging {
    cursor: grab;
    user-select: none;
    scroll-behavior: auto;
    scroll-snap-type: none;

}

.font-awesome-icon-left {
    left: -80px;
    position: absolute;
    font-size: 42px;
    top: 50%;
}

.font-awesome-icon-right {
    right: -80px;
    position: absolute;
    font-size: 42px;
    top: 50%;
}
</style>



