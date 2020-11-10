using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.AppointmentDragOver += Scheduler_AppointmentDragOver;
        }
        private void Scheduler_AppointmentDragOver(object sender, AppointmentDragOverEventArgs e)
        {
            if (e.DraggingTime.Minute == 30 || e.DraggingTime.Minute == 00)
            {
                this.AssociatedObject.DragDropSettings.ShowTimeIndicator = true;
            }
            else
                this.AssociatedObject.DragDropSettings.ShowTimeIndicator = false;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.AppointmentDragOver -= Scheduler_AppointmentDragOver;
            this.scheduler = null;
        }
    }
}
