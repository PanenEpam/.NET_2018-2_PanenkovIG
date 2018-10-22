using System;
namespace Task2
{
	public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
