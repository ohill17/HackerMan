const letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

function applyTextEffect(event) {
    let iteration = 0;
    const element = event.target;
    let interval = null; // Define interval inside the function to keep it element-specific

    // Store the original text in a data attribute if not already set
    if (!element.dataset.value) {
        element.dataset.value = element.innerText;
    }

    clearInterval(interval); // Clear any existing interval

    interval = setInterval(() => {
        element.innerText = element.innerText
            .split("")
            .map((letter, index) => {
                if (index < iteration) {
                    return element.dataset.value[index];
                }

                return letters[Math.floor(Math.random() * 26)];
            })
            .join("");

        if (iteration >= element.dataset.value.length) {
            clearInterval(interval);
        }

        iteration += 1 / 3;
    }, 30);
}

// Apply the text effect to all `h1` and button elements
document.querySelectorAll("h1, .btn, .btn-primary").forEach(element => {
    element.onmouseover = applyTextEffect;
});
