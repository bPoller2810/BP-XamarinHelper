using de.bp.xf.helper.ErrorHandling;
using System;
using System.Threading.Tasks;

//https://johnthiriet.com/removing-async-void/#
namespace de.bp.xf.helper.Tasking
{
    public static class TaskFireAndForgetExtension
    {

#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler handler = null)
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                var eHandler = handler ?? new DefaultErrorHandler();
                eHandler?.HandleError(ex);
            }
        }

    }
}
