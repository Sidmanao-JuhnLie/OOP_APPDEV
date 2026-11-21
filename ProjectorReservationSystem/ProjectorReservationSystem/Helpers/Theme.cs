using System.Drawing;

namespace ProjectorReservationSystem.Helpers
{
    /// <summary>
    /// Central design tokens (colors + fonts) taken from the mockup PDF and the redesign guide.
    /// NOTE: this class used to live in the namespace "ProjectorReservationSystem.Theme", which
    /// has the same name as the class and makes "Theme.Brand" fail to compile elsewhere.
    /// It now lives in ProjectorReservationSystem.Helpers (next to UiHelper).
    /// </summary>
    internal static class Theme
    {
        // ---- Brand / surfaces -------------------------------------------------
        public static readonly Color Brand       = Color.FromArgb(91, 63, 245);    // #5B3FF5 primary buttons, active nav, bars
        public static readonly Color BrandHover  = Color.FromArgb(74, 49, 214);    // #4A31D6
        public static readonly Color BrandLight  = Color.FromArgb(122, 92, 250);   // #7A5CFA hero gradient end
        public static readonly Color BrandSoft   = Color.FromArgb(239, 236, 254);  // #EFECFE active nav bg, avatar bg
        public static readonly Color Canvas      = Color.FromArgb(246, 246, 252);  // #F6F6FC middle panel
        public static readonly Color Surface     = Color.White;                    // window, sidebars, cards
        public static readonly Color Line        = Color.FromArgb(236, 236, 244);  // #ECECF4 hairlines
        public static readonly Color BarGray     = Color.FromArgb(229, 229, 238);  // #E5E5EE comparison bars, input borders
        public static readonly Color HeroCaption = Color.FromArgb(233, 229, 255);  // #E9E5FF small text on hero card

        // ---- Text -------------------------------------------------------------
        public static readonly Color Ink         = Color.FromArgb(31, 29, 59);     // #1F1D3B main text
        public static readonly Color InkMuted    = Color.FromArgb(107, 107, 138);  // #6B6B8A captions

        // ---- Status colors (bright = dots/bars, icon = filled circles) --------
        public static readonly Color Pending     = Color.FromArgb(245, 158, 11);
        public static readonly Color Approved    = Color.FromArgb(16, 185, 129);
        public static readonly Color Success     = Color.FromArgb(22, 163, 74);    // approved icon circle
        public static readonly Color Rejected    = Color.FromArgb(239, 68, 68);
        public static readonly Color Danger      = Color.FromArgb(220, 38, 38);    // rejected icon circle
        public static readonly Color InUse       = Color.FromArgb(59, 130, 246);
        public static readonly Color UnderRepair = Color.FromArgb(249, 115, 22);
        public static readonly Color Returned    = Color.FromArgb(156, 163, 175);

        // ---- Fonts (Segoe UI ships with every Windows install) ------------------
        public static readonly Font Display     = new Font("Segoe UI Semibold", 20f);
        public static readonly Font StatHero    = new Font("Segoe UI Semibold", 32f);
        public static readonly Font StatNumber  = new Font("Segoe UI Semibold", 28f);
        public static readonly Font CardTitle   = new Font("Segoe UI Semibold", 11f);
        public static readonly Font Body        = new Font("Segoe UI", 10f);
        public static readonly Font BodyBold    = new Font("Segoe UI Semibold", 10f);
        public static readonly Font Caption     = new Font("Segoe UI", 9f);
        public static readonly Font CapsCaption = new Font("Segoe UI Semibold", 8f);
    }
}
