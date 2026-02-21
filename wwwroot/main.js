window.scrollToElement = (elementId) => {
    document.getElementById(elementId)?.scrollIntoView({ behavior: 'smooth' });
};

window.observeElementOnce = (elementId, className) => {
    const element = document.getElementById(elementId);

    if (element) {
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    element.classList.add(className);
                    observer.unobserve(element);
                }
            });
        }, {
            threshold: 0.3
        });

        observer.observe(element);
    }
};

window.downloadFile = (url, filename) => {
    const link = document.createElement('a');
    link.href = url;
    if (filename) link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
