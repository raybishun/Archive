namespace DelegatesEventsLambdas_Events
{
    class EventPublisher
    {
        // declare the event
        public event MyEventHandler ValueChanged;



        private string theValue;

        public string TheValue
        {
            set
            {
                theValue = value;

                // when the value changes, fire the event
                ValueChanged(theValue);
            }
        }
    }
}
