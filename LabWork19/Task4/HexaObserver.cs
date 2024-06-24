namespace Task4
{
    internal class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: " + Convert.ToInt32(subject.GetState().ToString().ToUpper()));
        }
    }
}
