namespace Proxy {

    /// <summary>
    ///  P r o x y ( I m a g e P r o x y ) — 保存一个引用使得代理可以访问实体。
    ///  若 R e a l S u b j e c t和S u b j e c t的接口相同，P r o x y会 引用S u b j e c t。
    ///  — 提供一个与S u b j e c t的接口相同的接口，这样代理就可以用来替代实体。
    ///  — 控制对实体的存取，并可能负责创建和删除它。 — 其他功能依赖于代理的类型：
    ///  • Remote Pro x y负责对请求及其参数进行编码，并向不同地址空间中的实体发送已编 码的请求。
    ///  • Virtual Pro x y可以缓存实体的附加信息，以便延迟对它的访问。
    ///  例如，动机一节中提 到的I m a g e P r o x y缓存了图像实体的尺寸。
    ///  • Protection Proxy检查调用者是否具有实现一个请求所必需的访问权限。 
    /// </summary>
	public class ProxyImage : IImage {

		private RealImage _realImage;
		private readonly string _fileName;

		public ProxyImage(string fileName) {
			this._fileName = fileName;
		}

		public void DisplayImage() {
			if (this._realImage == null) {
				this._realImage = new RealImage(this._fileName);
			}
			this._realImage.DisplayImage();
		}
	}
}