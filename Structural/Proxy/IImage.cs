namespace Proxy {

    /// <summary>
    /// S u b j e c t (IImage) — 定义RealSubject 和P r o x y的共用接口，
    /// 这样就在任何使用R e a l S u b j e c t的地方都可以使 用P r o x y
    /// </summary>
	public interface IImage {

		void DisplayImage();

	}
}