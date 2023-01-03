namespace Inheritance.Interfaces
{
    public interface ICopiaDeValor<T> where T : new ()
    {
		void CopiarPara(T objetoAlvo);

		public T DeepCopy()
		{
			T t = new T();
			CopiarPara(t);
			return t;
		}
	}
}
