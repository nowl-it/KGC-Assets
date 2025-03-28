namespace SRDebugger.Services
{
	public interface IProfilerService
	{
		float AverageFrameTime { get; }

		float LastFrameTime { get; }

		CircularBuffer<ProfilerFrame> FrameBuffer { get; }
	}
}
