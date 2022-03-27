using System;

namespace Snap.Data.Primitive
{
    /// <summary>
    /// 提供简单易用的状态提示信息
    /// 用于任务的状态跟踪
    /// 同时继承了 <see cref="Observable"/>
    /// </summary>
    public class WorkWatcher : Observable
    {
        private readonly bool isReusable;
        private bool hasUsed = false;
        private bool isWorking;
        private bool isCompleted;

        public bool IsWorking
        {
            get => this.isWorking;

            set => this.Set(ref this.isWorking, value);
        }

        public bool IsCompleted
        {
            get => this.isCompleted;

            set => this.Set(ref this.isCompleted, value);
        }

        private struct WorkDisposable : IDisposable
        {
            private readonly WorkWatcher work;
            public WorkDisposable(WorkWatcher work)
            {
                this.work = work;
            }

            public void Dispose()
            {
                this.work.IsWorking = false;
                this.work.IsCompleted = true;
            }
        }

        public WorkWatcher(bool isReusable = true)
        {
            this.isReusable = isReusable;
        }

        public IDisposable Watch()
        {
            if (!this.isReusable && this.hasUsed)
            {
                throw new InvalidOperationException($"此 {nameof(WorkWatcher)} 不允许多次使用");
            }
            this.hasUsed = true;
            this.IsWorking = true;
            return new WorkDisposable(this);
        }
    }
}
