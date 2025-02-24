using netflix_opensilver.Core.Parameter;

namespace netflix_opensilver.Core.Dialog
{
    public class DialogResult : IDialogResult
    {
        public bool Success { get; set; }
        public Parameters Parameters { get; set; }

        public DialogResult(bool success = false, Parameters? parameters = null)
        {
            Success = success;
            Parameters = parameters ?? new Parameters();
        }
    }
}
