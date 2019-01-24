using System;
using System.Collections.Generic;
using System.Text;

namespace MichelsMichels.SoftwarePatterns.ChainOfResponsibility.Base
{
    public interface IHandler<TParam>
    {
        IHandler<TParam> SetSuccessor(IHandler<TParam> successor);
        void HandleRequest(TParam param);
    }
    public interface IHandler<TParam, TResult>
    {
        IHandler<TParam, TResult> SetSuccessor(IHandler<TParam, TResult> successor);
        TResult HandleRequest(TParam param);
    }
}
