namespace Bridge {

    /// <summary>
    /// Implementor (WindowImp)
    /// ����ʵ����Ľӿڣ��ýӿڲ�һ��Ҫ�� A b s t r a c t i o n�Ľӿ���ȫһ�£�
    /// ��ʵ�������� �ӿڿ�����ȫ��ͬ��һ�������� I m p l e m e n t o r�ӿڽ��ṩ����������
    /// �� A b s t r a c t i o n�� �����˻�����Щ���������Ľϸ߲�εĲ����� 
    /// </summary>
    interface IDrawingApi {

		void DrawCircle(double x, double y, double radius);

	}
}