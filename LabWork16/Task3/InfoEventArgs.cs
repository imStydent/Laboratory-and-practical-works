namespace Task3
{
    internal class InfoEventArgs : EventArgs
    {
        public string propertyName { get; set; }
        public string mistake { get; set; }
        public DateTime dateTimeChange { get; set; }
    }
}
