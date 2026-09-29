namespace SkopjeDrive.Helpers
{
    // Very small translation dictionary used to demonstrate multilingual
    // support (EN / MK) without adding full resx-based localization.
    public static class Translator
    {
        private static readonly Dictionary<string, Dictionary<string, string>> Texts = new()
        {
            ["NavHome"] = new() { ["en"] = "Home", ["mk"] = "Почетна" },
            ["NavAbout"] = new() { ["en"] = "About Us", ["mk"] = "За нас" },
            ["NavServices"] = new() { ["en"] = "Fleet & Services", ["mk"] = "Возен парк" },
            ["NavTeam"] = new() { ["en"] = "Our Team", ["mk"] = "Тим" },
            ["NavNews"] = new() { ["en"] = "News", ["mk"] = "Вести" },
            ["NavContact"] = new() { ["en"] = "Contact", ["mk"] = "Контакт" },
            ["HeroTitle"] = new() { ["en"] = "Rent a car in Skopje, the easy way", ["mk"] = "Изнајмете автомобил во Скопје, лесно и брзо" },
            ["HeroSubtitle"] = new() { ["en"] = "Modern fleet, fair prices, no hidden fees.", ["mk"] = "Модерен возен парк, фер цени, без скриени трошоци." },
            ["BookNow"] = new() { ["en"] = "Book Now", ["mk"] = "Резервирај сега" },
            ["ViewFleet"] = new() { ["en"] = "View Fleet", ["mk"] = "Погледни го возниот парк" },
            ["FooterRights"] = new() { ["en"] = "All rights reserved.", ["mk"] = "Сите права се задржани." },
            ["CookieMessage"] = new() { ["en"] = "We use cookies to improve your experience on SkopjeDrive. By continuing to browse, you agree to our use of cookies.", ["mk"] = "Користиме колачиња за да го подобриме вашето искуство. Со понатамошно прегледување се согласувате со нивната употреба." },
            ["Accept"] = new() { ["en"] = "Accept", ["mk"] = "Прифати" },
            ["CookiePolicy"] = new() { ["en"] = "Cookie Policy", ["mk"] = "Политика за колачиња" },

            // Home page
            ["FeaturedCars"] = new() { ["en"] = "Featured cars", ["mk"] = "Избрани возила" },
            ["WhyChooseUs"] = new() { ["en"] = "Why choose SkopjeDrive?", ["mk"] = "Зошто да изберете SkopjeDrive?" },
            ["WhyChooseSubtitle"] = new() { ["en"] = "Everything you'd want from a rental partner, nothing you wouldn't.", ["mk"] = "Сè што би сакале од партнер за изнајмување, ништо непотребно." },
            ["Feature1Icon"] = new() { ["en"] = "✔️", ["mk"] = "✔️" },
            ["Feature1Title"] = new() { ["en"] = "No hidden fees", ["mk"] = "Без скриени трошоци" },
            ["Feature1Desc"] = new() { ["en"] = "The price you see is the price you pay.", ["mk"] = "Цената што ја гледате е цената што ја плаќате." },
            ["Feature2Icon"] = new() { ["en"] = "🕒", ["mk"] = "🕒" },
            ["Feature2Title"] = new() { ["en"] = "24/7 support", ["mk"] = "Поддршка 24/7" },
            ["Feature2Desc"] = new() { ["en"] = "Our team is available around the clock.", ["mk"] = "Нашиот тим е достапен во секое време." },
            ["Feature3Icon"] = new() { ["en"] = "📍", ["mk"] = "📍" },
            ["Feature3Title"] = new() { ["en"] = "Central & airport pick-up", ["mk"] = "Преземање во центар и на аеродром" },
            ["Feature3Desc"] = new() { ["en"] = "Pick up your car downtown or at the airport.", ["mk"] = "Преземете го автомобилот во центарот или на аеродромот." },
            ["Feature4Icon"] = new() { ["en"] = "🧼", ["mk"] = "🧼" },
            ["Feature4Title"] = new() { ["en"] = "Clean & serviced fleet", ["mk"] = "Чист и сервисиран возен парк" },
            ["Feature4Desc"] = new() { ["en"] = "Every car is inspected and cleaned before rental.", ["mk"] = "Секој автомобил е проверен и исчистен пред изнајмување." },

            // Car card shared text
            ["SeatsLabel"] = new() { ["en"] = "seats", ["mk"] = "седишта" },
            ["PerDay"] = new() { ["en"] = "day", ["mk"] = "ден" },
            ["CatCompact"] = new() { ["en"] = "Compact", ["mk"] = "Компактен" },
            ["CatSedan"] = new() { ["en"] = "Sedan", ["mk"] = "Седан" },
            ["CatEconomy"] = new() { ["en"] = "Economy", ["mk"] = "Економичен" },
            ["CatPremium"] = new() { ["en"] = "Premium", ["mk"] = "Премиум" },
            ["CatVan"] = new() { ["en"] = "Van", ["mk"] = "Комбе" },
            ["TransManual"] = new() { ["en"] = "Manual", ["mk"] = "Рачен менувач" },
            ["TransAutomatic"] = new() { ["en"] = "Automatic", ["mk"] = "Автоматски менувач" },

            // Services page
            ["ServicesTitle"] = new() { ["en"] = "Our Fleet & Services", ["mk"] = "Нашиот возен парк и услуги" },
            ["ServicesIntro"] = new() { ["en"] = "Choose from our range of well-maintained vehicles, available for daily, weekly or monthly rental.", ["mk"] = "Изберете од нашата понуда на добро одржувани возила, достапни за дневно, неделно или месечно изнајмување." },
            ["Reserve"] = new() { ["en"] = "Reserve", ["mk"] = "Резервирај" },
            ["AdditionalServices"] = new() { ["en"] = "Additional services", ["mk"] = "Дополнителни услуги" },
            ["Service1"] = new() { ["en"] = "🛫 Airport pick-up & drop-off", ["mk"] = "🛫 Превземање и враќање на аеродром" },
            ["Service2"] = new() { ["en"] = "🧑‍✈️ Chauffeur service on request", ["mk"] = "🧑‍✈️ Услуга со возач по барање" },
            ["Service3"] = new() { ["en"] = "🛡️ Full & partial insurance packages", ["mk"] = "🛡️ Целосно и делумно осигурување" },
            ["Service4"] = new() { ["en"] = "👶 Child seat rental", ["mk"] = "👶 Изнајмување детско седиште" },
            ["Service5"] = new() { ["en"] = "📶 GPS navigation rental", ["mk"] = "📶 Изнајмување GPS навигација" },

            // Team page
            ["TeamHeading"] = new() { ["en"] = "Meet the Team", ["mk"] = "Запознајте го тимот" },
            ["TeamRole1"] = new() { ["en"] = "Founder & CEO", ["mk"] = "Основач и извршен директор" },
            ["TeamBio1"] = new() { ["en"] = "Started SkopjeDrive in 2025 with a small fleet of 2 cars and a big idea.", ["mk"] = "Ја основа SkopjeDrive во 2025 година со мал возен парк од 2 автомобили и голема идеја." },
            ["TeamRole2"] = new() { ["en"] = "Operations Manager", ["mk"] = "Менаџер за операции" },
            ["TeamBio2"] = new() { ["en"] = "Keeps the fleet running and every booking on schedule.", ["mk"] = "Се грижи возниот парк функционира и секоја резервација да биде навремена." },
            ["TeamRole3"] = new() { ["en"] = "Customer Support Lead", ["mk"] = "Раководител на корисничка поддршка" },
            ["TeamBio3"] = new() { ["en"] = "Makes sure every customer gets a fast reply and a smooth rental.", ["mk"] = "Се грижи секој клиент да добие брз одговор и непречено изнајмување." },
            ["TeamRole4"] = new() { ["en"] = "Fleet Maintenance", ["mk"] = "Одржување на возниот парк" },
            ["TeamBio4"] = new() { ["en"] = "Keeps every vehicle clean, safe and ready to go.", ["mk"] = "Се грижи секое возило да биде чисто, безбедно и подготвено за возење." },

            // About page
            ["AboutHeading"] = new() { ["en"] = "About SkopjeDrive", ["mk"] = "За SkopjeDrive" },
            ["AboutP1"] = new() { ["en"] = "SkopjeDrive was founded in 2025 in Skopje, North Macedonia, with a single goal: make renting a car simple, affordable and stress-free.", ["mk"] = "SkopjeDrive е основан во 2025 година во Скопје, Северна Македонија, со една цел: изнајмувањето автомобил да биде едноставно, поволно и без стрес." },
            ["AboutP2"] = new() { ["en"] = "Today we operate a fleet of over 20 vehicles, ranging from economy cars to premium sedans and passenger vans, serving both local customers and tourists arriving through Skopje International Airport.", ["mk"] = "Денес располагаме со возен парк од над 20 возила, од економични автомобили до премиум седани и комбиња за патници, и ги услужуваме и локалните клиенти и туристите што пристигнуваат преку Меѓународниот аеродром Скопје." },
            ["AboutMissionHeading"] = new() { ["en"] = "Our mission", ["mk"] = "Нашата мисија" },
            ["AboutMissionText"] = new() { ["en"] = "To give every customer a reliable car and a smooth rental experience, from booking to return.", ["mk"] = "На секој клиент да му обезбедиме сигурен автомобил и непречено искуство при изнајмување, од резервацијата до враќањето." },
            ["AboutAreaHeading"] = new() { ["en"] = "Service area", ["mk"] = "Подрачје на услуга" },
            ["AboutAreaText"] = new() { ["en"] = "We operate throughout Skopje and offer delivery to Skopje International Airport \"Alexander the Great\" and other major cities in North Macedonia on request.", ["mk"] = "Работиме низ цело Скопје и, по барање, нудиме достава до Меѓународниот аеродром Скопје „Александар Велики“ и до други поголеми градови во Северна Македонија." },

            // Contact page
            ["ContactTitle"] = new() { ["en"] = "Contact Us", ["mk"] = "Контактирајте нè" },
            ["ContactSuccess"] = new() { ["en"] = "Thanks! Your message has been sent — we'll get back to you soon.", ["mk"] = "Ви благодариме! Вашата порака е испратена — ќе ви одговориме наскоро." },
            ["ContactFullName"] = new() { ["en"] = "Full name", ["mk"] = "Име и презиме" },
            ["ContactEmail"] = new() { ["en"] = "Email", ["mk"] = "Е-пошта" },
            ["ContactPhone"] = new() { ["en"] = "Phone (optional)", ["mk"] = "Телефон (незадолжително)" },
            ["ContactMessage"] = new() { ["en"] = "Message", ["mk"] = "Порака" },
            ["ContactSend"] = new() { ["en"] = "Send Message", ["mk"] = "Испрати порака" },
            ["ContactInformation"] = new() { ["en"] = "Contact Information", ["mk"] = "Контакт информации" },
            ["ContactAddress"] = new() { ["en"] = "Bul. Ilinden 15, 1000 Skopje, North Macedonia", ["mk"] = "Бул. Илинден 15, 1000 Скопје, Северна Македонија" },
            ["ContactHours"] = new() { ["en"] = "Mon–Sun: 08:00 – 20:00", ["mk"] = "Пон–Нед: 08:00 – 20:00" },
            ["ContactMapTitle"] = new() { ["en"] = "SkopjeDrive location map", ["mk"] = "Мапа со локацијата на SkopjeDrive" },
            ["ContactSendError"] = new() { ["en"] = "Sorry, your message could not be sent right now. Please try again later.", ["mk"] = "За жал, вашата порака не можеше да се испрати во моментов. Обидете се повторно подоцна." },
            ["ContactValidationNameRequired"] = new() { ["en"] = "Please enter your name.", ["mk"] = "Ве молиме внесете го вашето име." },
            ["ContactValidationNameLength"] = new() { ["en"] = "Your name can contain at most 100 characters.", ["mk"] = "Името може да содржи најмногу 100 знаци." },
            ["ContactValidationEmailRequired"] = new() { ["en"] = "Please enter your email.", ["mk"] = "Ве молиме внесете ја вашата е-пошта." },
            ["ContactValidationEmailInvalid"] = new() { ["en"] = "Please enter a valid email.", ["mk"] = "Ве молиме внесете валидна е-пошта." },
            ["ContactValidationPhoneInvalid"] = new() { ["en"] = "Please enter a valid phone number.", ["mk"] = "Ве молиме внесете валиден телефонски број." },
            ["ContactValidationMessageRequired"] = new() { ["en"] = "Please enter a message.", ["mk"] = "Ве молиме внесете порака." },
            ["ContactValidationMessageLength"] = new() { ["en"] = "Your message can contain at most 1000 characters.", ["mk"] = "Пораката може да содржи најмногу 1000 знаци." },

            // News pages
            ["NewsHeading"] = new() { ["en"] = "News & Blog", ["mk"] = "Вести и блог" },
            ["ReadMore"] = new() { ["en"] = "Read more →", ["mk"] = "Прочитај повеќе →" },
            ["BackToNews"] = new() { ["en"] = "← Back to news", ["mk"] = "← Назад кон вестите" },
            ["NewsTitle1"] = new() { ["en"] = "SkopjeDrive adds 10 new cars to the fleet", ["mk"] = "SkopjeDrive додава 10 нови автомобили во возниот парк" },
            ["NewsSummary1"] = new() { ["en"] = "We're expanding our fleet with 10 brand new vehicles, including 3 SUVs.", ["mk"] = "Го прошируваме возниот парк со 10 сосема нови возила, меѓу кои и 3 SUV возила." },
            ["NewsContent1"] = new() { ["en"] = "We're excited to announce that SkopjeDrive has expanded its fleet with 10 brand new vehicles this month, including 3 SUVs and 2 vans. This upgrade means shorter waiting times and more choice for our customers, especially during the busy summer season.", ["mk"] = "Со задоволство објавуваме дека SkopjeDrive овој месец го прошири возниот парк со 10 сосема нови возила, меѓу кои 3 SUV возила и 2 комбиња. Ова проширување значи пократко чекање и поголем избор за нашите клиенти, особено во зафатената летна сезона." },
            ["NewsTitle2"] = new() { ["en"] = "New airport pick-up service", ["mk"] = "Нова услуга за преземање на аеродром" },
            ["NewsSummary2"] = new() { ["en"] = "Skip the taxi line — pick up your rental car directly at Skopje International Airport.", ["mk"] = "Заборавете на редот за такси — преземете го изнајмениот автомобил директно на Меѓународниот аеродром Скопје." },
            ["NewsContent2"] = new() { ["en"] = "Starting this month, SkopjeDrive offers direct pick-up and drop-off at Skopje International Airport 'Alexander the Great'. Simply select the airport location when booking online and our team will have your car ready when you land.", ["mk"] = "Почнувајќи од овој месец, SkopjeDrive нуди директно преземање и враќање на Меѓународниот аеродром Скопје „Александар Велики“. Само изберете ја локацијата аеродром при онлајн резервација и нашиот тим ќе го има вашиот автомобил подготвен кога ќе слетате." },
            ["NewsTitle3"] = new() { ["en"] = "Summer discount: 15% off weekly rentals", ["mk"] = "Летен попуст: 15% помалку за неделно изнајмување" },
            ["NewsSummary3"] = new() { ["en"] = "Book a car for 7 days or more this summer and save 15% on the total price.", ["mk"] = "Резервирајте автомобил за 7 или повеќе дена ова лето и заштедете 15% од вкупната цена." },
            ["NewsContent3"] = new() { ["en"] = "Planning a road trip around Macedonia this summer? Book any car for 7 days or more between June and September and get an automatic 15% discount on your total rental price. No coupon code needed — the discount is applied at checkout.", ["mk"] = "Планирате патување низ Македонија ова лето? Резервирајте кој било автомобил за 7 или повеќе дена помеѓу јуни и септември и добијте автоматски попуст од 15% на вкупната цена на изнајмувањето. Не е потребен купон — попустот се применува при плаќање." },
        };

        public static string T(string key, string culture)
        {
            if (Texts.TryGetValue(key, out var translations))
            {
                if (translations.TryGetValue(culture, out var value))
                    return value;
                return translations["en"];
            }
            return key;
        }
    }
}
