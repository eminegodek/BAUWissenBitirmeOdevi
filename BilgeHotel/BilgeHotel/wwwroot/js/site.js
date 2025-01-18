// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('mousemove', (e) => {
    const sparkle = document.createElement('div');
    sparkle.classList.add('sparkle');
    sparkle.style.left = `${e.pageX - 5}px`;
    sparkle.style.top = `${e.pageY - 5}px`;

    document.body.appendChild(sparkle);

    setTimeout(() => {
        sparkle.remove();
    }, 1000);
});
//

    document.getElementById("contactForm").addEventListener("submit", function (e) {
        e.preventDefault();

    const formData = new FormData(this);

    fetch('/Contact/SaveMessage', {
        method: 'POST',
    body: new URLSearchParams(formData)
        })
        .then(response => response.json())
        .then(data => {
        alert(data.message);
        })
        .catch(error => {
        alert("Bir hata oluştu. Lütfen tekrar deneyiniz.");
        });
    });




