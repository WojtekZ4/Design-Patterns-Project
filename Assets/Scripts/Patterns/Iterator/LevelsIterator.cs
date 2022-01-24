class LevelsIterator : Iterator
{
    private readonly LevelsContainer myCollection;

    private int position = -1;
    private readonly int size;

    public LevelsIterator(LevelsContainer collection)
    {
        myCollection = collection;
        size = myCollection.GetLevels().Length;
    }
    public override object Current()
    {
        return myCollection.GetLevels()[position];
    }
    public override bool MoveNext()
    {
        position++;
        return position < size;
    }

    public override void Reset()
    {
        position = -1;
    }
}
