//rollover to show before image
function showBefore(beforeImgSource, imgID) {
    $("#" + imgID).attr("src", "../Content/Images/Gallery/" + beforeImgSource);
}

function showAfter(imgSource, imgID) {
    $("#" + imgID).attr("src", "../Content/Images/Gallery/" + imgSource);
}


var slideIndex;
var numSlides;
function openModal(imgSource, imgBeforeSource, index, noSlides, title) {
    var winHeight = $(window).height() - 235;
    var winWidth = $(window).width() - 200;
    $("#galleryModal").css("display", "block");

    if (imgSource != imgBeforeSource) {
        $("#beforeAfterSlides").css("display", "block");
        $("#beforeImg").attr("src", "../Content/Images/Gallery/" + imgBeforeSource);
        $("#afterImg").attr("src", "../Content/Images/Gallery/" + imgSource);


        if (winWidth > 800) {
            var halfWidth = winWidth / 2;
            $("#beforeAfterSlides img").css("width", halfWidth);
            var height = $("#beforeAfterSlides img").height();
            $("#beforeAfterSlides img").css("max-height", height);
            $(".modal-content").css({ "height": height, "width": winWidth });
        }
        else {
            var halfHeight = winHeight / 2;
            $("#beforeAfterSlides img").css("height", halfHeight);
            var width = $("#beforeAfterSlides img").width();
            $("#beforeAfterSlide img").css("max-width", width);
            $(".modal-content").css({ "height": winHeight, "width": width });
        }
    }
    else {
        $("#mySlides img").css("height", winHeight);
        $("#mySlides").css("display", "block");
        $("#largeImg").attr("src", "../Content/Images/Gallery/" + imgSource);
        var imgWidth = $("#mySlides img").width();
        $(".modal-content").css({ "height": winHeight, "width": imgWidth });
    }

    //title and description
    slideIndex = index;
    numSlides = noSlides;
}

function closeModal() {
    $("#mySlides").css("display", "none");
    $("#beforeAfterSlides").css("display", "none");
    $("#galleryModal").css("display", "none");
}

function showSlides(n) {
    var i;
   
    //if reached the end of the loop return to the beginning
    if (n > numSlides) {
        slideIndex = 1
    }

    if (n < 1) {
        slideIndex = numSlides
    }

    //get image path
    var nextDetails = $("#" + slideIndex).attr("onclick");
    nextDetails = nextDetails.substr(10).replace(/\'/g, '');
    nextDetails = nextDetails.replace(/\)/g, '');
    nextDetails = nextDetails.replace(/\ /g, '');
    var values = nextDetails.split(',');
    
    openModal(values[0], values[1], values[2], values[3], values[4]);

}

function plusSlides(n) {
    slideIndex = parseInt(slideIndex) + n;
    showSlides(slideIndex);
}
