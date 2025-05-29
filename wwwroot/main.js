window.scrollToElement = (elementId) => {
    document.getElementById(elementId)?.scrollIntoView({ behavior: 'smooth' });
};