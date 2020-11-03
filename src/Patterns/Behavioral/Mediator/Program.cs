
using Mediator.WithObserver;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var classicDialog = new Classic.ArticlesDialogBox();
            //classicDialog.SimulateInteractions();

            var dialogWithObserver = new ArticlesDialogBox();
            dialogWithObserver.SimulateInteractions();
        }
    }
}
