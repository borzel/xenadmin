using System;
using System.Drawing;
using System.Windows.Forms;

namespace XenAdmin.Core
{
    public static class FontSetter
    {
        public static void SetFont(DataGridViewCellCollection cells)
		{
			// TODO: Workaround: set font
            foreach (DataGridViewCell c in cells)
            {
                if (c.Style.Font == null)
                {
					c.Style.Font = SystemFonts.DefaultFont;
                }
            }
		}
    }
}
