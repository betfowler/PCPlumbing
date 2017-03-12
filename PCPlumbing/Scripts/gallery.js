var slideIndex;
var numSlides;
function openModal(imgSource, index, noSlides) {

    console.log(imgSource)
    console.log(index)
    console.log(noSlides)
    var winHeight = $(window).height() - 235;
    $("#mySlides img").css("height", winHeight);
    $("#galleryModal").css("display", "block");

    //get image path
    var length = imgSource.length;
    var removelength = "contentimagesgallery".length;
    imgSource = imgSource.substring(removelength, length)
    $("#largeImg").attr("src", "../Content/Images/Gallery/" + imgSource);

    //get image width
    var imgWidth = $("#mySlides img").width();
    $(".modal-content").css({ "height": winHeight, "width": imgWidth });
    slideIndex = index;
    numSlides = noSlides;
}

function closeModal() {
    $("#galleryModal").css("display", "none");
}

function showSlides(n) {
    var i;
    
    //if back to beginning
    if (n > numSlides) {
        slideIndex = 1
    }

    if (n < 1) {
        slideIndex = numSlides
    }

    var path = $("#" + slideIndex).attr('src');
    $("#largeImg").attr("src", path);
    var winHeight = $(window).height() - 235;
    $("#mySlides img").css("height", winHeight);
    var imgWidth = $("#mySlides img").width();
    $(".modal-content").css({ "height": winHeight, "width": imgWidth });
}

function plusSlides(n) {
    console.log(n)
    slideIndex = slideIndex + n;
    showSlides(slideIndex);
    
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}
