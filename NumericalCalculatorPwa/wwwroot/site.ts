let deferredPrompt;

window.addEventListener('beforeinstallprompt', (e) => {
    // Prevent the mini-infobar from appearing on mobile
    e.preventDefault();

    deferredPrompt = e;

    // Show the install promotion to the user
    showInstallPromotion();
});

function showInstallPromotion() {
    document.getElementById('installButton').style.display = 'block';
}

document.getElementById('installButton').addEventListener('click', (e) => {
    // Hide the button as the install process is underway
    document.getElementById('installButton').style.display = 'none';

    // Trigger the beforeinstallprompt event
    if (deferredPrompt) {
        deferredPrompt.prompt();

        deferredPrompt.userChoice.then(choiceResult => {
            if (choiceResult.outcome === 'accepted')
                console.log('App was installed');
            else
                console.log('App installation was declined');

            deferredPrompt = null;
        });
    }
});