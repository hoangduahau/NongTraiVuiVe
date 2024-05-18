namespace NongTraiVuiVe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new Frm_Main());
            Frm_DangNhap loginForm = new Frm_DangNhap();
            Application.Run(loginForm);
            if (loginForm.isLogin)
            {
                Application.Run(new Frm_Main());
            }
        }
    }
}