using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ProjectorReservationSystem.Controls;

namespace ProjectorReservationSystem.Helpers
{
    /// <summary>
    /// Shared UI helpers: status pill colors/drawing (Pending, Approved, ...) and the common
    /// DataGridView look used by the Reservations and Equipment tables.
    /// </summary>
    internal static class UiHelper
    {
        private static readonly Font PillFont = new Font("Segoe UI Semibold", 9f);

        /// <summary>Background and text color of the pill for a status name (case-insensitive).</summary>
        public static (Color Back, Color Fore) GetStatusColors(string? status)
        {
            switch ((status ?? "").Trim().ToLowerInvariant())
            {
                case "pending":
                    return (Color.FromArgb(254, 243, 199), Color.FromArgb(133, 77, 14));
                case "approved":
                case "available":
                    return (Color.FromArgb(209, 250, 229), Color.FromArgb(21, 128, 61));
                case "rejected":
                case "broken":
                    return (Color.FromArgb(254, 226, 226), Color.FromArgb(185, 28, 28));
                case "in use":
                    return (Color.FromArgb(219, 234, 254), Color.FromArgb(30, 58, 138));
                case "under repair":
                    return (Color.FromArgb(255, 237, 213), Color.FromArgb(154, 52, 18));
                default:   // Returned, Completed, anything else = neutral gray
                    return (Color.FromArgb(238, 238, 243), Color.FromArgb(55, 65, 81));
            }
        }

        /// <summary>Draws a rounded status pill, left-aligned and vertically centered inside a grid cell. scale = DeviceDpi / 96f.</summary>
        public static void DrawStatusPill(Graphics g, Rectangle cell, string? status, int leftPadding = 12, float scale = 1f)
        {
            string text = status ?? "";
            if (text.Length == 0) return;

            var (back, fore) = GetStatusColors(text);
            const TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                                        | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine;

            Size textSize = TextRenderer.MeasureText(g, text, PillFont, new Size(int.MaxValue, int.MaxValue), flags);
            int height = (int)Math.Round(24 * scale);
            var pill = new Rectangle(cell.X + leftPadding, cell.Y + (cell.Height - height) / 2, textSize.Width + (int)Math.Round(22 * scale), height);

            var oldMode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = RoundedPanel.RoundedRect(pill, height / 2))
            using (var brush = new SolidBrush(back))
            {
                g.FillPath(brush, path);
            }
            g.SmoothingMode = oldMode;

            TextRenderer.DrawText(g, text, PillFont, pill, fore, flags);
        }

        /// <summary>Applies the mockup's table look: flat, hairline rows, lavender selection, 42px rows.</summary>
        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Theme.Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Theme.Line;
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = grid.LogicalToDeviceUnits(40);
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Theme.Surface,
                ForeColor = Theme.InkMuted,
                Font = Theme.Body,
                SelectionBackColor = Theme.Surface,
                SelectionForeColor = Theme.InkMuted,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(grid.LogicalToDeviceUnits(12), 0, 0, 0)
            };

            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Theme.Surface,
                ForeColor = Theme.Ink,
                Font = Theme.Body,
                SelectionBackColor = Theme.BrandSoft,
                SelectionForeColor = Theme.Ink,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(grid.LogicalToDeviceUnits(12), 0, 0, 0)
            };

            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = grid.LogicalToDeviceUnits(42);
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.StandardTab = true;
        }
    }
}
