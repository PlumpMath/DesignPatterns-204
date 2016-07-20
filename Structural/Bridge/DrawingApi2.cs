using System;

namespace Bridge {

    /// <summary>
    ///  ConcreteImplementor (XwindowImp, PMWi n d o w I m p ) — 实现Implementor接口并定义它的具体实现。
    /// </summary>
	class DrawingApi2 : IDrawingApi {

		public void DrawCircle(double x, double y, double radius) {
			Console.WriteLine("API2.circle at {0},{1} radius {2}", x, y, radius);
		}
	}
}