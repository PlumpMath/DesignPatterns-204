namespace Bridge {

    /// <summary>
    /// Abstraction (Wi n d o w ) 
    /// 定义抽象类的接口。 — 维护一个指向Implementor类型对象的指针
    /// </summary>
	abstract class Shape {

		protected IDrawingApi DrawingApi;

		protected Shape(IDrawingApi drawingApi) {
			this.DrawingApi = drawingApi;
		}

		public abstract void Draw();

		public abstract void ResizeByPercent(double percent);

	}
}