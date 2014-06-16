var slides = [
    '<img src="imgs/Fallen.jpeg" />',
    '<img src="imgs/demon_monster.jpg" />',
    '<img src="imgs/Demon-Face.jpg" />',
    '<img src="imgs/Demon-Dracula.jpg" />'
],
    $slider = $('<div>').attr('id', 'slider').appendTo('body'),
    $current = $('<div>').attr('id', 'currentEl').appendTo($slider),
    $prev = $('<button>').text('prev').attr('id','prev').appendTo($slider),
    $next = $('<button>').text('next').attr('id', 'next').appendTo($slider),
    currentIndex = 0;
    generateCurrentSlide();
    startTimer();

    $('#prev').on('click', previousSlide);
    $('#next').on('click', nextSlide);

    function generateCurrentSlide() {
        $current.html(slides[currentIndex]);
    }

    function previousSlide() {
        currentIndex--;
        console.log(currentIndex);
        if(currentIndex === -1) {
            currentIndex = slides.length - 1;
        }

        generateCurrentSlide();
        startTimer();
    }

    function nextSlide(){
        currentIndex++;
        console.log(currentIndex);
        if(currentIndex === slides.length) {
            currentIndex = 0;
        }

        generateCurrentSlide();
        startTimer();
    }

    function startTimer() {
        clearInterval(SlideChanger);
        var SlideChanger = setInterval(nextSlide, 5000);
    }