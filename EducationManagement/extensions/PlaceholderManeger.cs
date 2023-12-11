using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement.extensions
{
    public static class PlaceholderManeger
    {
        public static void AddPlaceholder(this TextBox tb, string placeholder)
        {
            tb.ForeColor = Color.Gray; tb.Text = placeholder;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholder;
                }
            };
        }

    }
}
