

function swapText(args) {
    this.items = document.querySelectorAll(args.selector),
        this.duration = args.duration,
        this.tick = 0,
        this.index = 0,
        this.last,
        this.current;

    this.main();
}
swapText.prototype.main = function () {
    requestAnimationFrame(this.main.bind(this));
    if (this.tick >= this.duration) {
        this.tick = 0;
        this.swap();
        this.render();
    }
    else {
        this.tick++;
    }
}

swapText.prototype.render = function () {
    this.current.classList.remove('hidden');
    this.last.classList.add('hidden');
}

swapText.prototype.setCurrent = function (index, lastIndex) {
    this.current = this.items[index];
    this.last = this.items[lastIndex]
}

swapText.prototype.swap = function () {
    var nextIndex = this.index + 1;
    if (this.index == this.items.length - 1) {
        this.index = 0;
        this.setCurrent(0, this.items.length - 1);
    }
    else {
        this.setCurrent(nextIndex, nextIndex - 1);
        this.index = nextIndex;
    }
}

new swapText({
    duration: 200,
    selector: '.text'
});


