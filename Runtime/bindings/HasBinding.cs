
namespace BeatThat
{
	/// <summary>
	/// Interface for any component that shares its Binding property.
	/// </summary>
	public interface HasBinding
	{
		/// <summary>
		/// Gets an always safe (as opposed to a unity component that might be destroyed) handle for unbinding/cleanup
		/// (the Binding survives the destruction of its owner, which may be a unity Component attached to a GameObject).
		/// </summary>
		Binding binding { get; }
	}
}
