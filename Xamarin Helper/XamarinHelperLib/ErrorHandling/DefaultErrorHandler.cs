using System;
using System.Diagnostics;

namespace de.bp.xf.helper.ErrorHandling
{
    public class DefaultErrorHandler : IErrorHandler
    {

        #region IErrorHandler

        public void HandleError(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
        }

        #endregion

    }
}
