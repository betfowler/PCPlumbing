$(document).ready(function () {

    var winHeight = $(window).height() - 235;
    $("body").css("height", winHeight);

    $("#galleryImg img").mouseover(function () {
        $(this).css("cursor", "pointer");
    })

    //**HOMEPAGE ICON AND TEXT SET WHEN MOUSEOVER CHANGE ALL BACK TO ORIGINAL**//
    $(".row .col-md-2 img").mouseover(function () {
        //plumbing
        $("#plumb img").attr("src", "../Content/Images/Plumbing.png");
        $("#plumbArr .arrow-up").css("border-bottom", "50px solid white");
        //central heating
        $("#centH img").attr("src", "../Content/Images/Symbols.png");
        $("#centHArr .arrow-up").css("border-bottom", "50px solid white");
        //boiler
        $("#boiler img").attr("src", "../Content/Images/Boiler.png");
        $("#boilerArr .arrow-up").css("border-bottom", "50px solid white");
        //bathroom
        $("#bath img").attr("src", "../Content/Images/Bathroom.png");
        $("#bathArr .arrow-up").css("border-bottom", "50px solid white");
        //renewable
        $("#renew img").attr("src", "../Content/Images/Renewable.png");
        $("#renewArr .arrow-up").css("border-bottom", "50px solid white");
        //contact
        $("#contact img").attr("src", "../Content/Images/Contact.png");
        $("#contactArr .arrow-up").css("border-bottom", "50px solid white");
    })

    //**HOMEPAGE ICONS MOUSEOVER: IMAGE AND TEXT CHANGE**//
    //plumbing #1
    $("#plumb img").mouseover(function () {
        $(this).attr("src", "../Content/Images/PlumbingAct.png")
        $(".desc").css("border-color", "#408080")
        $("#plumbArr .arrow-up").css("border-bottom", "50px solid #408080")
        $(".desc h1").text("Plumbing")
        $(".desc h3").text("Alongside central heating repairs and installation, we can also take care of all other plumbing jobs around the home.")
    })

    //central heating #2
    $("#centH img").mouseover(function () {
        $(this).attr("src", "../Content/Images/CentAct.png")
        $(".desc").css("border-color", "#ed7d31")
        $("#centHArr .arrow-up").css("border-bottom", "50px solid #ed7d31");
        $(".desc h1").text("Central Heating")
        $(".desc h3").text("Has a radiator in your home stopped working?  Perhaps you need a central heating system installed in your new build?")
    })

    //boiler #3
    $("#boiler img").mouseover(function () {
        $(this).attr("src", "../Content/Images/BoilerAct.png")
        $(".desc").css("border-color", "#7030a0")
        $("#boilerArr .arrow-up").css("border-bottom", "50px solid #7030a0");
        $(".desc h1").text("Boilers")
        $(".desc h3").text("We can install, repair and service all types of domestic boilers, from Worcester and Vaillant condensing combi boilers to Grant external oil boilers.")
    })

    //bathroom #4
    $("#bath img").mouseover(function () {
        $(this).attr("src", "../Content/Images/BathAct.png")
        $(".desc").css("border-color", "#00c4c4")
        $("#bathArr .arrow-up").css("border-bottom", "50px solid #00c4c4");
        $(".desc h1").text("Bathrooms")
        $(".desc h3").text("Fed up with your old bathroom?  We will work with you from start to finish to ensure you get the bathroom you've been longing for.")
    })

    //renewable #5
    $("#renew img").mouseover(function () {
        $(this).attr("src", "../Content/Images/RenewableAct.png")
        $(".desc").css("border-color", "#45a842")
        $("#renewArr .arrow-up").css("border-bottom", "50px solid #45a842")
        $(".desc h1").text("Renewable Energy")
        $(".desc h3").text("Thinking of switching to renewable heating?  You can put your trust in us to help you save money on your energy bills by switching to renewable energy.")
    })

    //contact #6
    $("#contact img").mouseover(function () {
        $(this).attr("src", "../Content/Images/ContactAct.png")
        $(".desc").css("border-color", "#5b9bd5")
        $("#contactArr .arrow-up").css("border-bottom", "50px solid #5b9bd5")
        $(".desc h1").text("Contact Us")
        $(".desc h3").text("For a free quote or for more information regarding our quality plumbing and heating services, please contact us.")
    })


    //**SOCIAL MEDIA ICONS**//
    $("#socialMedia #facebook").mouseover(function () {
        $(this).css("color", "#3B5998")
    })
    $("#socialMedia #facebook").mouseout(function () {
        $(this).css("color", "#333")
    })

    $("#socialMedia #twitter").mouseover(function () {
        $(this).css("color", "#1DA1F2")
    })
    $("#socialMedia #twitter").mouseout(function () {
        $(this).css("color", "#333")
    })

    $("#socialMedia #google").mouseover(function () {
        $(this).css("color", "#DD4B39")
    })
    $("#socialMedia #google").mouseout(function () {
        $(this).css("color", "#333")
    })

})