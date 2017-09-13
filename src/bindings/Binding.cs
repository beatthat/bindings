
namespace BeatThat
{
	/// <summary>
	/// A Binding is a safe reference to a listener binding that can be queried 'isBound' and used to unbind the listener.
	///
	/// A Binding, should survive the destruction of its owner.
	/// 
	/// Useful for cases where something that you would want to Bind with
	/// the guarantee that the binding will be cleaned up if, say, the binding object is destroyed.
	/// </summary>
	public interface Binding
	{
		void Unbind();

		bool isBound { get; }
	}
}
