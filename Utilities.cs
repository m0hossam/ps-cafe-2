using System.Windows.Forms;

namespace ps_cafe
{
    internal static class Utilities
    {
        public static float ONE_HOUR_PRICE = 100.0F;
        public static string username;
        public static void ChangeForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.FormClosed += (s, args) => currentForm.Close();
            newForm.Show();
        }
    }
}