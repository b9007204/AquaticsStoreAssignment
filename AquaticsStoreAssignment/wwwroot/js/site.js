// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function imageGallery() {
    const highlight = document.querySelector('.Gallery-Highlight');
    const previews = document.querySelectorAll('.Image-Preview img');

    previews.forEach(preview => {
        preview.addEventListener('click', function () {
            const smallSrc = this.src;
            const bigSrc = smallSrc.replace("small", "big");
            highlight.src = bigSrc;

            
        });
    });
}

imageGallery();

window.onload = () => {
    const transition_el = document.querySelector('.transition');

    const anchor = document.querySelectorAll('a');

    setTimeout(() => {
        transition_el.classList.remove('is-active');
    }, 500);

    for (let i = 0; i < anchor.length; i++) {
        const anchor = anchor[i];

        anchor.addEventListener('click', e => {
            e.preventDefault();
            let target = e.target.href;

            transition_el.classList.add('is-active');

            setTimeout(() => {
                window.location.href = target;
            }, 500);
        });
    }
}


