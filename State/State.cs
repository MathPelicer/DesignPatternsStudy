using System;

namespace State;

public abstract class State
{
    protected Context _context;

    public void SetContext(Context context)
    {
        _context = context;
    }

    public abstract void Grinding();

    public abstract void Extracting();
}
