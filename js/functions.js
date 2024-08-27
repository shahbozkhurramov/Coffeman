function scrollIntoViewById(id) {
    const element = document.getElementById(id);

    if (element instanceof HTMLElement) {
        element.scrollIntoView({
            behavior: "smooth",
            block: "center",
            inline: "nearest"
        });
    }
}