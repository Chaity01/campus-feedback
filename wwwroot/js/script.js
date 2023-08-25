function submitAll() {

    var str = window.location.href;
    var n = str.lastIndexOf('/');
    const id = str.substring(n + 1);

    var feedbacks = [];

    var carouselItems = document.getElementsByClassName("carousel-item");

    for (var i = 0; i < carouselItems.length; i++){

        var carouselItem = carouselItems[i];


        var radioItems = carouselItem.getElementsByTagName("input");
        var radioValue = 0;
        for(var j = 0; j < radioItems.length; j++){
            var radioItem = radioItems[j];
            if(radioItem.checked == true){
                radioValue = radioItem.value;
            }
        }

        var feedback = {
            "studentId": Number(id),
            "questionId": Number(carouselItem.getElementsByClassName("title")[0].dataset.id),
            "value": radioValue
        }

        feedbacks.push(feedback);
    }

    console.log(feedbacks);

    var http = new XMLHttpRequest();
    var url = 'http://localhost:8888/api/questions';
    http.open('POST', url, true);

    http.setRequestHeader('Content-type', 'application/json;charset=utf-8');

    http.onreadystatechange = function () {
        if (http.readyState == 4 && http.status == 200) {
            window.location.href = "http://localhost:8888/app/SurveyComplete"
        }
    }
    http.send(JSON.stringify(feedbacks));

}

var myCarousel = $('#question-carousel');
var itemFirst = myCarousel.find('.carousel-inner > .carousel-item:first');
var itemLast = myCarousel.find('.carousel-inner > .carousel-item.final');
var controlLeft = myCarousel.find('button.previous');
var controlRight = myCarousel.find('button.next');
var controlSubmit = myCarousel.find('button.submit-button');
controlSubmit.css("display", "none");

hideControl();

myCarousel.on('slid.bs.carousel', function () {
    hideControl();
});
myCarousel.on('slide.bs.carousel', function () {
    showControl();
});

function hideControl() {
    if (itemFirst.hasClass('active')) {
        controlLeft.css('display', 'none');
    }
    if (itemLast.hasClass('active')) {
        controlRight.css('display', 'none');
        myCarousel.carousel('pause');
    }
}

function showControl() {
    if (itemFirst.hasClass('active')) {
        controlLeft.css('display', 'block');
    }
    if (itemLast.hasClass('active')) {
        controlRight.css('display', 'block');
    }
}

function showSubmit() {
    let selectedRadio = 0;
    let carouselItems = document.getElementsByClassName("carousel-item").length;
    var radioItems = document.getElementsByTagName("input");
    for (var j = 0; j < radioItems.length; j++) {
        var radioItem = radioItems[j];
        if (radioItem.checked == true) {
            selectedRadio++;
        }
    }

    if (selectedRadio == carouselItems) {
        controlSubmit.css("display", "block");
    } else {
        controlSubmit.css("display", "none");
    }

}