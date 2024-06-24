namespace Task1
{
    internal class DescendingComparer : IComparer<Apartment>
    {
        public int Compare(Apartment? x, Apartment? y)
        {
            if (x is Apartment apartment1 && y is Apartment apartment2)
                return apartment2.RoomsCount.CompareTo(apartment1.RoomsCount);
            else
                return -1;
        }
    }
}
