using System.Windows.Forms;

namespace ps_cafe
{
    internal static class Utilities
    {
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.FormClosed += (s, args) => currentForm.Close();
            newForm.Show();
        }
    }
}