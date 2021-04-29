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



