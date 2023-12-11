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

        public static void AddPlaceholderComboBox(this ComboBox cb, string placeholder)
        {

            cb.ForeColor = Color.Gray; 
            cb.Items.Add(placeholder);
            cb.Enter += (s, e) =>
            {
                if (cb.Text == placeholder)
                {
                    cb.ForeColor = Color.Black;
                    cb.Items.Remove(placeholder);
                }
            };

            cb.Leave += (s, e) =>
            {
                if (cb.Text == "")
                {
                    cb.ForeColor = Color.Gray;
                    cb.Text = placeholder;
                }
            };
        }

    }
}
