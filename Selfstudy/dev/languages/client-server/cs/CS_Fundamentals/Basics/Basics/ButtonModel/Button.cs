using System;

namespace Basics.ButtonModel
{
    class Button
    {
        public EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick() {
            // ClickEvent.Invoke(this, EventArgs.Empty);

            MyCustomArguments myArgs = new()
            {
                Name = "Ray"
            };
            ClickEvent.Invoke(this, myArgs);
        }
    }
}