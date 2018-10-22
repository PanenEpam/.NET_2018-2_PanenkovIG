using System;
namespace Task3
{
	public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
