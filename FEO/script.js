// swiper.js
// Demo:
//  https://codepen.io/dannyb/pen/mVZbar
// alert("nice");

// var mySwiper = new Swiper(".swiper-container", {
//   speed: 400,
//   spaceBetween: 100,
//   initialSlide: 0,
//   //truewrapper adoptsheight of active slide
//   autoHeight: false,
//   // Optional parameters
//   direction: "horizontal",
//   loop: true,
//   // delay between transitions in ms
//   autoplay: 5000,
//   autoplayStopOnLast: false, // loop false also
//   // If we need pagination
//   pagination: ".swiper-pagination",
//   paginationType: "bullets",

//   // Navigation arrows
//   nextButton: ".swiper-button-next",
//   prevButton: ".swiper-button-prev",

//   // And if we need scrollbar
//   //scrollbar: '.swiper-scrollbar',
//   // "slide", "fade", "cube", "coverflow" or "flip"
//   effect: "slide",
//   // Distance between slides in px.
//   spaceBetween: 60,
//   //
//   slidesPerView: 2,
//   //
//   centeredSlides: true,
//   //
//   slidesOffsetBefore: 0,
//   //
//   grabCursor: true,
// });
// alert("nice");
// let body = document.getElementById();

var swiper = document.getElementById("swiper");
var template = document.getElementById("product-template");
var slide = document.getElementById("slide");

var nice = template.content;
console.log("nice: ", nice);
for(let i = 0;i<=10;i++){

    swiper.appendChild(slide.cloneNode(true));
    console.log(swiper);
}
// slide.appendChild(document.createElement("<p>htueo</p>"));
// for (let i = 0; i <= 5; i++) {
//   body.appendChild(slide);
// }
