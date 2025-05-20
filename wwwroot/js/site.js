const darkModeSwitch = document.getElementById('darkModeSwitch');

function setTheme(theme) {
    document.body.setAttribute('data-theme', theme);
    localStorage.setItem('theme', theme); // Uložení preferovaného tématu do localStorage
}

if (darkModeSwitch) { // Kontrola, zda prvek existuje na stránce
    darkModeSwitch.addEventListener('change', () => {
        if (darkModeSwitch.checked) {
            setTheme('dark');
        } else {
            setTheme(null); // Nebo 'light', pokud chceš explicitní světlý režim
        }
    });

    // Při načtení stránky zkontroluj uložené téma
    const savedTheme = localStorage.getItem('theme');
    if (savedTheme === 'dark') {
        setTheme('dark');
        darkModeSwitch.checked = true;
    } else if (savedTheme) { // Pokud je uložené jiné téma (např. 'light')
        setTheme(savedTheme);
        darkModeSwitch.checked = (savedTheme === 'dark');
    }
}