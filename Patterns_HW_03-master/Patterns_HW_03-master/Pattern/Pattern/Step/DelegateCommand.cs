using System;

namespace Pattern.Step
{
    public class DelegateCommand
    {
        private Action<object> executeErase;
        private Func<object, bool> canErase;

        public DelegateCommand(Action<object> executeErase, Func<object, bool> canErase)
        {
            this.executeErase = executeErase;
            this.canErase = canErase;
        }
    }
}