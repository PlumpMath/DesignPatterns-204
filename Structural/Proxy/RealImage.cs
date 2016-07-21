using System;

namespace Proxy {

    /// <summary>
    /// R e a l S u b j e c t (RealImage) �� ����P r o x y�������ʵ�塣 
    /// </summary>
	public class RealImage : IImage {

		private readonly string _fileName;

		public RealImage(string fileName) {
			this._fileName = fileName;
			this.LoadImageFromFile();
		}

		private void LoadImageFromFile() {
			Console.WriteLine("Load image from file {0}", this._fileName);
		}

		public void DisplayImage() {
			Console.WriteLine("Displaying image {0}", this._fileName);
		}

	}
}