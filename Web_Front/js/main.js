
$(document).ready(function () {

    // Window Load
    $(window).load(function () {
        $('header').height($(window).height() - 200);
        $('section .cut').each(function () {
            if ($(this).hasClass('cut-top'))
                $(this).css('border-right-width', $(this).parent().width() + "px");
            else if ($(this).hasClass('cut-bottom'))
                $(this).css('border-left-width', $(this).parent().width() + "px");
        });
        // Typing Intro Init
        $(".typed").typewriter({
            speed: 60
        });

    });


    // nav shield on scroll --------------------------------------->>
    $("#Whitted_nav").hide();
    $(".overlay-bg").hover(function () {

        $("#Whitted_nav").show(1888);



    });


    // BRING THE CANVAS ------------------------------------------->>
    $("#drawingCtrl").hide(0);

    $('#paintBrushButton').mouseenter(function () {
        $('figcaption').fadeOut(1000);
    });

    $('#paintBrushButton').on('click',
        function () {
            $('#intro').animate({
                left: '-1200px'
            }, '1000', function () {
                $(this).hide(2000)
            });
            $('#paintingKid').fadeOut(1000);
            $('#myCanvas').css('border-color', '#ff6a00')
            InitThis();
            $("#drawingCtrl").show(2000);
        }
    );

    $('#clearArea').on('click',
        function () {
            clearArea();
        }
    );

    // CANVAS DRAWING ----------------------------------------------->>
    var mousePressed = false;
    var lastX, lastY;
    var ctx;

    function InitThis() {
        ctx = document.getElementById('myCanvas').getContext("2d");

        $('#myCanvas').mousedown(function (e) {
            mousePressed = true;
            Draw(e.pageX - $(this).offset().left, e.pageY - $(this).offset().top, false);
        });

        $('#myCanvas').mousemove(function (e) {
            if (mousePressed) {
                Draw(e.pageX - $(this).offset().left, e.pageY - $(this).offset().top, true);
            }
        });

        $('#myCanvas').mouseup(function (e) {
            mousePressed = false;
        });
        $('#myCanvas').mouseleave(function (e) {
            mousePressed = false;
        });
    }

    function Draw(x, y, isDown) {
        if (isDown) {
            ctx.beginPath();
            ctx.strokeStyle = $('#selColor').val();
            ctx.lineWidth = $('#selWidth').val();
            ctx.lineJoin = "round";
            ctx.moveTo(lastX, lastY);
            ctx.lineTo(x, y);
            ctx.closePath();
            ctx.stroke();
        }
        lastX = x; lastY = y;
    }

    function clearArea() {
        // Use the identity matrix while clearing the canvas
        ctx.setTransform(1, 0, 0, 1, 0, 0);
        ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
    }
    //--------------------------------------------------------------------<<



    "use strict";

    var window_width = $(window).width(),
        window_height = window.innerHeight,
        header_height = $(".default-header").height(),
        header_height_static = $(".site-header.static").outerHeight(),
        fitscreen = window_height - header_height;


    $(".fullscreen").css("height", window_height)
    $(".fitscreen").css("height", fitscreen);


    // -------   Active Mobile Menu-----//

    $(".menu-bar").on('click', function (e) {
        e.preventDefault();
        $("nav").toggleClass('hide');
        $("span", this).toggleClass("lnr-menu lnr-cross");
        $(".main-menu").addClass('mobile-menu');
    });

    $('select').niceSelect();
    $('.img-pop-up').magnificPopup({
        type: 'image',
        gallery: {
            enabled: true
        }
    });

    //  Counter Js 

    $('.counter').counterUp({
        delay: 10,
        time: 1000
    });

    $(document).ready(function () {
        $('#mc_embed_signup').find('form').ajaxChimp();
    });
    // -------   Mail Send ajax

    $(document).ready(function () {


        // Video lightbox

        $('.play-btn').magnificPopup({
            disableOn: 700,
            type: 'iframe',
            mainClass: 'mfp-fade',
            removalDelay: 160,
            preloader: false,
            fixedContentPos: false
        });


        //  testimonail carusel

        $('.active-bottle-carousel').owlCarousel({
            items: 1,
            loop: true,
            nav: false,
            autoplay: true,
            autoplayTimeout: 3000,
            autoplayHoverPause: true
        });

        var form = $('#myForm'); // contact form
        var submit = $('.submit-btn'); // submit button
        var alert = $('.alert-msg'); // alert div for show alert message

        // form submit event
        form.on('submit', function (e) {
            e.preventDefault(); // prevent default form submit

            $.ajax({
                url: 'mail.php', // form action url
                type: 'POST', // form submit method get/post
                dataType: 'html', // request type html/json/xml
                data: form.serialize(), // serialize form data
                beforeSend: function () {
                    alert.fadeOut();
                    submit.html('Sending....'); // change submit button text
                },
                success: function (data) {
                    alert.html(data).fadeIn(); // fade in response data
                    form.trigger('reset'); // reset form
                    submit.attr("style", "display: none !important");; // reset submit button text
                },
                error: function (e) {
                    console.log(e)
                }
            });
        });
    });


    //Little Prallaxing ----------------------------------------------->>
    var timeout;
    $('#p_container').mousemove(function (e) {
        if (timeout) clearTimeout(timeout);
        setTimeout(callParallax.bind(null, e), 200);

    });

    function callParallax(e) {
        parallaxIt(e, '#slideone', 20);
        parallaxIt(e, '#slidetwo', 40);
        parallaxIt(e, '#slidethree', 50);
        parallaxIt(e, '#slidefour', 60);
        parallaxIt(e, '#slidefive', 70);
        parallaxIt(e, '.p_child', 20);
    }

    function parallaxIt(e, target, movement) {
        var $this = $('#p_container');
        var relX = e.pageX - $this.offset().left;
        var relY = e.pageY - $this.offset().top;

        TweenMax.to(target, 1, {
            x: (relX - $this.width() / 2) / $this.width() * movement,
            y: (relY - $this.height() / 2) / $this.height() * movement,
            ease: Power2.easeOut
        })
    }







});
