namespace Shared.Messages
{
    public sealed class FinishedPerformanceMessage : Message
    {
        public override string ToString()
        {
            return $"{nameof(FinishedPerformanceMessage)}";
        }
    }
}