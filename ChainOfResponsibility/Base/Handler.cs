using System;
using System.Collections.Generic;
using System.Text;

namespace MichelsMichels.SoftwarePatterns.ChainOfResponsibility.Base
{
    public abstract class Handler<TParam> : IHandler<TParam>
    {
        // Fields
        protected IHandler<TParam> successor;

        // Methods
        public abstract void HandleRequest(TParam param);       
        public virtual IHandler<TParam> SetSuccessor(IHandler<TParam> successor)
        {
            this.successor = successor;
            return successor;
        }
    }
    public abstract class Handler<TParam, TResult> : IHandler<TParam, TResult>
    {
        // Fields
        protected IHandler<TParam, TResult> successor;

        // Methods
        public abstract TResult HandleRequest(TParam param);
        public virtual IHandler<TParam, TResult> SetSuccessor(IHandler<TParam, TResult> successor)
        {
            this.successor = successor;
            return successor;
        }
    }
}
