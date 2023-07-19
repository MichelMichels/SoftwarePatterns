using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.ChainOfResponsibility.Base;

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