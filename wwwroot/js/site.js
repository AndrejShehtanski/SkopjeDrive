document.addEventListener('DOMContentLoaded', function () {
    var consent = localStorage.getItem('skopjedrive_cookie_consent');
    var banner = document.getElementById('cookie-banner');

    if (!consent && banner) {
        banner.style.display = 'flex';
    }

    var btn = document.getElementById('cookie-accept-btn');
    if (btn) {
        btn.addEventListener('click', function () {
            localStorage.setItem('skopjedrive_cookie_consent', 'true');
            document.cookie = 'skopjedrive_cookie_consent=true; max-age=' + (60 * 60 * 24 * 365) + '; path=/';
            if (banner) {
                banner.style.display = 'none';
            }
        });
    }
});
