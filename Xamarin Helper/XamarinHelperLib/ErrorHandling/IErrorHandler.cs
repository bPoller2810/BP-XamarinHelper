using System;

namespace de.bp.xf.helper.ErrorHandling
{
    public interface IErrorHandler
    {

        void HandleError(Exception ex);

    }
}
