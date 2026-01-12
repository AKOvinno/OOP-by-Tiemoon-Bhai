using System.Windows.Forms;

namespace PersonExampleInWindowsForm
{
    class EntryPoint
    {
        public static void Main()
        {
            PersonInformationUI personInformationUIObj = new PersonInformationUI();
            Application.Run(personInformationUIObj);
        }
    }
}
