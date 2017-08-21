
namespace BeatThat
{
	/// <summary>
	/// Safe handle to a binding, e.g. the Binding for an IPresenter.
	/// 
	/// Useful for cases where something that you would want to Bind and then later Unbind
	/// may be a unity Component and may be destroyed when you want to unbind it.
	/// 
	/// A Binding, should survive the destruction
	/// of its owner, and therefore is safe to hold and use.
	/// </summary>
	public interface Binding
	{
		void Unbind();
		
		bool isBound { get; }

	}
}
