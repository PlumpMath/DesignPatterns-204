namespace Bridge {

    /// <summary>
    /// Abstraction (Wi n d o w ) 
    /// ���������Ľӿڡ� �� ά��һ��ָ��Implementor���Ͷ����ָ��
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