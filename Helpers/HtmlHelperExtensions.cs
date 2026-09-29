using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkopjeDrive.Helpers
{
    public static class HtmlHelperExtensions
    {
        // Usage in Razor views: @Html.T("NavHome")
        public static string T(this IHtmlHelper html, string key)
        {
            return Translator.T(key, html.CurrentCulture());
        }

        public static string CurrentCulture(this IHtmlHelper html)
        {
            if (html.ViewContext.HttpContext.Request.Cookies.TryGetValue("culture", out var cookieCulture)
                && !string.IsNullOrEmpty(cookieCulture))
            {
                return cookieCulture;
            }
            return "en";
        }

        public static string ValidationMessageT(this IHtmlHelper html, string fieldName)
        {
            if (!html.ViewData.ModelState.TryGetValue(fieldName, out var state))
            {
                return string.Empty;
            }

            var message = state.Errors.FirstOrDefault()?.ErrorMessage;
            return string.IsNullOrWhiteSpace(message)
                ? string.Empty
                : Translator.T(message, html.CurrentCulture());
        }

        public static IReadOnlyList<string> ValidationSummaryT(this IHtmlHelper html)
        {
            if (!html.ViewData.ModelState.TryGetValue(string.Empty, out var state))
            {
                return Array.Empty<string>();
            }

            var culture = html.CurrentCulture();
            return state.Errors
                .Select(error => Translator.T(error.ErrorMessage, culture))
                .ToArray();
        }
    }
}
