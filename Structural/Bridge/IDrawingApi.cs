namespace Bridge {

    /// <summary>
    /// Implementor (WindowImp)
    /// 定义实现类的接口，该接口不一定要与 A b s t r a c t i o n的接口完全一致；
    /// 事实上这两个 接口可以完全不同。一般来讲， I m p l e m e n t o r接口仅提供基本操作，
    /// 而 A b s t r a c t i o n则 定义了基于这些基本操作的较高层次的操作。 
    /// </summary>
    interface IDrawingApi {

		void DrawCircle(double x, double y, double radius);

	}
}