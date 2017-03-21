//rollover to show before image
function showBefore(beforeImgSource, imgID) {
    var length = beforeImgSource.length;
    var removelength = "contentimagesgallery".length;
    beforeImgSource = beforeImgSource.substring(removelength, length)
    $("#" + imgID).attr("src", "../Content/Images/Gallery/" + beforeImgSource);
}

function showAfter(imgSource, imgID) {
    var length = imgSource.length;
    var removelength = "contentimagesgallery".length;
    imgSource = imgSource.substring(removelength, length)
    $("#" + imgID).attr("src", "../Content/Images/Gallery/" + imgSource);
}


var slideIndex;
var numSlides;
function openModal(imgSource, imgBeforeSource, index, noSlides, title) {
    var winHeight = $(window).height() - 235;
    $("#mySlides img").css("height", winHeight);
    $("#galleryModal").css("display", "block");

    //get image name and see if before image is different
    var length = imgSource.length;
    var removelength = "contentimagesgallery".length;
    imgSource = imgSource.substring(removelength, length);
    imgBeforeSource = imgBeforeSource.substring(removelength, length);

    if (imgSource != imgBeforeSource) {
        $("#beforeAfterSlides").css("display", "block");
        $("#beforeImg").attr("src", "../Content/Images/Gallery/" + imgBeforeSource);
        $("#afterImg").attr("src", "../Content/Images/Gallery/" + imgSource);
    }
    else {
        $("#mySlides").css("display", "block");
        $("#largeImg").attr("src", "../Content/Images/Gallery/" + imgSource);
    }

    //get image title


    //get image width
    var imgWidth = $("#mySlides img").width();
    $(".modal-content").css({ "height": winHeight, "width": imgWidth });
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
    var path = $("#" + slideIndex).attr('src');
    $("#largeImg").attr("src", path);

    //get beforeimage path
    console.log($("#" + slideIndex));

    var winHeight = $(window).height() - 235;
    $("#mySlides img").css("height", winHeight);
    var imgWidth = $("#mySlides img").width();
    $(".modal-content").css({ "height": winHeight, "width": imgWidth });
}

function plusSlides(n) {
    $("#mySlides").css("display", "none");
    $("#beforeAfterSlides").css("display", "none");
    slideIndex = slideIndex + n;
    showSlides(slideIndex);
    
}

function currentSlide(n) {
    $("#mySlides").css("display", "none");
    $("#beforeAfterSlides").css("display", "none");
    showSlides(slideIndex = n);
}
