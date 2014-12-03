using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Interactivity;

namespace Infrastructures.Behaviors
{
   public class HyperlinkBehavior : Behavior<Hyperlink>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.RequestNavigate += AssociatedObject_RequestNavigate;
        }

        void AssociatedObject_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
