<template>
    <li class="flex justify-between items-center px-8 py-14">
        <div class=" w-2/3">
            <p class=" mb-10 text-xl font-medium text-BlackColor">{{ Comment }}</p>
            <h3 class=" text-2xl font-semibold text-BlackColor mb-2">{{ Name }}</h3>
            <span class=" text-base font-medium text-BlackColor">{{Gmail}}</span>
        </div>
        <div class=" w-1/3">
            <img class="w-full" :src="Url" alt="">
        </div>
    </li>
</template>
<script>
export default{
    data(){
        return{

        }
    },
    props :{
        Name : String,
        Gmail : String,
        Comment : String,
        Url : String
    },
    methods: {
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
    }
}
</script>

<style scoped></style>