document.addEventListener("DOMContentLoaded", function() {
    // Sayaç işlevselliği
    const counterDisplay = document.querySelector(".counter-div .count");
    document.querySelector(".counter-div .add").addEventListener("click", function() {
        counterDisplay.textContent = parseInt(counterDisplay.textContent) + 1;
    });
    document.querySelector(".counter-div .subtract").addEventListener("click", function() {
        counterDisplay.textContent = parseInt(counterDisplay.textContent) - 1;
    });
    document.querySelector(".counter-div .reset").addEventListener("click", function() {
        counterDisplay.textContent = 0;
    });

    // Zamanlayıcı işlevselliği
    const timerDisplay = document.querySelector(".timer-div .timerdown");
    let timerInterval = null;
    document.querySelector(".timer-div .start").addEventListener("click", function() {
        if (timerInterval === null) {
            let timeLeft = parseInt(timerDisplay.textContent);
            timerInterval = setInterval(function() {
                timeLeft--;
                timerDisplay.textContent = timeLeft;
                if (timeLeft <= 0) {
                    clearInterval(timerInterval);
                    timerInterval = null;
                }
            }, 1000);
        }
    });
    document.querySelector(".timer-div .stop").addEventListener("click", function() {
        if (timerInterval !== null) {
            clearInterval(timerInterval);
            timerInterval = null;
        }
    });
    document.querySelector(".timer-div .reset").addEventListener("click", function() {
        if (timerInterval !== null) {
            clearInterval(timerInterval);
            timerInterval = null;
        }
        timerDisplay.textContent = 60;
    });
});
