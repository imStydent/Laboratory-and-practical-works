namespace Task4
{
    internal class Subject
    {
        private List<Observer> Observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
